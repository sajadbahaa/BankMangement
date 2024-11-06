namespace BankSystem.TransActions.Deposit
{
    partial class frmTransactionScreen
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
            this.lbTitlt = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.rbDepoist = new System.Windows.Forms.RadioButton();
            this.gbTrainsAction = new System.Windows.Forms.GroupBox();
            this.rbWithDraw = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctrlClientInfoWithFilter1 = new BankSystem.Clients.Controls.ctrlClientInfoWithFilter();
            this.llshowClient = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.gbTrainsAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitlt
            // 
            this.lbTitlt.AutoSize = true;
            this.lbTitlt.Location = new System.Drawing.Point(127, 13);
            this.lbTitlt.Name = "lbTitlt";
            this.lbTitlt.Size = new System.Drawing.Size(64, 20);
            this.lbTitlt.TabIndex = 1;
            this.lbTitlt.Text = "Depoist";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel1.Controls.Add(this.lbTitlt);
            this.panel1.ForeColor = System.Drawing.Color.FloralWhite;
            this.panel1.Location = new System.Drawing.Point(243, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 48);
            this.panel1.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(622, 592);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 38);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.Save);
            // 
            // rbDepoist
            // 
            this.rbDepoist.AutoSize = true;
            this.rbDepoist.Checked = true;
            this.rbDepoist.Location = new System.Drawing.Point(6, 25);
            this.rbDepoist.Name = "rbDepoist";
            this.rbDepoist.Size = new System.Drawing.Size(82, 24);
            this.rbDepoist.TabIndex = 1;
            this.rbDepoist.TabStop = true;
            this.rbDepoist.Text = "Depoist";
            this.rbDepoist.UseVisualStyleBackColor = true;
            this.rbDepoist.CheckedChanged += new System.EventHandler(this.rbDepoist_CheckedChanged);
            // 
            // gbTrainsAction
            // 
            this.gbTrainsAction.Controls.Add(this.rbWithDraw);
            this.gbTrainsAction.Controls.Add(this.rbDepoist);
            this.gbTrainsAction.Location = new System.Drawing.Point(616, 14);
            this.gbTrainsAction.Name = "gbTrainsAction";
            this.gbTrainsAction.Size = new System.Drawing.Size(140, 93);
            this.gbTrainsAction.TabIndex = 7;
            this.gbTrainsAction.TabStop = false;
            this.gbTrainsAction.Text = "Trains Action";
            // 
            // rbWithDraw
            // 
            this.rbWithDraw.AutoSize = true;
            this.rbWithDraw.Location = new System.Drawing.Point(6, 55);
            this.rbWithDraw.Name = "rbWithDraw";
            this.rbWithDraw.Size = new System.Drawing.Size(100, 24);
            this.rbWithDraw.TabIndex = 2;
            this.rbWithDraw.Text = "With Draw";
            this.rbWithDraw.UseVisualStyleBackColor = true;
            this.rbWithDraw.CheckedChanged += new System.EventHandler(this.rbWithDraw_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(499, 593);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 38);
            this.button2.TabIndex = 4;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Close);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 601);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Money : ";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(119, 598);
            this.txtAmount.Multiline = true;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(193, 34);
            this.txtAmount.TabIndex = 10;
            this.txtAmount.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlClientInfoWithFilter1
            // 
            this.ctrlClientInfoWithFilter1.FilterEnabled = true;
            this.ctrlClientInfoWithFilter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlClientInfoWithFilter1.Location = new System.Drawing.Point(7, 115);
            this.ctrlClientInfoWithFilter1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlClientInfoWithFilter1.Name = "ctrlClientInfoWithFilter1";
            this.ctrlClientInfoWithFilter1.Size = new System.Drawing.Size(764, 470);
            this.ctrlClientInfoWithFilter1.TabIndex = 8;
            this.ctrlClientInfoWithFilter1.OnClientInfoSelect += new System.EventHandler<BankSystem.Clients.Controls.ctrlClientInfoWithFilter.GetClientInfo>(this.ctrlClientInfoWithFilter1_OnClientInfoSelect);
            // 
            // llshowClient
            // 
            this.llshowClient.AutoSize = true;
            this.llshowClient.Location = new System.Drawing.Point(29, 9);
            this.llshowClient.Name = "llshowClient";
            this.llshowClient.Size = new System.Drawing.Size(125, 20);
            this.llshowClient.TabIndex = 11;
            this.llshowClient.TabStop = true;
            this.llshowClient.Text = "Show Client Info";
            this.llshowClient.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llshowClient_LinkClicked);
            // 
            // frmTransactionScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 671);
            this.Controls.Add(this.llshowClient);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ctrlClientInfoWithFilter1);
            this.Controls.Add(this.gbTrainsAction);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmTransactionScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDepoistScreen";
            this.Load += new System.EventHandler(this.frmDepoistScreen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbTrainsAction.ResumeLayout(false);
            this.gbTrainsAction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbTitlt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RadioButton rbDepoist;
        private System.Windows.Forms.GroupBox gbTrainsAction;
        private System.Windows.Forms.RadioButton rbWithDraw;
        private System.Windows.Forms.Button button2;
        private Clients.Controls.ctrlClientInfoWithFilter ctrlClientInfoWithFilter1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.LinkLabel llshowClient;
    }
}