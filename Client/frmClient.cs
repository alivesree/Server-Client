using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace client
{
    public partial class frmClient : Form
    {
        public frmClient()
        {
            InitializeComponent();
        }
        SimpleTcpClient client;
        MqttClient Mqclient;
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {

                if (rdbMQTT.Checked)
                {
                    Mqclient = new MqttClient(txtHost.Text);
                    Mqclient.MqttMsgPublishReceived += client_MqttMsgPublishReceived;
                    Mqclient.Subscribe(new string[] { txtTopic.Text }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
                    Mqclient.Connect("SDH-DebugTool");
                }
                else
                {
                    btnConnect.Enabled = false;
                    client.Connect(txtHost.Text, Convert.ToInt32(txtPort.Text));
                }
            }
            catch (Exception ex)
            {
                btnConnect.Enabled = true;
                MessageBox.Show(ex.Message);
               // txtStatus.Text += ex.Message;
            }

        }
        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                btnConnect.Enabled = true;
                if (Mqclient != null && Mqclient.IsConnected)
                {
                    Mqclient.Disconnect();
                }

                client.Disconnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new SimpleTcpClient();
            client.StringEncoder = Encoding.UTF8;
            client.DataReceived += Client_DataReceived;
        }

        private void Client_DataReceived(object sender, SimpleTCP.Message e)
        {
            txtStatus.Invoke((MethodInvoker)delegate ()
            {
                txtHex.Text += string.Format("{0} : {1}{2}", DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"), BitConverter.ToString(e.Data).Replace("-", ""), Environment.NewLine);
                txtStatus.Text += string.Format("{0} : {1}{2}", DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"), e.MessageString, Environment.NewLine);
            });
        }

        private void brnSend_Click(object sender, EventArgs e)
        {
            try
            {

                if (rdbMQTT.Checked && Mqclient.IsConnected)
                {
                    Mqclient.Publish(txtTopic.Text, Encoding.ASCII.GetBytes(txtMessage.Text)); // Publishing message from client.
                }
                else if (rdbTCP.Checked)
                {
                    client.WriteLine(txtMessage.Text);
                }
                else if (rdbUDP.Checked)
                {
                    IPEndPoint RemoteEndPoint = new IPEndPoint(IPAddress.Parse(txtHost.Text), Convert.ToInt32(txtPort.Text));
                    Socket server = new Socket(AddressFamily.InterNetwork,
                                               SocketType.Dgram, ProtocolType.Udp);
                    string msg = (char)0x0A + txtMessage.Text + (char)0x0D;
                    var data = Encoding.ASCII.GetBytes(msg);
                    server.SendTo(data, data.Length, SocketFlags.None, RemoteEndPoint);
                }
                else
                {
                    MessageBox.Show("Not Connected!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            txtHex.Text += string.Format("{0} : {1}{2}", DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"), BitConverter.ToString(e.Message).Replace("-", ""), Environment.NewLine);
            txtStatus.Text += string.Format("{0} : {1}{2}", DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"), Encoding.ASCII.GetString(e.Message), Environment.NewLine);
        }

        private void rdbMQTT_CheckedChanged(object sender, EventArgs e)
        {
            txtTopic.Clear();
            txtTopic.Enabled = rdbMQTT.Checked;
            btnConnect.Enabled = true;
        }

        private void rdbUDP_CheckedChanged(object sender, EventArgs e)
        {
            btnConnect.Enabled = !rdbUDP.Checked;
        }
    }


}

