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
                    SetMessage(Encoding.UTF8.GetString(buffer, 0, n));
                }
                catch (Exception ex)
                {
                    SetMessage(ex.Message);
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
            SetMessage(ContenttextBox.Text);
            byte[] buffer = Encoding.UTF8.GetBytes(ContenttextBox.Text);
            ClientList[ClientListcomboBox.Items[0].ToString()].Send(buffer);
        }
    }
}
