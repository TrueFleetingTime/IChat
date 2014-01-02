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

namespace IChatClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            IPtextBox.Text = "127.0.0.1";
            PorttextBox.Text = "8888";
        }

        private void Connectbutton_Click(object sender, EventArgs e)
        {
            IPAddress IP = IPAddress.Parse(IPtextBox.Text);
            IPEndPoint IPPort = new IPEndPoint(IP, int.Parse(PorttextBox.Text));
            try
            {
                socket.Connect(IPPort);
                SetMessage(string.Format("成功连接上主机{0}", socket.RemoteEndPoint));
                Thread thread = new Thread(sockeSession);
                thread.IsBackground = true;
                thread.Start();
            }
            catch (Exception ex)
            {
                SetMessage(ex.Message);
            }
        }
        void sockeSession()
        {
            while (true)
            {
                byte[] buffer = new byte[1024 * 1024];
                int n = socket.Receive(buffer);
                SetMessage(Encoding.UTF8.GetString(buffer, 0, n));
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
            socket.Send(buffer);
        }
    }
}
