namespace BankSystem.Transfer
{
    partial class frmTransferScreen
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabTransferFrom = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.ctrlAccount1 = new BankSystem.Clients.Controls.ctrlClientInfoWithFilter();
            this.tabTransferTo = new System.Windows.Forms.TabPage();
            this.btnNextToTransfer = new System.Windows.Forms.Button();
            this.btnBackToMainScreen = new System.Windows.Forms.Button();
            this.ctrlAccount2 = new BankSystem.Clients.Controls.ctrlClientInfoWithFilter();
            this.tabTransferProcess = new System.Windows.Forms.TabPage();
            this.btnBackToMiddelScreen = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbBAcc2AfterTransfer = new System.Windows.Forms.Label();
            this.lbBAcc1AfterTransfer = new System.Windows.Forms.Label();
            this.lbBAcc1Befor = new System.Windows.Forms.Label();
            this.lbAccNumber2 = new System.Windows.Forms.Label();
            this.lbAccNumber1 = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbTransferID = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.llShowHistory = new System.Windows.Forms.LinkLabel();
            this.llShowClientInfo1 = new System.Windows.Forms.LinkLabel();
            this.llShowClientInfo2 = new System.Windows.Forms.LinkLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabTransferFrom.SuspendLayout();
            this.tabTransferTo.SuspendLayout();
            this.tabTransferProcess.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabTransferFrom);
            this.tabControl1.Controls.Add(this.tabTransferTo);
            this.tabControl1.Controls.Add(this.tabTransferProcess);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(10, 59);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 560);
            this.tabControl1.TabIndex = 0;
            // 
            // tabTransferFrom
            // 
            this.tabTransferFrom.Controls.Add(this.btnNext);
            this.tabTransferFrom.Controls.Add(this.ctrlAccount1);
            this.tabTransferFrom.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabTransferFrom.Location = new System.Drawing.Point(4, 30);
            this.tabTransferFrom.Name = "tabTransferFrom";
            this.tabTransferFrom.Padding = new System.Windows.Forms.Padding(3);
            this.tabTransferFrom.Size = new System.Drawing.Size(767, 526);
            this.tabTransferFrom.TabIndex = 0;
            this.tabTransferFrom.Text = "Transfer From";
            this.tabTransferFrom.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(618, 472);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(124, 46);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.NextToAccount2);
            // 
            // ctrlAccount1
            // 
            this.ctrlAccount1.FilterEnabled = true;
            this.ctrlAccount1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlAccount1.Location = new System.Drawing.Point(8, 8);
            this.ctrlAccount1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlAccount1.Name = "ctrlAccount1";
            this.ctrlAccount1.Size = new System.Drawing.Size(742, 456);
            this.ctrlAccount1.TabIndex = 1;
            this.ctrlAccount1.OnClientInfoSelect += new System.EventHandler<BankSystem.Clients.Controls.ctrlClientInfoWithFilter.GetClientInfo>(this.ctrlAccount1_OnClientInfoSelect);
            // 
            // tabTransferTo
            // 
            this.tabTransferTo.Controls.Add(this.btnNextToTransfer);
            this.tabTransferTo.Controls.Add(this.btnBackToMainScreen);
            this.tabTransferTo.Controls.Add(this.ctrlAccount2);
            this.tabTransferTo.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabTransferTo.Location = new System.Drawing.Point(4, 30);
            this.tabTransferTo.Name = "tabTransferTo";
            this.tabTransferTo.Padding = new System.Windows.Forms.Padding(3);
            this.tabTransferTo.Size = new System.Drawing.Size(767, 526);
            this.tabTransferTo.TabIndex = 1;
            this.tabTransferTo.Text = "Transfer to";
            this.tabTransferTo.UseVisualStyleBackColor = true;
            // 
            // btnNextToTransfer
            // 
            this.btnNextToTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextToTransfer.Location = new System.Drawing.Point(595, 470);
            this.btnNextToTransfer.Name = "btnNextToTransfer";
            this.btnNextToTransfer.Size = new System.Drawing.Size(149, 47);
            this.btnNextToTransfer.TabIndex = 4;
            this.btnNextToTransfer.Text = "Next";
            this.btnNextToTransfer.UseVisualStyleBackColor = true;
            this.btnNextToTransfer.Click += new System.EventHandler(this.NextToTransferProcess);
            // 
            // btnBackToMainScreen
            // 
            this.btnBackToMainScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToMainScreen.Location = new System.Drawing.Point(431, 469);
            this.btnBackToMainScreen.Name = "btnBackToMainScreen";
            this.btnBackToMainScreen.Size = new System.Drawing.Size(149, 48);
            this.btnBackToMainScreen.TabIndex = 3;
            this.btnBackToMainScreen.Text = "Back to Main";
            this.btnBackToMainScreen.UseVisualStyleBackColor = true;
            this.btnBackToMainScreen.Click += new System.EventHandler(this.BackToMainScreen);
            // 
            // ctrlAccount2
            // 
            this.ctrlAccount2.FilterEnabled = true;
            this.ctrlAccount2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlAccount2.Location = new System.Drawing.Point(12, 12);
            this.ctrlAccount2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlAccount2.Name = "ctrlAccount2";
            this.ctrlAccount2.Size = new System.Drawing.Size(742, 454);
            this.ctrlAccount2.TabIndex = 2;
            this.ctrlAccount2.OnClientInfoSelect += new System.EventHandler<BankSystem.Clients.Controls.ctrlClientInfoWithFilter.GetClientInfo>(this.ctrlAccount2_OnClientInfoSelect);
            // 
            // tabTransferProcess
            // 
            this.tabTransferProcess.Controls.Add(this.btnBackToMiddelScreen);
            this.tabTransferProcess.Controls.Add(this.txtAmount);
            this.tabTransferProcess.Controls.Add(this.label18);
            this.tabTransferProcess.Controls.Add(this.lbUsername);
            this.tabTransferProcess.Controls.Add(this.lbBAcc2AfterTransfer);
            this.tabTransferProcess.Controls.Add(this.lbBAcc1AfterTransfer);
            this.tabTransferProcess.Controls.Add(this.lbBAcc1Befor);
            this.tabTransferProcess.Controls.Add(this.lbAccNumber2);
            this.tabTransferProcess.Controls.Add(this.lbAccNumber1);
            this.tabTransferProcess.Controls.Add(this.lbDate);
            this.tabTransferProcess.Controls.Add(this.lbTransferID);
            this.tabTransferProcess.Controls.Add(this.label9);
            this.tabTransferProcess.Controls.Add(this.label8);
            this.tabTransferProcess.Controls.Add(this.label7);
            this.tabTransferProcess.Controls.Add(this.label6);
            this.tabTransferProcess.Controls.Add(this.label5);
            this.tabTransferProcess.Controls.Add(this.label4);
            this.tabTransferProcess.Controls.Add(this.label3);
            this.tabTransferProcess.Controls.Add(this.label2);
            this.tabTransferProcess.Location = new System.Drawing.Point(4, 30);
            this.tabTransferProcess.Name = "tabTransferProcess";
            this.tabTransferProcess.Size = new System.Drawing.Size(767, 526);
            this.tabTransferProcess.TabIndex = 2;
            this.tabTransferProcess.Text = "AmountTransfer";
            this.tabTransferProcess.UseVisualStyleBackColor = true;
            this.tabTransferProcess.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnBackToMiddelScreen
            // 
            this.btnBackToMiddelScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToMiddelScreen.Location = new System.Drawing.Point(608, 468);
            this.btnBackToMiddelScreen.Name = "btnBackToMiddelScreen";
            this.btnBackToMiddelScreen.Size = new System.Drawing.Size(149, 48);
            this.btnBackToMiddelScreen.TabIndex = 20;
            this.btnBackToMiddelScreen.Text = "Back";
            this.btnBackToMiddelScreen.UseVisualStyleBackColor = true;
            this.btnBackToMiddelScreen.Click += new System.EventHandler(this.BackToMiddelScreen);
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(128, 438);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(202, 32);
            this.txtAmount.TabIndex = 19;
            this.txtAmount.Validating += new System.ComponentModel.CancelEventHandler(this.txtAmount_Validating);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(24, 441);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(91, 21);
            this.label18.TabIndex = 18;
            this.label18.Text = "Amount  : ";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(287, 366);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(52, 21);
            this.lbUsername.TabIndex = 17;
            this.lbUsername.Text = "[????]";
            // 
            // lbBAcc2AfterTransfer
            // 
            this.lbBAcc2AfterTransfer.AutoSize = true;
            this.lbBAcc2AfterTransfer.Location = new System.Drawing.Point(287, 316);
            this.lbBAcc2AfterTransfer.Name = "lbBAcc2AfterTransfer";
            this.lbBAcc2AfterTransfer.Size = new System.Drawing.Size(52, 21);
            this.lbBAcc2AfterTransfer.TabIndex = 16;
            this.lbBAcc2AfterTransfer.Text = "[????]";
            // 
            // lbBAcc1AfterTransfer
            // 
            this.lbBAcc1AfterTransfer.AutoSize = true;
            this.lbBAcc1AfterTransfer.Location = new System.Drawing.Point(287, 267);
            this.lbBAcc1AfterTransfer.Name = "lbBAcc1AfterTransfer";
            this.lbBAcc1AfterTransfer.Size = new System.Drawing.Size(52, 21);
            this.lbBAcc1AfterTransfer.TabIndex = 15;
            this.lbBAcc1AfterTransfer.Text = "[????]";
            // 
            // lbBAcc1Befor
            // 
            this.lbBAcc1Befor.AutoSize = true;
            this.lbBAcc1Befor.Location = new System.Drawing.Point(287, 217);
            this.lbBAcc1Befor.Name = "lbBAcc1Befor";
            this.lbBAcc1Befor.Size = new System.Drawing.Size(52, 21);
            this.lbBAcc1Befor.TabIndex = 14;
            this.lbBAcc1Befor.Text = "[????]";
            // 
            // lbAccNumber2
            // 
            this.lbAccNumber2.AutoSize = true;
            this.lbAccNumber2.Location = new System.Drawing.Point(284, 172);
            this.lbAccNumber2.Name = "lbAccNumber2";
            this.lbAccNumber2.Size = new System.Drawing.Size(52, 21);
            this.lbAccNumber2.TabIndex = 13;
            this.lbAccNumber2.Text = "[????]";
            // 
            // lbAccNumber1
            // 
            this.lbAccNumber1.AutoSize = true;
            this.lbAccNumber1.Location = new System.Drawing.Point(278, 118);
            this.lbAccNumber1.Name = "lbAccNumber1";
            this.lbAccNumber1.Size = new System.Drawing.Size(52, 21);
            this.lbAccNumber1.TabIndex = 12;
            this.lbAccNumber1.Text = "[????]";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(278, 72);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(52, 21);
            this.lbDate.TabIndex = 11;
            this.lbDate.Text = "[????]";
            // 
            // lbTransferID
            // 
            this.lbTransferID.AutoSize = true;
            this.lbTransferID.Location = new System.Drawing.Point(278, 22);
            this.lbTransferID.Name = "lbTransferID";
            this.lbTransferID.Size = new System.Drawing.Size(52, 21);
            this.lbTransferID.TabIndex = 10;
            this.lbTransferID.Text = "[????]";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 21);
            this.label9.TabIndex = 9;
            this.label9.Text = "Transfer ID   : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 362);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 21);
            this.label8.TabIndex = 8;
            this.label8.Text = "Username  : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(213, 21);
            this.label7.TabIndex = 7;
            this.label7.Text = " Balance Account2 After  : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = " Balance Account1 After : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = " Balance Account1 B.for  : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Transfer Acc.Number To  : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Transfer Acc.Number from : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Transfer Date : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Transfe Money";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(241, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 32);
            this.panel1.TabIndex = 2;
            // 
            // btnTransfer
            // 
            this.btnTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransfer.Location = new System.Drawing.Point(657, 629);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(124, 32);
            this.btnTransfer.TabIndex = 3;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.TransferMoney);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(527, 628);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 32);
            this.button2.TabIndex = 4;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Close);
            // 
            // llShowHistory
            // 
            this.llShowHistory.AutoSize = true;
            this.llShowHistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.llShowHistory.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llShowHistory.Location = new System.Drawing.Point(32, 16);
            this.llShowHistory.Name = "llShowHistory";
            this.llShowHistory.Size = new System.Drawing.Size(112, 23);
            this.llShowHistory.TabIndex = 5;
            this.llShowHistory.TabStop = true;
            this.llShowHistory.Text = "Show Histoty";
            this.llShowHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowHistory_LinkClicked);
            // 
            // llShowClientInfo1
            // 
            this.llShowClientInfo1.AutoSize = true;
            this.llShowClientInfo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.llShowClientInfo1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llShowClientInfo1.Location = new System.Drawing.Point(14, 634);
            this.llShowClientInfo1.Name = "llShowClientInfo1";
            this.llShowClientInfo1.Size = new System.Drawing.Size(153, 23);
            this.llShowClientInfo1.TabIndex = 6;
            this.llShowClientInfo1.TabStop = true;
            this.llShowClientInfo1.Text = "Show Client Info 1";
            this.llShowClientInfo1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowClientInfo1_LinkClicked);
            // 
            // llShowClientInfo2
            // 
            this.llShowClientInfo2.AutoSize = true;
            this.llShowClientInfo2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.llShowClientInfo2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llShowClientInfo2.Location = new System.Drawing.Point(195, 633);
            this.llShowClientInfo2.Name = "llShowClientInfo2";
            this.llShowClientInfo2.Size = new System.Drawing.Size(153, 23);
            this.llShowClientInfo2.TabIndex = 7;
            this.llShowClientInfo2.TabStop = true;
            this.llShowClientInfo2.Text = "Show Client Info 2";
            this.llShowClientInfo2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowClientInfo2_LinkClicked);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmTransferScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 671);
            this.Controls.Add(this.llShowClientInfo2);
            this.Controls.Add(this.llShowClientInfo1);
            this.Controls.Add(this.llShowHistory);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmTransferScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTransferScreen";
            this.Load += new System.EventHandler(this.frmTransferScreen_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabTransferFrom.ResumeLayout(false);
            this.tabTransferTo.ResumeLayout(false);
            this.tabTransferProcess.ResumeLayout(false);
            this.tabTransferProcess.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabTransferFrom;
        private Clients.Controls.ctrlClientInfoWithFilter ctrlAccount1;
        private System.Windows.Forms.TabPage tabTransferTo;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBackToMainScreen;
        private Clients.Controls.ctrlClientInfoWithFilter ctrlAccount2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.LinkLabel llShowHistory;
        private System.Windows.Forms.TabPage tabTransferProcess;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbBAcc2AfterTransfer;
        private System.Windows.Forms.Label lbBAcc1AfterTransfer;
        private System.Windows.Forms.Label lbBAcc1Befor;
        private System.Windows.Forms.Label lbAccNumber2;
        private System.Windows.Forms.Label lbAccNumber1;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbTransferID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnBackToMiddelScreen;
        private System.Windows.Forms.Button btnNextToTransfer;
        private System.Windows.Forms.LinkLabel llShowClientInfo1;
        private System.Windows.Forms.LinkLabel llShowClientInfo2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}