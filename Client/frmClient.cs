using MetroFramework.Forms;
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
    public partial class frmClient : MetroForm
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
                    Mqclient = new MqttClient(txtHost.Text, Convert.ToInt32(txtPort.Text), false, null, null, MqttSslProtocols.TLSv1_2);
                    Mqclient.MqttMsgPublishReceived += client_MqttMsgPublishReceived;
                    Mqclient.Subscribe(new string[] { txtTopic.Text }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
                    Mqclient.Connect("SDH-DebugTool"+DateTime.Now.ToString("ss-fff"));
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
            Mqclient = new MqttClient(txtHost.Text);
            client.StringEncoder = Encoding.UTF8;
            client.DataReceived += Client_DataReceived;
        }

        private void Client_DataReceived(object sender, SimpleTCP.Message e)
        {
            txtStatus.Invoke((MethodInvoker)delegate ()
            {
                txtHex.Text += string.Format("{0} : {1}{2}", DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"), BitConverter.ToString(e.Data).Replace("-", ""), Environment.NewLine);
                txtStatus.Text += string.Format("{0} : {1}{2}", DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"), e.MessageString, Environment.NewLine);
                scrollToLast();
            });
        }

        private async void brnSend_Click(object sender, EventArgs e)
        {
            try
            {

                if (rdbMQTT.Checked && Mqclient.IsConnected)
                {
                    if (chkLoop.Checked)
                    {
                        UInt64 i = 0;
                        if (loopCount.Value==0)
                        { 
                            while (true)
                            {
                                Mqclient.Publish(txtTopic.Text, Encoding.ASCII.GetBytes( txtMessage.Text.Replace("{i}",i++.ToString()))); // Publishing message from client.
                                await Task.Delay(Convert.ToInt32(txtNumDelay.Text));
                            }
                        }
                        for ( i = 0; i < loopCount.Value; i++)
                        {
                            Mqclient.Publish(txtTopic.Text, Encoding.ASCII.GetBytes(txtMessage.Text)); // Publishing message from client.
                            await Task.Delay(Convert.ToInt32(txtNumDelay.Text));
                        } 
                    }
                    else
                    Mqclient.Publish(txtTopic.Text, Encoding.ASCII.GetBytes(txtMessage.Text)); // Publishing message from client.
                }
                else if (rdbTCP.Checked)
                {
                    if (chkLoop.Checked)
                    {
                        for (int i = 0; i < loopCount.Value; i++)
                        {
                            await Task.Delay(750);
                            client.Write(Encoding.ASCII.GetBytes(txtMessage.Text));
                        }
                    }
                    else
                        client.Write(Encoding.ASCII.GetBytes(txtMessage.Text));
                    //client.WriteLineAndGetReply(txtMessage.Text,new TimeSpan(2));
                }
                else if (rdbUDP.Checked)
                {
                    IPEndPoint RemoteEndPoint = new IPEndPoint(IPAddress.Parse(txtHost.Text), Convert.ToInt32(txtPort.Text));
                    Socket server = new Socket(AddressFamily.InterNetwork,
                                               SocketType.Dgram, ProtocolType.Udp);
                    string msg = (char)0x0A + txtMessage.Text + (char)0x0D;
                    var data = Encoding.ASCII.GetBytes(msg);
                    if (chkLoop.Checked)
                    {
                        for (int i = 0; i < loopCount.Value; i++)
                        {
                            server.SendTo(data, data.Length, SocketFlags.None, RemoteEndPoint);
                        }
                    }
                    else
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

        private async void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            txtStatus.Invoke((MethodInvoker)delegate ()
            {
                txtHex.Text += string.Format("{0} : {1}{2}", DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"), BitConverter.ToString(e.Message).Replace("-", ""), Environment.NewLine);
                txtHex.SelectionStart = txtHex.TextLength;
                txtHex.ScrollToCaret();// = txtHex.Text.Length;
            });
            txtStatus.Invoke((MethodInvoker)delegate ()
            {
                txtStatus.Text += string.Format("{0} : {1}{2}", DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"), Encoding.ASCII.GetString(e.Message), Environment.NewLine);
                txtStatus.SelectionStart = txtStatus.TextLength;
                txtStatus.ScrollToCaret();// = txtStatus.Text.Length;
            });
            scrollToLast();
        }
        async Task  scrollToLast()
        {
            txtHex.ScrollToCaret();
            txtStatus.ScrollToCaret();
            txtHex.Refresh();
            txtStatus.Refresh();
            this.Refresh();
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void chkLoop_CheckedChanged(object sender, EventArgs e)
        {
            loopCount.Enabled = chkLoop.Checked;
        }
    }


}

