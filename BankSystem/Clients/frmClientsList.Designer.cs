namespace BankSystem.Clients
{
    partial class frmClientsList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientsList));
            this.label2 = new System.Windows.Forms.Label();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.lbRecord = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgClient = new System.Windows.Forms.DataGridView();
            this.cmClientInfo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showPersonInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCleientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showClientInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showFindClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbIsActive = new System.Windows.Forms.ComboBox();
            this.allClientListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClient)).BeginInit();
            this.cmClientInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Filter By : ";
            // 
            // cbFilter
            // 
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "None",
            "PersonID",
            "ClientID",
            "AccountNumber",
            "IsActive"});
            this.cbFilter.Location = new System.Drawing.Point(114, 139);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(121, 28);
            this.cbFilter.TabIndex = 14;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(257, 138);
            this.txtFilter.Multiline = true;
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(169, 28);
            this.txtFilter.TabIndex = 13;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // lbRecord
            // 
            this.lbRecord.AutoSize = true;
            this.lbRecord.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecord.Location = new System.Drawing.Point(119, 430);
            this.lbRecord.Name = "lbRecord";
            this.lbRecord.Size = new System.Drawing.Size(34, 21);
            this.lbRecord.TabIndex = 11;
            this.lbRecord.Text = "???";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 430);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Record : ";
            // 
            // dtgClient
            // 
            this.dtgClient.AllowUserToAddRows = false;
            this.dtgClient.AllowUserToDeleteRows = false;
            this.dtgClient.AllowUserToOrderColumns = true;
            this.dtgClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgClient.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.dtgClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgClient.ContextMenuStrip = this.cmClientInfo;
            this.dtgClient.Location = new System.Drawing.Point(31, 188);
            this.dtgClient.Name = "dtgClient";
            this.dtgClient.ReadOnly = true;
            this.dtgClient.Size = new System.Drawing.Size(797, 221);
            this.dtgClient.TabIndex = 9;
            // 
            // cmClientInfo
            // 
            this.cmClientInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonInfoToolStripMenuItem,
            this.addClientToolStripMenuItem,
            this.updateClientToolStripMenuItem,
            this.deleteCleientToolStripMenuItem,
            this.showClientInfoToolStripMenuItem,
            this.showFindClientToolStripMenuItem,
            this.allClientListToolStripMenuItem});
            this.cmClientInfo.Name = "cmClientInfo";
            this.cmClientInfo.Size = new System.Drawing.Size(181, 180);
            this.cmClientInfo.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // showPersonInfoToolStripMenuItem
            // 
            this.showPersonInfoToolStripMenuItem.Name = "showPersonInfoToolStripMenuItem";
            this.showPersonInfoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showPersonInfoToolStripMenuItem.Text = "Show Person Info";
            this.showPersonInfoToolStripMenuItem.Click += new System.EventHandler(this.showPersonInfoToolStripMenuItem_Click);
            // 
            // addClientToolStripMenuItem
            // 
            this.addClientToolStripMenuItem.Name = "addClientToolStripMenuItem";
            this.addClientToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addClientToolStripMenuItem.Text = "add Client";
            this.addClientToolStripMenuItem.Click += new System.EventHandler(this.addClientToolStripMenuItem_Click);
            // 
            // updateClientToolStripMenuItem
            // 
            this.updateClientToolStripMenuItem.Name = "updateClientToolStripMenuItem";
            this.updateClientToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateClientToolStripMenuItem.Text = "Update Client";
            this.updateClientToolStripMenuItem.Click += new System.EventHandler(this.updateClientToolStripMenuItem_Click);
            // 
            // deleteCleientToolStripMenuItem
            // 
            this.deleteCleientToolStripMenuItem.Name = "deleteCleientToolStripMenuItem";
            this.deleteCleientToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteCleientToolStripMenuItem.Text = "Delete Cleient";
            this.deleteCleientToolStripMenuItem.Click += new System.EventHandler(this.deleteCleientToolStripMenuItem_Click);
            // 
            // showClientInfoToolStripMenuItem
            // 
            this.showClientInfoToolStripMenuItem.Name = "showClientInfoToolStripMenuItem";
            this.showClientInfoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showClientInfoToolStripMenuItem.Text = "Show Client Info";
            this.showClientInfoToolStripMenuItem.Click += new System.EventHandler(this.showClientInfoToolStripMenuItem_Click);
            // 
            // showFindClientToolStripMenuItem
            // 
            this.showFindClientToolStripMenuItem.Name = "showFindClientToolStripMenuItem";
            this.showFindClientToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showFindClientToolStripMenuItem.Text = "show Find Client";
            this.showFindClientToolStripMenuItem.Click += new System.EventHandler(this.showFindClientToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(749, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 50);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.AddClient);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(294, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // cbIsActive
            // 
            this.cbIsActive.FormattingEnabled = true;
            this.cbIsActive.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cbIsActive.Location = new System.Drawing.Point(257, 138);
            this.cbIsActive.Name = "cbIsActive";
            this.cbIsActive.Size = new System.Drawing.Size(121, 28);
            this.cbIsActive.TabIndex = 17;
            this.cbIsActive.SelectedIndexChanged += new System.EventHandler(this.cbIsActive_SelectedIndexChanged);
            // 
            // allClientListToolStripMenuItem
            // 
            this.allClientListToolStripMenuItem.Name = "allClientListToolStripMenuItem";
            this.allClientListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.allClientListToolStripMenuItem.Text = "All Client List";
            this.allClientListToolStripMenuItem.Click += new System.EventHandler(this.allClientListToolStripMenuItem_Click);
            // 
            // frmClientsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 462);
            this.Controls.Add(this.cbIsActive);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbRecord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgClient);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmClientsList";
            this.Text = "frmClientsList";
            this.Load += new System.EventHandler(this.frmClientsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgClient)).EndInit();
            this.cmClientInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbRecord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgClient;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip cmClientInfo;
        private System.Windows.Forms.ToolStripMenuItem showPersonInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCleientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showClientInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showFindClientToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbIsActive;
        private System.Windows.Forms.ToolStripMenuItem allClientListToolStripMenuItem;
    }
}