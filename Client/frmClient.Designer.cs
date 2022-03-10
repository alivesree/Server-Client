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
            this.htmlLabel3 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.chkLoop = new MetroFramework.Controls.MetroCheckBox();
            this.loopCount = new System.Windows.Forms.NumericUpDown();
            this.txtNumDelay = new System.Windows.Forms.NumericUpDown();
            this.txtDelay = new MetroFramework.Controls.MetroCheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loopCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(20, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(188, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(45, 96);
            this.txtHost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(132, 22);
            this.txtHost.TabIndex = 2;
            this.txtHost.Text = "192.168.1.192";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(224, 96);
            this.txtPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(63, 22);
            this.txtPort.TabIndex = 3;
            this.txtPort.Text = "8000";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(16, 410);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStatus.Size = new System.Drawing.Size(809, 126);
            this.txtStatus.TabIndex = 4;
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.Lime;
            this.btnConnect.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnConnect.Location = new System.Drawing.Point(316, 96);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(128, 28);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseCustomBackColor = true;
            this.btnConnect.UseSelectable = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(16, 235);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessage.Size = new System.Drawing.Size(809, 127);
            this.txtMessage.TabIndex = 7;
            // 
            // brnSend
            // 
            this.brnSend.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.brnSend.Location = new System.Drawing.Point(725, 368);
            this.brnSend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.brnSend.Name = "brnSend";
            this.brnSend.Size = new System.Drawing.Size(100, 28);
            this.brnSend.TabIndex = 8;
            this.brnSend.Text = "Send";
            this.brnSend.UseCustomBackColor = true;
            this.brnSend.UseSelectable = true;
            this.brnSend.Click += new System.EventHandler(this.brnSend_Click);
            // 
            // txtHex
            // 
            this.txtHex.Location = new System.Drawing.Point(16, 561);
            this.txtHex.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHex.Multiline = true;
            this.txtHex.Name = "txtHex";
            this.txtHex.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHex.Size = new System.Drawing.Size(809, 133);
            this.txtHex.TabIndex = 9;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.BackColor = System.Drawing.Color.Red;
            this.btnDisconnect.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnDisconnect.Highlight = true;
            this.btnDisconnect.Location = new System.Drawing.Point(452, 96);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(128, 28);
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
            this.rdbTCP.Location = new System.Drawing.Point(63, 30);
            this.rdbTCP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbTCP.Name = "rdbTCP";
            this.rdbTCP.Size = new System.Drawing.Size(56, 21);
            this.rdbTCP.TabIndex = 11;
            this.rdbTCP.TabStop = true;
            this.rdbTCP.Text = "TCP";
            this.rdbTCP.UseVisualStyleBackColor = true;
            // 
            // rdbUDP
            // 
            this.rdbUDP.AutoSize = true;
            this.rdbUDP.Location = new System.Drawing.Point(223, 30);
            this.rdbUDP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbUDP.Name = "rdbUDP";
            this.rdbUDP.Size = new System.Drawing.Size(58, 21);
            this.rdbUDP.TabIndex = 12;
            this.rdbUDP.Text = "UDP";
            this.rdbUDP.UseVisualStyleBackColor = true;
            this.rdbUDP.CheckedChanged += new System.EventHandler(this.rdbUDP_CheckedChanged);
            // 
            // rdbMQTT
            // 
            this.rdbMQTT.AutoSize = true;
            this.rdbMQTT.Location = new System.Drawing.Point(396, 30);
            this.rdbMQTT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbMQTT.Name = "rdbMQTT";
            this.rdbMQTT.Size = new System.Drawing.Size(69, 21);
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
            this.groupBox1.Location = new System.Drawing.Point(16, 145);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(811, 71);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Protocol";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(517, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Topic";
            // 
            // txtTopic
            // 
            this.txtTopic.Enabled = false;
            this.txtTopic.Location = new System.Drawing.Point(572, 27);
            this.txtTopic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTopic.Name = "txtTopic";
            this.txtTopic.Size = new System.Drawing.Size(205, 22);
            this.txtTopic.TabIndex = 14;
            // 
            // htmlLabel1
            // 
            this.htmlLabel1.AutoScroll = true;
            this.htmlLabel1.AutoScrollMinSize = new System.Drawing.Size(91, 25);
            this.htmlLabel1.AutoSize = false;
            this.htmlLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel1.Location = new System.Drawing.Point(11, 388);
            this.htmlLabel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.htmlLabel1.Name = "htmlLabel1";
            this.htmlLabel1.Size = new System.Drawing.Size(124, 28);
            this.htmlLabel1.TabIndex = 15;
            this.htmlLabel1.Text = "Recieved text";
            // 
            // htmlLabel2
            // 
            this.htmlLabel2.AutoScroll = true;
            this.htmlLabel2.AutoScrollMinSize = new System.Drawing.Size(145, 25);
            this.htmlLabel2.AutoSize = false;
            this.htmlLabel2.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel2.Location = new System.Drawing.Point(11, 540);
            this.htmlLabel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.htmlLabel2.Name = "htmlLabel2";
            this.htmlLabel2.Size = new System.Drawing.Size(187, 28);
            this.htmlLabel2.TabIndex = 16;
            this.htmlLabel2.Text = "Recieved Hexadecimal";
            // 
            // htmlLabel3
            // 
            this.htmlLabel3.AutoScroll = true;
            this.htmlLabel3.AutoScrollMinSize = new System.Drawing.Size(99, 25);
            this.htmlLabel3.AutoSize = false;
            this.htmlLabel3.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel3.Location = new System.Drawing.Point(11, 215);
            this.htmlLabel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.htmlLabel3.Name = "htmlLabel3";
            this.htmlLabel3.Size = new System.Drawing.Size(124, 28);
            this.htmlLabel3.TabIndex = 16;
            this.htmlLabel3.Text = "Send Message";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnClose.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(759, 10);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 28);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Close";
            this.btnClose.UseCustomBackColor = true;
            this.btnClose.UseCustomForeColor = true;
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // chkLoop
            // 
            this.chkLoop.AutoSize = true;
            this.chkLoop.Location = new System.Drawing.Point(566, 370);
            this.chkLoop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkLoop.Name = "chkLoop";
            this.chkLoop.Size = new System.Drawing.Size(54, 17);
            this.chkLoop.TabIndex = 18;
            this.chkLoop.Text = "Loop";
            this.chkLoop.UseSelectable = true;
            this.chkLoop.CheckedChanged += new System.EventHandler(this.chkLoop_CheckedChanged);
            // 
            // loopCount
            // 
            this.loopCount.Enabled = false;
            this.loopCount.Location = new System.Drawing.Point(628, 369);
            this.loopCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loopCount.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.loopCount.Name = "loopCount";
            this.loopCount.Size = new System.Drawing.Size(85, 22);
            this.loopCount.TabIndex = 19;
            this.loopCount.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // txtNumDelay
            // 
            this.txtNumDelay.Location = new System.Drawing.Point(420, 370);
            this.txtNumDelay.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumDelay.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.txtNumDelay.Minimum = new decimal(new int[] {
            450,
            0,
            0,
            0});
            this.txtNumDelay.Name = "txtNumDelay";
            this.txtNumDelay.Size = new System.Drawing.Size(85, 22);
            this.txtNumDelay.TabIndex = 21;
            this.txtNumDelay.Value = new decimal(new int[] {
            750,
            0,
            0,
            0});
            // 
            // txtDelay
            // 
            this.txtDelay.AutoSize = true;
            this.txtDelay.Location = new System.Drawing.Point(359, 371);
            this.txtDelay.Margin = new System.Windows.Forms.Padding(4);
            this.txtDelay.Name = "txtDelay";
            this.txtDelay.Size = new System.Drawing.Size(56, 17);
            this.txtDelay.TabIndex = 20;
            this.txtDelay.Text = "Delay";
            this.txtDelay.UseSelectable = true;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(506, 372);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 24);
            this.label4.TabIndex = 22;
            this.label4.Text = "ms";
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 703);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNumDelay);
            this.Controls.Add(this.txtDelay);
            this.Controls.Add(this.loopCount);
            this.Controls.Add(this.chkLoop);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.htmlLabel3);
            this.Controls.Add(this.txtHex);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.htmlLabel1);
            this.Controls.Add(this.htmlLabel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.brnSend);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMessage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmClient";
            this.Opacity = 0.95D;
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Resizable = false;
            this.Text = "Message Sender";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loopCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumDelay)).EndInit();
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
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel3;
        private MetroFramework.Controls.MetroButton btnClose;
        private MetroFramework.Controls.MetroCheckBox chkLoop;
        private System.Windows.Forms.NumericUpDown loopCount;
        private System.Windows.Forms.NumericUpDown txtNumDelay;
        private MetroFramework.Controls.MetroCheckBox txtDelay;
        private System.Windows.Forms.Label label4;
    }
}

