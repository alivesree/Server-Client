namespace client
{
    partial class frmClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClient));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.btnConnect = new MetroFramework.Controls.MetroButton();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.brnSend = new MetroFramework.Controls.MetroButton();
            this.txtHex = new System.Windows.Forms.TextBox();
            this.btnDisconnect = new MetroFramework.Controls.MetroButton();
            this.rdbTCP = new System.Windows.Forms.RadioButton();
            this.rdbUDP = new System.Windows.Forms.RadioButton();
            this.rdbMQTT = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTopic = new System.Windows.Forms.TextBox();
            this.htmlLabel1 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.htmlLabel2 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(14, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(176, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(34, 78);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(100, 20);
            this.txtHost.TabIndex = 2;
            this.txtHost.Text = "192.168.1.192";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(207, 78);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(48, 20);
            this.txtPort.TabIndex = 3;
            this.txtPort.Text = "8000";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(12, 333);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(608, 103);
            this.txtStatus.TabIndex = 4;
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.Lime;
            this.btnConnect.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnConnect.Location = new System.Drawing.Point(301, 77);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(96, 23);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseCustomBackColor = true;
            this.btnConnect.UseSelectable = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(12, 186);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(608, 104);
            this.txtMessage.TabIndex = 7;
            // 
            // brnSend
            // 
            this.brnSend.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.brnSend.Location = new System.Drawing.Point(544, 294);
            this.brnSend.Name = "brnSend";
            this.brnSend.Size = new System.Drawing.Size(75, 23);
            this.brnSend.TabIndex = 8;
            this.brnSend.Text = "Send";
            this.brnSend.UseCustomBackColor = true;
            this.brnSend.UseSelectable = true;
            this.brnSend.Click += new System.EventHandler(this.brnSend_Click);
            // 
            // txtHex
            // 
            this.txtHex.Location = new System.Drawing.Point(12, 456);
            this.txtHex.Multiline = true;
            this.txtHex.Name = "txtHex";
            this.txtHex.Size = new System.Drawing.Size(608, 109);
            this.txtHex.TabIndex = 9;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.BackColor = System.Drawing.Color.Red;
            this.btnDisconnect.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnDisconnect.Highlight = true;
            this.btnDisconnect.Location = new System.Drawing.Point(403, 77);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(95, 23);
            this.btnDisconnect.Style = MetroFramework.MetroColorStyle.Red;
            this.btnDisconnect.TabIndex = 10;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseCustomBackColor = true;
            this.btnDisconnect.UseSelectable = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // rdbTCP
            // 
            this.rdbTCP.AutoSize = true;
            this.rdbTCP.Checked = true;
            this.rdbTCP.Location = new System.Drawing.Point(47, 24);
            this.rdbTCP.Name = "rdbTCP";
            this.rdbTCP.Size = new System.Drawing.Size(46, 17);
            this.rdbTCP.TabIndex = 11;
            this.rdbTCP.TabStop = true;
            this.rdbTCP.Text = "TCP";
            this.rdbTCP.UseVisualStyleBackColor = true;
            // 
            // rdbUDP
            // 
            this.rdbUDP.AutoSize = true;
            this.rdbUDP.Location = new System.Drawing.Point(167, 24);
            this.rdbUDP.Name = "rdbUDP";
            this.rdbUDP.Size = new System.Drawing.Size(48, 17);
            this.rdbUDP.TabIndex = 12;
            this.rdbUDP.Text = "UDP";
            this.rdbUDP.UseVisualStyleBackColor = true;
            this.rdbUDP.CheckedChanged += new System.EventHandler(this.rdbUDP_CheckedChanged);
            // 
            // rdbMQTT
            // 
            this.rdbMQTT.AutoSize = true;
            this.rdbMQTT.Location = new System.Drawing.Point(297, 24);
            this.rdbMQTT.Name = "rdbMQTT";
            this.rdbMQTT.Size = new System.Drawing.Size(56, 17);
            this.rdbMQTT.TabIndex = 13;
            this.rdbMQTT.TabStop = true;
            this.rdbMQTT.Text = "MQTT";
            this.rdbMQTT.UseVisualStyleBackColor = true;
            this.rdbMQTT.CheckedChanged += new System.EventHandler(this.rdbMQTT_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTopic);
            this.groupBox1.Controls.Add(this.rdbTCP);
            this.groupBox1.Controls.Add(this.rdbMQTT);
            this.groupBox1.Controls.Add(this.rdbUDP);
            this.groupBox1.Location = new System.Drawing.Point(12, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(608, 58);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Protocol";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(388, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Topic";
            // 
            // txtTopic
            // 
            this.txtTopic.Enabled = false;
            this.txtTopic.Location = new System.Drawing.Point(429, 22);
            this.txtTopic.Name = "txtTopic";
            this.txtTopic.Size = new System.Drawing.Size(155, 20);
            this.txtTopic.TabIndex = 14;
            // 
            // htmlLabel1
            // 
            this.htmlLabel1.AutoScroll = true;
            this.htmlLabel1.AutoScrollMinSize = new System.Drawing.Size(78, 23);
            this.htmlLabel1.AutoSize = false;
            this.htmlLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel1.Location = new System.Drawing.Point(8, 321);
            this.htmlLabel1.Name = "htmlLabel1";
            this.htmlLabel1.Size = new System.Drawing.Size(93, 23);
            this.htmlLabel1.TabIndex = 15;
            this.htmlLabel1.Text = "Recieved text";
            // 
            // htmlLabel2
            // 
            this.htmlLabel2.AutoScroll = true;
            this.htmlLabel2.AutoScrollMinSize = new System.Drawing.Size(125, 23);
            this.htmlLabel2.AutoSize = false;
            this.htmlLabel2.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel2.Location = new System.Drawing.Point(10, 443);
            this.htmlLabel2.Name = "htmlLabel2";
            this.htmlLabel2.Size = new System.Drawing.Size(140, 23);
            this.htmlLabel2.TabIndex = 16;
            this.htmlLabel2.Text = "Recieved Hexadecimal";
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 571);
            this.Controls.Add(this.htmlLabel1);
            this.Controls.Add(this.htmlLabel2);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.txtHex);
            this.Controls.Add(this.brnSend);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmClient";
            this.Text = "Message Sender";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtHex;
        private System.Windows.Forms.RadioButton rdbTCP;
        private System.Windows.Forms.RadioButton rdbUDP;
        private System.Windows.Forms.RadioButton rdbMQTT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTopic;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel1;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel2;
        private MetroFramework.Controls.MetroButton btnConnect;
        private MetroFramework.Controls.MetroButton brnSend;
        private MetroFramework.Controls.MetroButton btnDisconnect;
    }
}

