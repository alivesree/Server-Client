using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
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
        SimpleTcpClient eg;
        private void Form1_Load(object sender, EventArgs e)
        {
            server = new SimpleTcpServer();
            server.Delimiter = 0x13;
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += Server_DataReceived;
        }

        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            txtStatus.Invoke((MethodInvoker)delegate ()
            {
                txtStatus.Text += e.MessageString;
                e.ReplyLine(string.Format("Recieved {0},{1}",e.TcpClient.Client, e.MessageString));
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
            //SimpleTcpClient client = new SimpleTcpClient();
            //    client.TcpClient.Client = new System.Net.Sockets.Socket(,);
            //client.StringEncoder = Encoding.UTF8;
            //client.WriteLine("asdf");
        }
    }
}
