namespace BankSystem.Clients.Controls
{
    partial class ctrlClientList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgClientList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTotalBalance = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbTotalBalance);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtgClientList);
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(926, 370);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client List";
            // 
            // dtgClientList
            // 
            this.dtgClientList.AllowUserToAddRows = false;
            this.dtgClientList.AllowUserToDeleteRows = false;
            this.dtgClientList.AllowUserToOrderColumns = true;
            this.dtgClientList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgClientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgClientList.Location = new System.Drawing.Point(6, 27);
            this.dtgClientList.Name = "dtgClientList";
            this.dtgClientList.ReadOnly = true;
            this.dtgClientList.Size = new System.Drawing.Size(914, 288);
            this.dtgClientList.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "TotalBalance : ";
            // 
            // lbTotalBalance
            // 
            this.lbTotalBalance.AutoSize = true;
            this.lbTotalBalance.Location = new System.Drawing.Point(174, 336);
            this.lbTotalBalance.Name = "lbTotalBalance";
            this.lbTotalBalance.Size = new System.Drawing.Size(19, 21);
            this.lbTotalBalance.TabIndex = 3;
            this.lbTotalBalance.Text = "0";
            // 
            // ctrlClientList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "ctrlClientList";
            this.Size = new System.Drawing.Size(960, 396);
            this.Load += new System.EventHandler(this.ctrlClientList_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgClientList;
        private System.Windows.Forms.Label lbTotalBalance;
        private System.Windows.Forms.Label label1;
    }
}
