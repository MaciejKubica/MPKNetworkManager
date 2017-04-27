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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mtbGateway = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mtbIPAddress = new System.Windows.Forms.MaskedTextBox();
            this.mtbSubnet = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbIpAddresses = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbGateways = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(496, 206);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Network Manager";
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
            this.groupBox2.Location = new System.Drawing.Point(274, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 174);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Set new ip address details";
            // 
            // mtbGateway
            // 
            this.mtbGateway.Location = new System.Drawing.Point(70, 83);
            this.mtbGateway.Margin = new System.Windows.Forms.Padding(2);
            this.mtbGateway.Name = "mtbGateway";
            this.mtbGateway.Size = new System.Drawing.Size(116, 20);
            this.mtbGateway.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 118);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Submit Change";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gateway:";
            // 
            // mtbIPAddress
            // 
            this.mtbIPAddress.Location = new System.Drawing.Point(70, 27);
            this.mtbIPAddress.Margin = new System.Windows.Forms.Padding(2);
            this.mtbIPAddress.Name = "mtbIPAddress";
            this.mtbIPAddress.Size = new System.Drawing.Size(116, 20);
            this.mtbIPAddress.TabIndex = 2;
            // 
            // mtbSubnet
            // 
            this.mtbSubnet.Location = new System.Drawing.Point(70, 55);
            this.mtbSubnet.Margin = new System.Windows.Forms.Padding(2);
            this.mtbSubnet.Name = "mtbSubnet";
            this.mtbSubnet.Size = new System.Drawing.Size(116, 20);
            this.mtbSubnet.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Subnet:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbIpAddresses);
            this.groupBox3.Location = new System.Drawing.Point(6, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(262, 84);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "IP addresses:";
            // 
            // lbIpAddresses
            // 
            this.lbIpAddresses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbIpAddresses.FormattingEnabled = true;
            this.lbIpAddresses.Location = new System.Drawing.Point(3, 16);
            this.lbIpAddresses.Margin = new System.Windows.Forms.Padding(0);
            this.lbIpAddresses.Name = "lbIpAddresses";
            this.lbIpAddresses.Size = new System.Drawing.Size(256, 65);
            this.lbIpAddresses.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbGateways);
            this.groupBox4.Location = new System.Drawing.Point(6, 108);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(262, 84);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Gateways:";
            // 
            // lbGateways
            // 
            this.lbGateways.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbGateways.FormattingEnabled = true;
            this.lbGateways.Location = new System.Drawing.Point(3, 16);
            this.lbGateways.Name = "lbGateways";
            this.lbGateways.Size = new System.Drawing.Size(256, 65);
            this.lbGateways.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 391);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "MPKNetwork";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
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
    }
}

