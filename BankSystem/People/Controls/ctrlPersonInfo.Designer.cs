namespace BankSystem.People.Controls
{
    partial class ctrlPersonInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbNationality = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbPersonID = new System.Windows.Forms.Label();
            this.llEditPerson = new System.Windows.Forms.LinkLabel();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbBirth = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbNationalNo = new System.Windows.Forms.Label();
            this.lbGendor = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Person ID : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbNationality);
            this.groupBox1.Controls.Add(this.lbAddress);
            this.groupBox1.Controls.Add(this.lbEmail);
            this.groupBox1.Controls.Add(this.lbBirth);
            this.groupBox1.Controls.Add(this.lbGendor);
            this.groupBox1.Controls.Add(this.lbPhone);
            this.groupBox1.Controls.Add(this.lbNationalNo);
            this.groupBox1.Controls.Add(this.lbName);
            this.groupBox1.Controls.Add(this.lbPersonID);
            this.groupBox1.Controls.Add(this.llEditPerson);
            this.groupBox1.Controls.Add(this.pbImage);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(17, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(710, 349);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbNationality
            // 
            this.lbNationality.AutoSize = true;
            this.lbNationality.Location = new System.Drawing.Point(153, 317);
            this.lbNationality.Name = "lbNationality";
            this.lbNationality.Size = new System.Drawing.Size(52, 21);
            this.lbNationality.TabIndex = 19;
            this.lbNationality.Text = "[????]";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(153, 72);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(52, 21);
            this.lbName.TabIndex = 12;
            this.lbName.Text = "[????]";
            // 
            // lbPersonID
            // 
            this.lbPersonID.AutoSize = true;
            this.lbPersonID.Location = new System.Drawing.Point(153, 39);
            this.lbPersonID.Name = "lbPersonID";
            this.lbPersonID.Size = new System.Drawing.Size(52, 21);
            this.lbPersonID.TabIndex = 11;
            this.lbPersonID.Text = "[????]";
            // 
            // llEditPerson
            // 
            this.llEditPerson.AutoSize = true;
            this.llEditPerson.Enabled = false;
            this.llEditPerson.Location = new System.Drawing.Point(543, 302);
            this.llEditPerson.Name = "llEditPerson";
            this.llEditPerson.Size = new System.Drawing.Size(96, 21);
            this.llEditPerson.TabIndex = 10;
            this.llEditPerson.TabStop = true;
            this.llEditPerson.Text = "Edit Person";
            this.llEditPerson.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llEditPerson_LinkClicked);
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(460, 62);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(241, 206);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 9;
            this.pbImage.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 317);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "Nationality  : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Birth  : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Address  : ";
            // 
            // lbBirth
            // 
            this.lbBirth.AutoSize = true;
            this.lbBirth.Location = new System.Drawing.Point(153, 212);
            this.lbBirth.Name = "lbBirth";
            this.lbBirth.Size = new System.Drawing.Size(52, 21);
            this.lbBirth.TabIndex = 16;
            this.lbBirth.Text = "[????]";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(153, 247);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(52, 21);
            this.lbEmail.TabIndex = 17;
            this.lbEmail.Text = "[????]";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(153, 282);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(52, 21);
            this.lbAddress.TabIndex = 18;
            this.lbAddress.Text = "[????]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gendor  : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 21);
            this.label9.TabIndex = 8;
            this.label9.Text = "National No  : ";
            // 
            // lbNationalNo
            // 
            this.lbNationalNo.AutoSize = true;
            this.lbNationalNo.Location = new System.Drawing.Point(153, 107);
            this.lbNationalNo.Name = "lbNationalNo";
            this.lbNationalNo.Size = new System.Drawing.Size(52, 21);
            this.lbNationalNo.TabIndex = 13;
            this.lbNationalNo.Text = "[????]";
            // 
            // lbGendor
            // 
            this.lbGendor.AutoSize = true;
            this.lbGendor.Location = new System.Drawing.Point(153, 177);
            this.lbGendor.Name = "lbGendor";
            this.lbGendor.Size = new System.Drawing.Size(52, 21);
            this.lbGendor.TabIndex = 15;
            this.lbGendor.Text = "[????]";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Location = new System.Drawing.Point(153, 142);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(52, 21);
            this.lbPhone.TabIndex = 14;
            this.lbPhone.Text = "[????]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone : ";
            // 
            // ctrlPersonInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ctrlPersonInfo";
            this.Size = new System.Drawing.Size(749, 371);
            this.Load += new System.EventHandler(this.ctrlPersonInfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbNationality;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbPersonID;
        private System.Windows.Forms.LinkLabel llEditPerson;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbBirth;
        private System.Windows.Forms.Label lbGendor;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbNationalNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}
