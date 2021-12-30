using MQTTnet;
using MQTTnet.Server;
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

        public int MessageCounter { get; private set; }
        MqttServerOptionsBuilder options;

        private void Form1_Load(object sender, EventArgs e)
        {
            server = new SimpleTcpServer();
            server.Delimiter = 0x13;
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += Server_DataReceived;
            server.ClientConnected += Server_ClientConnected;
        }

        private void OnNewMessage(MqttApplicationMessageInterceptorContext context)
        {
            var payload = context.ApplicationMessage?.Payload == null ? null : Encoding.UTF8.GetString(context.ApplicationMessage?.Payload);

            MessageCounter++;
            var str = string.Format("MessageId: {0} - TimeStamp: {1} -- Message: ClientId = {2}, Topic = {3}, Payload = {4}, QoS = {5}, Retain-Flag = {6}",
        MessageCounter,
        DateTime.Now,
        context.ClientId,
        context.ApplicationMessage?.Topic,
        payload,
        context.ApplicationMessage?.QualityOfServiceLevel,
        context.ApplicationMessage?.Retain);
            txtStatus.Text += str+Environment.NewLine;
        }

        private void OnNewConnection(MqttConnectionValidatorContext context)
        {
            var str = string.Format("New connection: ClientId = {0}, Endpoint = {1}", context.ClientId, context.Endpoint);
            txtStatus.Text += str + Environment.NewLine;
        }

        private void Server_ClientConnected(object sender, TcpClient e)
        {
            //byte[] dt = Encoding.Default.GetBytes(txtMessage.Text);
            //e.Client.Send(dt, 0, dt.Length,SocketFlags.None);
            client = e;
            txtStatus.Invoke((MethodInvoker)delegate ()
            {
                txtClientIP.Text = e.Client.RemoteEndPoint.ToString().Split(':')[0];
                txtClintPort.Text = e.Client.RemoteEndPoint.ToString().Split(':')[1];
                txtStatus.Text += e.Client.RemoteEndPoint.ToString()+" Connected..."+Environment.NewLine;
                txtStatus.ScrollToCaret();
            });
        }

        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
       //     eg = e.TcpClient
            txtStatus.Invoke((MethodInvoker)delegate ()
            {
                txtStatus.Text += string.Format("{0} : {1}{2}", DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"), BitConverter.ToString(e.Data).Replace("-", ""), Environment.NewLine);
                //txtStatus.Text += e.MessageString;
                txtStatus.ScrollToCaret();
                scrollToLast();
              //  e.ReplyLine(((char)06).ToString());
            });
            scrollToLast();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (rdbMqtt.Checked)
            {
                options = new MqttServerOptionsBuilder()
                                     // set endpoint to localhost
                                     .WithDefaultEndpointBoundIPAddress(IPAddress.Parse(txtHost.Text))
                                     // port used will be 707
                                     .WithDefaultEndpointPort(Convert.ToInt32(txtPort.Text))
                                     // handler for new connections
                                     .WithConnectionValidator(OnNewConnection)
                                     // handler for new messages
                                     .WithApplicationMessageInterceptor(OnNewMessage);

                // creates a new mqtt server     
                IMqttServer mqttServer = new MqttFactory().CreateMqttServer();

                // start the server with options  
                mqttServer.StartAsync(options.Build()).GetAwaiter().GetResult();
                txtStatus.Text = "Server Started.."+ mqttServer.IsStarted;
            }
            else
            {

                txtStatus.Text = "Server Started..";
                IPAddress ip = IPAddress.Parse(txtHost.Text);
                server.Start(ip, Convert.ToInt32(txtPort.Text));
            }
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
        async Task scrollToLast()
        {
            txtMessage.ScrollToCaret();
            txtStatus.ScrollToCaret();
            txtMessage.Refresh();
            txtMessage.Refresh();
            this.Refresh();
        }
    }
}
