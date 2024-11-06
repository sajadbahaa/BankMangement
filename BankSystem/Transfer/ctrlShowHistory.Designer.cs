namespace BankSystem.Transfer
{
    partial class ctrlShowHistory
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
            this.gbHisorty = new System.Windows.Forms.GroupBox();
            this.lbRecord = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgview = new System.Windows.Forms.DataGridView();
            this.gbHisorty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgview)).BeginInit();
            this.SuspendLayout();
            // 
            // gbHisorty
            // 
            this.gbHisorty.Controls.Add(this.lbRecord);
            this.gbHisorty.Controls.Add(this.label1);
            this.gbHisorty.Controls.Add(this.dtgview);
            this.gbHisorty.Location = new System.Drawing.Point(7, 7);
            this.gbHisorty.Name = "gbHisorty";
            this.gbHisorty.Size = new System.Drawing.Size(741, 242);
            this.gbHisorty.TabIndex = 0;
            this.gbHisorty.TabStop = false;
            this.gbHisorty.Text = "History";
            // 
            // lbRecord
            // 
            this.lbRecord.AutoSize = true;
            this.lbRecord.Location = new System.Drawing.Point(114, 217);
            this.lbRecord.Name = "lbRecord";
            this.lbRecord.Size = new System.Drawing.Size(19, 21);
            this.lbRecord.TabIndex = 2;
            this.lbRecord.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Record : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtgview
            // 
            this.dtgview.AllowUserToAddRows = false;
            this.dtgview.AllowUserToDeleteRows = false;
            this.dtgview.AllowUserToOrderColumns = true;
            this.dtgview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgview.Location = new System.Drawing.Point(6, 27);
            this.dtgview.Name = "dtgview";
            this.dtgview.ReadOnly = true;
            this.dtgview.Size = new System.Drawing.Size(729, 179);
            this.dtgview.TabIndex = 0;
            this.dtgview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgview_CellContentClick);
            // 
            // ctrlShowHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbHisorty);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ctrlShowHistory";
            this.Size = new System.Drawing.Size(763, 256);
            this.Load += new System.EventHandler(this.ctrlShowHistory_Load);
            this.gbHisorty.ResumeLayout(false);
            this.gbHisorty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbHisorty;
        private System.Windows.Forms.DataGridView dtgview;
        private System.Windows.Forms.Label lbRecord;
        private System.Windows.Forms.Label label1;
    }
}
