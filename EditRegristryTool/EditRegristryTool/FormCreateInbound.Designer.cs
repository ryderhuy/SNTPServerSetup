namespace EditRegristryTool
{
    partial class FormCreateInbound
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddFilter = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtTypeRules = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblRules = new System.Windows.Forms.Label();
            this.cmdRules = new System.Windows.Forms.ComboBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblFirewallStatus = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1373, 226);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 30);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1313, 166);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Rule";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblFirewallStatus);
            this.panel1.Controls.Add(this.txtTypeRules);
            this.panel1.Controls.Add(this.txtIP);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtPort);
            this.panel1.Controls.Add(this.btnAddFilter);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 27);
            this.panel1.Margin = new System.Windows.Forms.Padding(30);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(30);
            this.panel1.Size = new System.Drawing.Size(1307, 136);
            this.panel1.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(123, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(160, 31);
            this.txtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(671, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Target IP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(998, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Direction:";
            // 
            // btnAddFilter
            // 
            this.btnAddFilter.BackColor = System.Drawing.Color.White;
            this.btnAddFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFilter.Location = new System.Drawing.Point(987, 92);
            this.btnAddFilter.Name = "btnAddFilter";
            this.btnAddFilter.Size = new System.Drawing.Size(100, 33);
            this.btnAddFilter.TabIndex = 3;
            this.btnAddFilter.Text = "Add Filter";
            this.btnAddFilter.UseVisualStyleBackColor = false;
            this.btnAddFilter.Click += new System.EventHandler(this.btnAddFilter_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(348, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Port:";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(419, 29);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(160, 31);
            this.txtPort.TabIndex = 2;
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(785, 28);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(160, 31);
            this.txtIP.TabIndex = 13;
            // 
            // txtTypeRules
            // 
            this.txtTypeRules.Location = new System.Drawing.Point(1105, 29);
            this.txtTypeRules.Name = "txtTypeRules";
            this.txtTypeRules.Size = new System.Drawing.Size(160, 31);
            this.txtTypeRules.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnRemove);
            this.panel2.Controls.Add(this.cmdRules);
            this.panel2.Controls.Add(this.lblRules);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 27);
            this.panel2.Margin = new System.Windows.Forms.Padding(30);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(30);
            this.panel2.Size = new System.Drawing.Size(1307, 0);
            this.panel2.TabIndex = 0;
            // 
            // lblRules
            // 
            this.lblRules.AutoSize = true;
            this.lblRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRules.Location = new System.Drawing.Point(30, 45);
            this.lblRules.Name = "lblRules";
            this.lblRules.Size = new System.Drawing.Size(63, 24);
            this.lblRules.TabIndex = 10;
            this.lblRules.Text = "Rules:";
            // 
            // cmdRules
            // 
            this.cmdRules.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdRules.FormattingEnabled = true;
            this.cmdRules.Location = new System.Drawing.Point(123, 41);
            this.cmdRules.Name = "cmdRules";
            this.cmdRules.Size = new System.Drawing.Size(481, 33);
            this.cmdRules.TabIndex = 11;
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(667, 41);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(114, 0);
            this.btnRemove.TabIndex = 12;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(30, 256);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1313, 1);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rules Added";
            // 
            // lblFirewallStatus
            // 
            this.lblFirewallStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFirewallStatus.AutoSize = true;
            this.lblFirewallStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirewallStatus.Location = new System.Drawing.Point(1136, 96);
            this.lblFirewallStatus.Name = "lblFirewallStatus";
            this.lblFirewallStatus.Size = new System.Drawing.Size(130, 24);
            this.lblFirewallStatus.TabIndex = 14;
            this.lblFirewallStatus.Text = "Firewall Status";
            // 
            // FormCreateInbound
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 226);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormCreateInbound";
            this.Text = "CreateInbound";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddFilter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ComboBox cmdRules;
        private System.Windows.Forms.Label lblRules;
        private System.Windows.Forms.Label lblFirewallStatus;
        private System.Windows.Forms.TextBox txtTypeRules;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPort;
    }
}