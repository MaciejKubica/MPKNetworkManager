namespace MPKNetworkManager
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbGateways = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbIpAddresses = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mtbGateway = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mtbIPAddress = new System.Windows.Forms.MaskedTextBox();
            this.mtbSubnet = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lbCommands = new System.Windows.Forms.ListBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lvPingResult = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPing = new System.Windows.Forms.Button();
            this.tbPingAddress = new System.Windows.Forms.TextBox();
            this.nudPort = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nudTimes = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(661, 254);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Network Manager";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbGateways);
            this.groupBox4.Location = new System.Drawing.Point(8, 133);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(349, 103);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Gateways:";
            // 
            // lbGateways
            // 
            this.lbGateways.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbGateways.FormattingEnabled = true;
            this.lbGateways.ItemHeight = 16;
            this.lbGateways.Location = new System.Drawing.Point(4, 19);
            this.lbGateways.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbGateways.Name = "lbGateways";
            this.lbGateways.Size = new System.Drawing.Size(341, 80);
            this.lbGateways.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbIpAddresses);
            this.groupBox3.Location = new System.Drawing.Point(8, 22);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(349, 103);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "IP addresses:";
            // 
            // lbIpAddresses
            // 
            this.lbIpAddresses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbIpAddresses.FormattingEnabled = true;
            this.lbIpAddresses.ItemHeight = 16;
            this.lbIpAddresses.Location = new System.Drawing.Point(4, 19);
            this.lbIpAddresses.Margin = new System.Windows.Forms.Padding(0);
            this.lbIpAddresses.Name = "lbIpAddresses";
            this.lbIpAddresses.Size = new System.Drawing.Size(341, 80);
            this.lbIpAddresses.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mtbGateway);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.mtbIPAddress);
            this.groupBox2.Controls.Add(this.mtbSubnet);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(365, 22);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(289, 214);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Set new ip address details";
            // 
            // mtbGateway
            // 
            this.mtbGateway.Location = new System.Drawing.Point(93, 102);
            this.mtbGateway.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtbGateway.Name = "mtbGateway";
            this.mtbGateway.Size = new System.Drawing.Size(153, 22);
            this.mtbGateway.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 145);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Submit Change";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gateway:";
            // 
            // mtbIPAddress
            // 
            this.mtbIPAddress.Location = new System.Drawing.Point(93, 33);
            this.mtbIPAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtbIPAddress.Name = "mtbIPAddress";
            this.mtbIPAddress.Size = new System.Drawing.Size(153, 22);
            this.mtbIPAddress.TabIndex = 2;
            // 
            // mtbSubnet
            // 
            this.mtbSubnet.Location = new System.Drawing.Point(93, 68);
            this.mtbSubnet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtbSubnet.Name = "mtbSubnet";
            this.mtbSubnet.Size = new System.Drawing.Size(153, 22);
            this.mtbSubnet.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Subnet:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Controls.Add(this.lbCommands);
            this.groupBox5.Location = new System.Drawing.Point(12, 272);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Size = new System.Drawing.Size(661, 165);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Input commands";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(361, 23);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 1;
            this.button2.Text = "Run cmd";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbCommands
            // 
            this.lbCommands.FormattingEnabled = true;
            this.lbCommands.ItemHeight = 16;
            this.lbCommands.Location = new System.Drawing.Point(8, 23);
            this.lbCommands.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbCommands.Name = "lbCommands";
            this.lbCommands.Size = new System.Drawing.Size(344, 116);
            this.lbCommands.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.nudTimes);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.nudPort);
            this.groupBox6.Controls.Add(this.tbPingAddress);
            this.groupBox6.Controls.Add(this.btnPing);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.lvPingResult);
            this.groupBox6.Location = new System.Drawing.Point(12, 445);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(661, 195);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Ping command";
            // 
            // lvPingResult
            // 
            this.lvPingResult.Location = new System.Drawing.Point(384, 21);
            this.lvPingResult.Name = "lvPingResult";
            this.lvPingResult.ShowGroups = false;
            this.lvPingResult.Size = new System.Drawing.Size(270, 168);
            this.lvPingResult.TabIndex = 0;
            this.lvPingResult.UseCompatibleStateImageBehavior = false;
            this.lvPingResult.View = System.Windows.Forms.View.List;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Address:";
            // 
            // btnPing
            // 
            this.btnPing.Location = new System.Drawing.Point(303, 21);
            this.btnPing.Name = "btnPing";
            this.btnPing.Size = new System.Drawing.Size(75, 52);
            this.btnPing.TabIndex = 2;
            this.btnPing.Text = "Start Ping";
            this.btnPing.UseVisualStyleBackColor = true;
            this.btnPing.Click += new System.EventHandler(this.btnPing_Click);
            // 
            // tbPingAddress
            // 
            this.tbPingAddress.Location = new System.Drawing.Point(75, 18);
            this.tbPingAddress.Name = "tbPingAddress";
            this.tbPingAddress.Size = new System.Drawing.Size(182, 22);
            this.tbPingAddress.TabIndex = 3;
            // 
            // nudPort
            // 
            this.nudPort.Location = new System.Drawing.Point(75, 48);
            this.nudPort.Name = "nudPort";
            this.nudPort.Size = new System.Drawing.Size(182, 22);
            this.nudPort.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Port:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Times:";
            // 
            // nudTimes
            // 
            this.nudTimes.Location = new System.Drawing.Point(75, 76);
            this.nudTimes.Name = "nudTimes";
            this.nudTimes.Size = new System.Drawing.Size(182, 22);
            this.nudTimes.TabIndex = 7;
            this.nudTimes.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 652);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "MPKNetwork";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox mtbIPAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtbGateway;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtbSubnet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lbGateways;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lbIpAddresses;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox lbCommands;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox tbPingAddress;
        private System.Windows.Forms.Button btnPing;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lvPingResult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudPort;
        private System.Windows.Forms.NumericUpDown nudTimes;
        private System.Windows.Forms.Label label6;
    }
}

