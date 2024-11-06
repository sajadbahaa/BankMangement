namespace BankSystem.Clients
{
    partial class frmDeletClient
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
            this.ctrlClientInfoWithFilter1 = new BankSystem.Clients.Controls.ctrlClientInfoWithFilter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbMode = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlClientInfoWithFilter1
            // 
            this.ctrlClientInfoWithFilter1.FilterEnabled = true;
            this.ctrlClientInfoWithFilter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlClientInfoWithFilter1.Location = new System.Drawing.Point(11, 51);
            this.ctrlClientInfoWithFilter1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlClientInfoWithFilter1.Name = "ctrlClientInfoWithFilter1";
            this.ctrlClientInfoWithFilter1.Size = new System.Drawing.Size(746, 459);
            this.ctrlClientInfoWithFilter1.TabIndex = 10;
            this.ctrlClientInfoWithFilter1.OnClientInfoSelect += new System.EventHandler<BankSystem.Clients.Controls.ctrlClientInfoWithFilter.GetClientInfo>(this.ctrlClientInfoWithFilter1_OnClientInfoSelect);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.lbMode);
            this.panel1.ForeColor = System.Drawing.Color.Crimson;
            this.panel1.Location = new System.Drawing.Point(217, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 41);
            this.panel1.TabIndex = 11;
            // 
            // lbMode
            // 
            this.lbMode.AutoSize = true;
            this.lbMode.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMode.Location = new System.Drawing.Point(78, 7);
            this.lbMode.Name = "lbMode";
            this.lbMode.Size = new System.Drawing.Size(136, 26);
            this.lbMode.TabIndex = 1;
            this.lbMode.Text = "Delete Client";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(490, 514);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 39);
            this.button2.TabIndex = 14;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Close);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(626, 512);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(118, 39);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.DeletClient);
            // 
            // frmDeletClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 560);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.ctrlClientInfoWithFilter1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmDeletClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDeletClient";
            this.Load += new System.EventHandler(this.frmDeletClient_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ctrlClientInfoWithFilter ctrlClientInfoWithFilter1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbMode;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDelete;
    }
}