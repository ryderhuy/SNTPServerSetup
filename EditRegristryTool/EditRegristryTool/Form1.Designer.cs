namespace EditRegristryTool
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnCreateInbound = new System.Windows.Forms.Button();
            this.btnDisableFirewall = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblFirewallStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblFirewallStatus);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btnDisableFirewall);
            this.groupBox1.Controls.Add(this.btnCreateInbound);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(59, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1133, 419);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setup SNTP";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(867, 276);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(187, 79);
            this.button3.TabIndex = 10;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // btnCreateInbound
            // 
            this.btnCreateInbound.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateInbound.Location = new System.Drawing.Point(867, 81);
            this.btnCreateInbound.Name = "btnCreateInbound";
            this.btnCreateInbound.Size = new System.Drawing.Size(197, 129);
            this.btnCreateInbound.TabIndex = 9;
            this.btnCreateInbound.Text = "Create Inbound/Outbound";
            this.btnCreateInbound.UseVisualStyleBackColor = true;
            this.btnCreateInbound.Click += new System.EventHandler(this.btnCreateInbound_Click);
            // 
            // btnDisableFirewall
            // 
            this.btnDisableFirewall.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisableFirewall.Location = new System.Drawing.Point(595, 81);
            this.btnDisableFirewall.Name = "btnDisableFirewall";
            this.btnDisableFirewall.Size = new System.Drawing.Size(197, 129);
            this.btnDisableFirewall.TabIndex = 8;
            this.btnDisableFirewall.Text = "Disable Firewall";
            this.btnDisableFirewall.UseVisualStyleBackColor = true;
            this.btnDisableFirewall.Click += new System.EventHandler(this.btnDisableFirewall_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(316, 81);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(197, 129);
            this.button2.TabIndex = 7;
            this.button2.Text = "Restart W32Time";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(49, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 129);
            this.button1.TabIndex = 6;
            this.button1.Text = "Config Registry";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::EditRegristryTool.Properties.Resources._0bb784460c9df6c3af8c;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(41, 344);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 44);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // lblFirewallStatus
            // 
            this.lblFirewallStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFirewallStatus.AutoSize = true;
            this.lblFirewallStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirewallStatus.Location = new System.Drawing.Point(662, 331);
            this.lblFirewallStatus.Name = "lblFirewallStatus";
            this.lblFirewallStatus.Size = new System.Drawing.Size(130, 24);
            this.lblFirewallStatus.TabIndex = 15;
            this.lblFirewallStatus.Text = "Firewall Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 481);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Copyright © 2020  Daekhon Vina - All Rights Reserved";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1253, 527);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "SNTP server setup";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnCreateInbound;
        private System.Windows.Forms.Button btnDisableFirewall;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblFirewallStatus;
        private System.Windows.Forms.Label label1;

    }
}

