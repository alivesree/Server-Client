using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class frmServer : Form
    {
        public frmServer()
        {
            InitializeComponent();
        }
        SimpleTcpServer server;
        TcpClient client;
        private void Form1_Load(object sender, EventArgs e)
        {
            server = new SimpleTcpServer();
            server.Delimiter = 0x13;
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += Server_DataReceived;
            server.ClientConnected += Server_ClientConnected;
        }

        private void Server_ClientConnected(object sender, TcpClient e)
        {
            //byte[] dt = Encoding.Default.GetBytes(txtMessage.Text);
            //e.Client.Send(dt, 0, dt.Length,SocketFlags.None);
            client = e;
        }

        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
       //     eg = e.TcpClient
            txtStatus.Invoke((MethodInvoker)delegate ()
            {

                txtStatus.Text += e.MessageString;
                e.ReplyLine(((char)06).ToString());
            });
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            txtStatus.Text = "Started..";
            IPAddress ip = IPAddress.Parse(txtHost.Text);
            server.Start(ip, Convert.ToInt32(txtPort.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (server.IsStarted)
            {
                server.Stop();
            }
        }

        private void brnSend_Click(object sender, EventArgs e)
        {
            byte[] dt = Encoding.Default.GetBytes(txtMessage.Text);
            client.Client.Send(dt, 0, dt.Length, SocketFlags.None);
        }
    }
}
