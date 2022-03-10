namespace Server
{
    partial class frmServer
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.brnSend = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtClintPort = new System.Windows.Forms.TextBox();
            this.txtClientIP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rdbTCP = new System.Windows.Forms.RadioButton();
            this.rdbMqtt = new System.Windows.Forms.RadioButton();
            this.txtTopic = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(641, 31);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 11;
            this.btnConnect.Text = "Start";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(208, 28);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 20);
            this.txtPort.TabIndex = 10;
            this.txtPort.Text = "8000";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(75, 28);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(100, 20);
            this.txtHost.TabIndex = 9;
            this.txtHost.Text = "192.168.1.148";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(180, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(34, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Server";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(722, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Stop";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(46, 70);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtStatus.Size = new System.Drawing.Size(781, 250);
            this.txtStatus.TabIndex = 13;
            // 
            // brnSend
            // 
            this.brnSend.Location = new System.Drawing.Point(46, 409);
            this.brnSend.Name = "brnSend";
            this.brnSend.Size = new System.Drawing.Size(75, 23);
            this.brnSend.TabIndex = 15;
            this.brnSend.Text = "Send";
            this.brnSend.UseVisualStyleBackColor = true;
            this.brnSend.Click += new System.EventHandler(this.brnSend_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(46, 360);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(781, 43);
            this.txtMessage.TabIndex = 14;
            // 
            // txtClintPort
            // 
            this.txtClintPort.Location = new System.Drawing.Point(320, 334);
            this.txtClintPort.Name = "txtClintPort";
            this.txtClintPort.Size = new System.Drawing.Size(100, 20);
            this.txtClintPort.TabIndex = 19;
            // 
            // txtClientIP
            // 
            this.txtClientIP.Location = new System.Drawing.Point(103, 334);
            this.txtClientIP.Name = "txtClientIP";
            this.txtClientIP.Size = new System.Drawing.Size(100, 20);
            this.txtClientIP.TabIndex = 18;
            this.txtClientIP.Text = "127.0.0.1";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(43, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 14);
            this.label4.TabIndex = 16;
            this.label4.Text = "Client IP";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(255, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 14);
            this.label5.TabIndex = 20;
            this.label5.Text = "Client Port";
            // 
            // rdbTCP
            // 
            this.rdbTCP.AutoSize = true;
            this.rdbTCP.Location = new System.Drawing.Point(477, 29);
            this.rdbTCP.Name = "rdbTCP";
            this.rdbTCP.Size = new System.Drawing.Size(46, 17);
            this.rdbTCP.TabIndex = 21;
            this.rdbTCP.TabStop = true;
            this.rdbTCP.Text = "TCP";
            this.rdbTCP.UseVisualStyleBackColor = true;
            // 
            // rdbMqtt
            // 
            this.rdbMqtt.AutoSize = true;
            this.rdbMqtt.Location = new System.Drawing.Point(525, 29);
            this.rdbMqtt.Name = "rdbMqtt";
            this.rdbMqtt.Size = new System.Drawing.Size(56, 17);
            this.rdbMqtt.TabIndex = 22;
            this.rdbMqtt.TabStop = true;
            this.rdbMqtt.Text = "MQTT";
            this.rdbMqtt.UseVisualStyleBackColor = true;
            // 
            // txtTopic
            // 
            this.txtTopic.Location = new System.Drawing.Point(351, 29);
            this.txtTopic.Name = "txtTopic";
            this.txtTopic.Size = new System.Drawing.Size(100, 20);
            this.txtTopic.TabIndex = 24;
            this.txtTopic.Text = "Gama";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(315, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Topic";
            // 
            // frmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 459);
            this.Controls.Add(this.txtTopic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rdbMqtt);
            this.Controls.Add(this.rdbTCP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtClintPort);
            this.Controls.Add(this.txtClientIP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.brnSend);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmServer";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button brnSend;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtClintPort;
        private System.Windows.Forms.TextBox txtClientIP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdbTCP;
        private System.Windows.Forms.RadioButton rdbMqtt;
        private System.Windows.Forms.TextBox txtTopic;
        private System.Windows.Forms.Label label3;
    }
}

