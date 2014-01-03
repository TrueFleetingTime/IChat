using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace IChatService
{
    public partial class IChatService : Form
    {
        public IChatService()
        {
            InitializeComponent();
        }

        private void IChatService_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            IPtextBox.Text = "127.0.0.1";
            PorttextBox.Text = "8888";
        }

        private void Listeningbutton_Click(object sender, EventArgs e)
        {
            IPAddress IP = IPAddress.Parse(IPtextBox.Text);
            IPEndPoint IPPort = new IPEndPoint(IP, int.Parse(PorttextBox.Text));
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Bind(IPPort);
            socket.Listen(10);
            SetMessage("开始监听");
            Thread thread = new Thread(ListeningClient);
            thread.IsBackground = true;
            thread.Start(socket);
        }
        Dictionary<string, Socket> ClientList = new Dictionary<string, Socket>();
        void ListeningClient(object o)
        {
            Socket socket = o as Socket;
            while (true)
            {
                try
                {
                    Socket socketSession = socket.Accept();
                    string clientIP = socketSession.RemoteEndPoint.ToString();
                    ClientList.Add(clientIP, socketSession);
                    ClientListcomboBox.Items.Add(clientIP);
                    SetMessage(string.Format("终端{0}连上主机", clientIP));
                    Thread thread = new Thread(ClientSession);
                    thread.IsBackground = true;
                    thread.Start(socketSession);
                }
                catch (Exception ex)
                {
                    SetMessage(ex.Message);
                }
            }
        }
        void ClientSession(object o)
        {
            Socket client = o as Socket;
            while (true)
            {
                try
                {
                    byte[] buffer = new byte[1024 * 1024];
                    int n = client.Receive(buffer);
                    SetMessage(string.Format("{0}:{1}", client.RemoteEndPoint, Encoding.UTF8.GetString(buffer, 0, n)));
                }
                catch (Exception ex)
                {
                    SetMessage(ex.Message);
                    ClientList.Remove(client.RemoteEndPoint.ToString());
                    ClientListcomboBox.Items.Remove(client.RemoteEndPoint.ToString());
                    break;
                }
            }
        }

        void SetMessage(string message)
        {
            MessagetextBox.AppendText(message + "\r\n");
        }

        private void SendContentbutton_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] buffer = Encoding.UTF8.GetBytes(ContenttextBox.Text);
                ClientList[ClientListcomboBox.Text].Send(buffer);
                SetMessage(string.Format("{0}:{1}", ClientList[ClientListcomboBox.Text].LocalEndPoint, ContenttextBox.Text));

            }
            catch (Exception ex)
            {
                SetMessage(ex.Message);
            }
            finally
            {
                ContenttextBox.Text = "";
            }
        }

        private void ClearContentbutton_Click(object sender, EventArgs e)
        {
            ContenttextBox.Text = "";
        }

        private void ContenttextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    try
                    {

                        byte[] buffer = Encoding.UTF8.GetBytes(ContenttextBox.Text);
                        ClientList[ClientListcomboBox.Text].Send(buffer);
                        SetMessage(string.Format("{0}:{1}", ClientList[ClientListcomboBox.Text].LocalEndPoint, ContenttextBox.Text));
                    }
                    catch (Exception ex)
                    {
                        SetMessage(ex.Message);
                    }
                    finally
                    {
                        ContenttextBox.Text = "";
                    }
                }
            }
        }

        private void ContenttextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\n')
            {
                e.Handled = true;
            }
        }
    }
}
