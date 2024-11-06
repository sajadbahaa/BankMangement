using BankBussiness;
using BankSystem.GlobalClasses;
using clsPeople;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vaildation;

namespace BankSystem.Users
{
   
    public partial class frmAddUser : Form
    {
        private int _UserID;
        private int _PersonID;
        private clsUser _clsUserInfo;
        enum enMode
        { Add = 1, update = 2 }
        private enMode _Mode = enMode.Add;
        public frmAddUser()
        {
            InitializeComponent();

            _Mode = enMode.Add;
                }
        public frmAddUser(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
            ctrlPersonCardWithFilter1.FilterEnabled = false;
            _Mode = enMode.update;
        }
        private void _ResetDefaultValue()
        {
            lbMode.Text = "Add User";
            lbUserID.Text = "[????]";
            txtPassword.Text = "".Trim();
            txtUsername.Text = "".Trim();
            chIsActive.Checked = true;
            btnSave.Enabled = false;
            tabUserInfo.Enabled = false;
           // btnNext.Enabled = false;
            _clsUserInfo = new clsUser();
            return;
        }
 private void _FillUserInfo()
        {

            _clsUserInfo = clsUser.FindByUserID(_UserID);
            if (_clsUserInfo==null)
            {
                MessageBox.Show("this user ID not Found","",
                   MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            ctrlPersonCardWithFilter1.LoadPersonInfo(_clsUserInfo.PersonID);
            _PersonID = _clsUserInfo.PersonID; 
            lbUserID.Text = _clsUserInfo.UserID.ToString();
            txtUsername.Text = _clsUserInfo.Username;
            txtPassword.Text = _clsUserInfo.Password;
            txtConfirmPassword.Text = txtPassword.Text;
            lbPermission.Text = _clsUserInfo.Permission.ToString();
        }
        private void frmAddUser_Load(object sender, EventArgs e)
        {
            _ResetDefaultValue();

            if (_Mode == enMode.update)
                _FillUserInfo();

        }

        private void NextToUserInfo(object sender, EventArgs e)
        {
            if (_Mode == enMode.update)
            {
                tabControl1.SelectedIndex = 1;
                btnSave.Enabled = true;
                tabUserInfo.Enabled = true;
                return;
            }
            if (ctrlPersonCardWithFilter1.PersonID!=-1)
            {
                if (clsUser.IsPersonIDExist(_PersonID))
                {
                    MessageBox.Show("you can not use Person ID used by another User"
                        , "Check Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                int _ClientID = ctrlPersonCardWithFilter1.PersonInfo.GetClientID();

                if (_ClientID != -1)
                {

                    MessageBox.Show($"Person ID used by another Client ID [{_ClientID}]");
                    return;
                }
                // you can add User
                tabControl1.SelectedIndex = 1;
                btnSave.Enabled = true;
                tabUserInfo.Enabled = true;
                _PersonID = ctrlPersonCardWithFilter1.PersonID;
            }
            else
            {
                MessageBox.Show("Choose Person ID");
                ctrlPersonCardWithFilter1.FilterFocuse();
            }

        }

        private void ctrlPersonCardWithFilter1_OnPersonSelected(object sender, People.Controls.ctrlPersonCardWithFilter.clsPersonInfo e)
        {
            
            bool IsPersonInfoExist = (e.PersonInfo == null ? false : true);
            
            // check if Person Info exist
            if (!IsPersonInfoExist)
            {
                return;
            }
                _PersonID = ctrlPersonCardWithFilter1.PersonID;

            // is person ID used by Users
            if (clsUser.IsPersonIDExist(_PersonID))
            {
                MessageBox.Show("you can not use Person ID used by another User"
                    ,"Check Info",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
            int _ClientID = ctrlPersonCardWithFilter1.PersonInfo.GetClientID();

            if (_ClientID != -1)
            {

                MessageBox.Show($"Person ID used by another Client ID [{_ClientID}]");
                return;
            }

            // this person ID not used yet
            //you can use it 

        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
           // handel should not enter empty
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                e.Cancel = true;
                txtUsername.Focus();
                errorProvider1.SetError(txtUsername,"this field is Required");
                return;
            }
            
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtUsername,null);
            }
           // you should not enter numbers
            if (clsVaildation.IsNumber(txtUsername.Text))
            {
                e.Cancel = true;
                txtUsername.Focus();
                errorProvider1.SetError(txtUsername, "you should not enter Numbers");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtUsername, null);
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            // handel should not enter empty
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                e.Cancel = true;
                txtPassword.Focus();
                errorProvider1.SetError(txtPassword, "this field is Required");
                return;
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPassword, null);
            }


        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                e.Cancel = true;
                txtConfirmPassword.Focus();
                errorProvider1.SetError(txtConfirmPassword, "this field is Required");
                return;
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtConfirmPassword,null);
            }

            // check Confirm Password match with Password
            if (txtConfirmPassword.Text!=txtPassword.Text)
            {
                e.Cancel = true;
                txtConfirmPassword.Focus();
                errorProvider1.SetError(txtConfirmPassword, "this Confirm Password does not match with Current Password");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtConfirmPassword, null);
            }


        }

        private void Close(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Save(object sender, EventArgs e)
        {
           

            _clsUserInfo.Username = txtUsername.Text;
            _clsUserInfo.Password = txtPassword.Text;
            _clsUserInfo.PersonID = _PersonID;
            _clsUserInfo.IsActive = (chIsActive.Checked?true:false);
            _clsUserInfo.Permission = ReadPermissionToSet();
            bool IsSave = _clsUserInfo.Save();
            if (!IsSave)
            {
                MessageBox.Show("Failed Saving Data","Error Exaption",
                   MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Saved Successfully");
            lbUserID.Text = _clsUserInfo.UserID.ToString();
            btnSave.Enabled = false;
            lbPermission.Text = _clsUserInfo.Permission.ToString();
            
        }
        private int ReadPermissionToSet()
        {
            int Permission = 0;
            if 
(MessageBox.Show("Do you want to give full Access","",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                return -1;
            }
            if
(MessageBox.Show("Do you want to give access to Show Client List", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Permission+=(int)clsSettings.enPermissions.eClientList;
            }
            if
(MessageBox.Show("Do you want to give access to Add Client", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Permission += (int)clsSettings.enPermissions.eAddClient;
            }
            if
(MessageBox.Show("Do you want to give access to Update Client", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Permission += (int)clsSettings.enPermissions.eUpdateClient;
            }
            if
(MessageBox.Show("Do you want to give access to Delete Client ", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Permission += (int)clsSettings.enPermissions.eDeleteClient;
            }
            if
(MessageBox.Show("Do you want to give access to Find Client", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Permission += (int)clsSettings.enPermissions.eFindClient;
            }
            if
(MessageBox.Show("Do you want to give access to Manage Users", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Permission += (int)clsSettings.enPermissions.eManageUser;
            }

            if
(MessageBox.Show("Do you want to give access to TransAction", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Permission += (int)clsSettings.enPermissions.eTransAction;
            }

            if
(MessageBox.Show("Do you want to give access to Transfer", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Permission += (int)clsSettings.enPermissions.eTransfer;
            }

            return Permission;
        }
      
        private void tabUserInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
