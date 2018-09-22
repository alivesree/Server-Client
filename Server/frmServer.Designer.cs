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
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(358, 32);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 11;
            this.btnConnect.Text = "Start";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(246, 32);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 20);
            this.txtPort.TabIndex = 10;
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(85, 28);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(100, 20);
            this.txtHost.TabIndex = 9;
            this.txtHost.Text = "127.0.0.1";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(205, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(43, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "host";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(439, 35);
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
            this.txtStatus.Size = new System.Drawing.Size(448, 122);
            this.txtStatus.TabIndex = 13;
            // 
            // brnSend
            // 
            this.brnSend.Location = new System.Drawing.Point(72, 295);
            this.brnSend.Name = "brnSend";
            this.brnSend.Size = new System.Drawing.Size(75, 23);
            this.brnSend.TabIndex = 15;
            this.brnSend.Text = "Send";
            this.brnSend.UseVisualStyleBackColor = true;
            this.brnSend.Click += new System.EventHandler(this.brnSend_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(61, 234);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(357, 43);
            this.txtMessage.TabIndex = 14;
            // 
            // txtClintPort
            // 
            this.txtClintPort.Location = new System.Drawing.Point(318, 209);
            this.txtClintPort.Name = "txtClintPort";
            this.txtClintPort.Size = new System.Drawing.Size(100, 20);
            this.txtClintPort.TabIndex = 19;
            // 
            // txtClientIP
            // 
            this.txtClientIP.Location = new System.Drawing.Point(99, 208);
            this.txtClientIP.Name = "txtClientIP";
            this.txtClientIP.Size = new System.Drawing.Size(100, 20);
            this.txtClientIP.TabIndex = 18;
            this.txtClientIP.Text = "127.0.0.1";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 14);
            this.label4.TabIndex = 16;
            this.label4.Text = "Client IP";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(246, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 14);
            this.label5.TabIndex = 20;
            this.label5.Text = "Client Port";
            // 
            // frmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 326);
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
    }
}

