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

namespace BankSystem.Users.ChangePassword
{
    public partial class frmChangePassword : Form
    {
        private clsUser _clsUerInfo;
        private int _UserID;
        public frmChangePassword(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
        }
        private void _LoadDataUser()
        {
            _clsUerInfo = clsUser.FindByUserID(_UserID);
            if (_clsUerInfo==null)
            {
                MessageBox.Show("this User ID not Found");
                return;
            }
            ctrlUserInfoCard1.LoadUserInfo(_UserID);
            txtCurrentPass.Text = _clsUerInfo.Password;
        }
        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            _LoadDataUser();
            txtNewPass.Text = "".Trim();
            txtConfirmPass.Text = "".Trim();
        }

        private void txtCurrentPass_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCurrentPass.Text))
            {
                e.Cancel = true;
                txtCurrentPass.Focus();
                errorProvider1.SetError(txtCurrentPass, "this field must not be empty");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtCurrentPass,null);
            }
        }

        private void txtNewPass_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewPass.Text))
            {
                e.Cancel = true;
                txtNewPass.Focus();
                errorProvider1.SetError(txtNewPass, "this field must not be empty");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtNewPass, null);
            }

        }

        private void txtConfirmPass_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txtConfirmPass.Text))
            {
                e.Cancel = true;
                txtConfirmPass.Focus();
                errorProvider1.SetError
            (txtConfirmPass, "this field must not be empty");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtConfirmPass, null);
            }

            if (txtConfirmPass.Text.Trim()!=txtNewPass.Text.Trim())
            {
                e.Cancel = true;
                txtConfirmPass.Focus();
                errorProvider1.SetError
            (txtConfirmPass, "this field does not match with New Password");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtConfirmPass, null);
            }

        }

        private void Close(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Save(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("there is some fields are still not completed");
                return;
            }
            
            bool IsChangePassword = 
            _clsUerInfo.ChangePassword(txtNewPass.Text.Trim());
            if (!IsChangePassword)
            {
                MessageBox.Show("Failed changing Password",
                    "Excaption");
                return;
            }
            MessageBox.Show("New Password Changed Successfully");
            btnSave.Enabled = false;
        }
    }
}
