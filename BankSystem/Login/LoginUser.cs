using clsPeople;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem
{
    public partial class LoginUser : Form
    {
        public LoginUser()
        {
            InitializeComponent();
        }

        private void Close(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OnLoginRegister(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                MessageBox.Show("There are some fields are still empty , look for Red Icon to solve problem !",
                   "",MessageBoxButtons.OK,MessageBoxIcon.Error
                    ) ;
                return;
            }
            // define object from clsUser
     clsUser UserInfo = clsUser.FindByUsernameAndPassword(txtUsername.Text,txtPassword.Text);
            // check if UserInfo exist
            if (UserInfo==null)
            {
                MessageBox.Show("this Username/Password  is wrong");
                return;
            }
            
            // check if User not active.
            if (!UserInfo.IsActive) { 
                MessageBox.Show("this User Is not Active you can not Access",
                    "check UserInfo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            if (chRemember.Checked)
                clsGlobal.RemmberData(txtUsername.Text.Trim(),txtPassword.Text.Trim());
            else
                clsGlobal.RemmberData("","");

            // i will fill clsGlobal.CurrenUser
            clsGlobal.CurrnetUser = UserInfo;


            frmMainScreen frm = new frmMainScreen();
            frm.ShowDialog();

        }

        private void txtUsernameAndPassword_Validating(object sender, CancelEventArgs e)
        {
            TextBox text = (TextBox)sender;
            if (string.IsNullOrEmpty(text.Text))
            {
                e.Cancel = true;
                text.Focus();
errorProvider1.SetError(text,"this Field is required!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(text,null);
            }
        }

        private void LoadDataForm(object sender, EventArgs e)
        {
            string Username = "";
                string Password = "";
        bool IsFind = clsGlobal.GetStoredData(ref Username, ref Password);
            if (IsFind)
            {
                txtUsername.Text = Username;
                txtPassword.Text = Password; 
            }
            chRemember.Checked = IsFind;
        }
    }
}
