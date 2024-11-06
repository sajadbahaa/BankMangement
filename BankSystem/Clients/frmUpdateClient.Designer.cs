namespace BankSystem.Clients
{
    partial class frmUpdateClient
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbMode = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabClientInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.tabUpdatClient = new System.Windows.Forms.TabPage();
            this.chIsActive = new System.Windows.Forms.CheckBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbCreateDate = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPinCode = new System.Windows.Forms.TextBox();
            this.txtAccNumber = new System.Windows.Forms.TextBox();
            this.lbClientID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.llShowClient = new System.Windows.Forms.LinkLabel();
            this.ctrlClientInfoWithFilter1 = new BankSystem.Clients.Controls.ctrlClientInfoWithFilter();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabClientInfo.SuspendLayout();
            this.tabUpdatClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.lbMode);
            this.panel1.ForeColor = System.Drawing.Color.Crimson;
            this.panel1.Location = new System.Drawing.Point(260, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 41);
            this.panel1.TabIndex = 9;
            // 
            // lbMode
            // 
            this.lbMode.AutoSize = true;
            this.lbMode.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMode.Location = new System.Drawing.Point(78, 7);
            this.lbMode.Name = "lbMode";
            this.lbMode.Size = new System.Drawing.Size(145, 26);
            this.lbMode.TabIndex = 1;
            this.lbMode.Text = "Update Client";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabClientInfo);
            this.tabControl1.Controls.Add(this.tabUpdatClient);
            this.tabControl1.Location = new System.Drawing.Point(12, 59);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(797, 547);
            this.tabControl1.TabIndex = 10;
            // 
            // tabClientInfo
            // 
            this.tabClientInfo.Controls.Add(this.btnNext);
            this.tabClientInfo.Controls.Add(this.ctrlClientInfoWithFilter1);
            this.tabClientInfo.Location = new System.Drawing.Point(4, 29);
            this.tabClientInfo.Name = "tabClientInfo";
            this.tabClientInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabClientInfo.Size = new System.Drawing.Size(789, 514);
            this.tabClientInfo.TabIndex = 0;
            this.tabClientInfo.Text = "Client Info";
            this.tabClientInfo.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(623, 466);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(118, 39);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.NexrToUpdate);
            // 
            // tabUpdatClient
            // 
            this.tabUpdatClient.Controls.Add(this.chIsActive);
            this.tabUpdatClient.Controls.Add(this.lbUsername);
            this.tabUpdatClient.Controls.Add(this.label10);
            this.tabUpdatClient.Controls.Add(this.lbCreateDate);
            this.tabUpdatClient.Controls.Add(this.label8);
            this.tabUpdatClient.Controls.Add(this.lbName);
            this.tabUpdatClient.Controls.Add(this.label6);
            this.tabUpdatClient.Controls.Add(this.txtBalance);
            this.tabUpdatClient.Controls.Add(this.label4);
            this.tabUpdatClient.Controls.Add(this.txtPinCode);
            this.tabUpdatClient.Controls.Add(this.txtAccNumber);
            this.tabUpdatClient.Controls.Add(this.lbClientID);
            this.tabUpdatClient.Controls.Add(this.label3);
            this.tabUpdatClient.Controls.Add(this.label2);
            this.tabUpdatClient.Controls.Add(this.label1);
            this.tabUpdatClient.Location = new System.Drawing.Point(4, 29);
            this.tabUpdatClient.Name = "tabUpdatClient";
            this.tabUpdatClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabUpdatClient.Size = new System.Drawing.Size(789, 514);
            this.tabUpdatClient.TabIndex = 1;
            this.tabUpdatClient.Text = "Updat Client";
            this.tabUpdatClient.UseVisualStyleBackColor = true;
            // 
            // chIsActive
            // 
            this.chIsActive.AutoSize = true;
            this.chIsActive.Location = new System.Drawing.Point(140, 425);
            this.chIsActive.Name = "chIsActive";
            this.chIsActive.Size = new System.Drawing.Size(88, 24);
            this.chIsActive.TabIndex = 25;
            this.chIsActive.Text = "Is Active";
            this.chIsActive.UseVisualStyleBackColor = true;
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(239, 369);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(53, 20);
            this.lbUsername.TabIndex = 24;
            this.lbUsername.Text = "[????]";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(66, 368);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "User name  : ";
            // 
            // lbCreateDate
            // 
            this.lbCreateDate.AutoSize = true;
            this.lbCreateDate.Location = new System.Drawing.Point(237, 320);
            this.lbCreateDate.Name = "lbCreateDate";
            this.lbCreateDate.Size = new System.Drawing.Size(53, 20);
            this.lbCreateDate.TabIndex = 22;
            this.lbCreateDate.Text = "[????]";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 321);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Create Date  : ";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(200, 113);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(53, 20);
            this.lbName.TabIndex = 20;
            this.lbName.Text = "[????]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Full Name  : ";
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(194, 258);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(190, 26);
            this.txtBalance.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Balance : ";
            // 
            // txtPinCode
            // 
            this.txtPinCode.Location = new System.Drawing.Point(193, 209);
            this.txtPinCode.Name = "txtPinCode";
            this.txtPinCode.Size = new System.Drawing.Size(190, 26);
            this.txtPinCode.TabIndex = 16;
            // 
            // txtAccNumber
            // 
            this.txtAccNumber.Location = new System.Drawing.Point(194, 158);
            this.txtAccNumber.Name = "txtAccNumber";
            this.txtAccNumber.Size = new System.Drawing.Size(190, 26);
            this.txtAccNumber.TabIndex = 15;
            // 
            // lbClientID
            // 
            this.lbClientID.AutoSize = true;
            this.lbClientID.Location = new System.Drawing.Point(200, 63);
            this.lbClientID.Name = "lbClientID";
            this.lbClientID.Size = new System.Drawing.Size(53, 20);
            this.lbClientID.TabIndex = 14;
            this.lbClientID.Text = "[????]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "PinCode : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Acc.Number : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Client ID : ";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(687, 609);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(118, 39);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.UpdateInfo);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(558, 608);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 39);
            this.button2.TabIndex = 12;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // llShowClient
            // 
            this.llShowClient.AutoSize = true;
            this.llShowClient.Location = new System.Drawing.Point(32, 618);
            this.llShowClient.Name = "llShowClient";
            this.llShowClient.Size = new System.Drawing.Size(125, 20);
            this.llShowClient.TabIndex = 13;
            this.llShowClient.TabStop = true;
            this.llShowClient.Text = "Show Client Info";
            this.llShowClient.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // ctrlClientInfoWithFilter1
            // 
            this.ctrlClientInfoWithFilter1.FilterEnabled = true;
            this.ctrlClientInfoWithFilter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlClientInfoWithFilter1.Location = new System.Drawing.Point(10, 9);
            this.ctrlClientInfoWithFilter1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlClientInfoWithFilter1.Name = "ctrlClientInfoWithFilter1";
            this.ctrlClientInfoWithFilter1.Size = new System.Drawing.Size(764, 452);
            this.ctrlClientInfoWithFilter1.TabIndex = 1;
            this.ctrlClientInfoWithFilter1.OnClientInfoSelect += new System.EventHandler<BankSystem.Clients.Controls.ctrlClientInfoWithFilter.GetClientInfo>(this.ctrlClientInfoWithFilter1_OnClientInfoSelect);
            // 
            // frmUpdateClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 654);
            this.Controls.Add(this.llShowClient);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmUpdateClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUpdateClient";
            this.Load += new System.EventHandler(this.frmUpdateClient_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabClientInfo.ResumeLayout(false);
            this.tabUpdatClient.ResumeLayout(false);
            this.tabUpdatClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbMode;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabClientInfo;
        private System.Windows.Forms.TabPage tabUpdatClient;
        private Controls.ctrlClientInfoWithFilter ctrlClientInfoWithFilter1;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPinCode;
        private System.Windows.Forms.TextBox txtAccNumber;
        private System.Windows.Forms.Label lbClientID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chIsActive;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbCreateDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.LinkLabel llShowClient;
    }
}