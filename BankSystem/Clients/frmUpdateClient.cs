using BankBussiness;
using BankSystem.GlobalClasses;
using BankSystem.People.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vaildation;
using static BankBussiness.clsBankClient;

namespace BankSystem.Clients
{
    public partial class frmUpdateClient : Form
    {
        enum enMode { Update = 1,Find =2}
        private enMode _Mode;
        public frmUpdateClient()
        {
            InitializeComponent();
            _Mode = enMode.Find;
        }
        public frmUpdateClient(int ClientID)
        {
            InitializeComponent();
            _ClientID = ClientID;
            _Mode = enMode.Update;
        }
        private void _LoadInfo()
        {
            ctrlClientInfoWithFilter1.LoadClientInfo(_ClientID);
            ctrlClientInfoWithFilter1.FilterEnabled = false;

            _clsClientInfo = ctrlClientInfoWithFilter1.ClientSelected;
            if (_clsClientInfo==null)
            {
                return;
            }
            txtAccNumber.Enabled = false;
            txtAccNumber.Text = _clsClientInfo.AccountNumber;
            txtBalance.Text = _clsClientInfo.Balance.ToString();
            txtPinCode.Text = _clsClientInfo.PinCode.ToString();
            lbClientID.Text = _clsClientInfo.ToString();
            lbUsername.Text = _clsClientInfo.UserInfo.Username;
            lbCreateDate.Text = clsFormat.DateToString(_clsClientInfo.CreateDate);
            lbName.Text = _clsClientInfo.PersonInfo.Name;
            
            chIsActive.Checked = _clsClientInfo.IsActive;
            btnNext.Enabled = true;
           
        }
        private clsBankClient _clsClientInfo;
        private int _ClientID;

        private void frmUpdateClient_Load(object sender, EventArgs e)
        {
            ctrlClientInfoWithFilter1.DisableAddClient();
            btnNext.Enabled = false;
            btnUpdate.Enabled = false;
            tabUpdatClient.Enabled = false;
            llShowClient.Enabled = false;
            if (_Mode==enMode.Update)
            {
                _LoadInfo();
            }
        }
        private void txtAccNumber_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txtAccNumber.Text))
            {
                e.Cancel = true;
                txtAccNumber.Focus();
                errorProvider1.SetError(txtAccNumber, "this Field is Required");
                return;
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtAccNumber, "");
            }

            if (txtAccNumber.Enabled && clsBankClient.IsExist(txtAccNumber.Text))
            {
                e.Cancel = true;
                txtAccNumber.Focus();
                errorProvider1.SetError(txtAccNumber, "this Acc.Number Used by AnotherClient");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtAccNumber, null);
            }

        }

        private void txtPinCode_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPinCode.Text))
            {
                e.Cancel = true;
                txtPinCode.Focus();
                errorProvider1.SetError(txtPinCode, "this Field is Required");
                return;
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPinCode, "");
            }
            if (!clsVaildation.IsNumber(txtPinCode.Text))
            {
                e.Cancel = true;
                txtPinCode.Focus();
                errorProvider1.SetError(txtPinCode, "Enter Only Numbers");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPinCode, "");
            }
        }

        private void txtBalance_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtBalance.Text))
            {
                e.Cancel = true;
                txtBalance.Focus();
                errorProvider1.SetError(txtBalance, "this Field is Required");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtBalance, "");
            }

            if (!clsVaildation.IsNumber(txtBalance.Text))
            {
                e.Cancel = true;
                txtBalance.Focus();
                errorProvider1.SetError(txtBalance, "Enter Only Numbers");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtBalance, "");
            }
        }

        private void ctrlClientInfoWithFilter1_OnClientInfoSelect(object sender, Controls.ctrlClientInfoWithFilter.GetClientInfo e)
        {
            bool IsObjectNUlll = (e.ClientInfo== null ? true : false);
            if (IsObjectNUlll)
            {
                return;
            }
            _clsClientInfo = e.ClientInfo;
            txtAccNumber.Enabled = false;
            txtAccNumber.Text = _clsClientInfo.AccountNumber;
            txtBalance.Text = _clsClientInfo.Balance.ToString();
            txtPinCode.Text = _clsClientInfo.PinCode.ToString();
            lbClientID.Text = _clsClientInfo.ClientID.ToString();
            lbUsername.Text = _clsClientInfo.UserInfo.Username;
            lbCreateDate.Text = clsFormat.DateToString(_clsClientInfo.CreateDate);
            lbName.Text = _clsClientInfo.PersonInfo.Name;
            btnNext.Enabled = true;
            chIsActive.Checked = _clsClientInfo.IsActive;
            _ClientID = _clsClientInfo.ClientID;
            
        }

        private void UpdateInfo(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to add Client?", "", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            if (!this.ValidateChildren())
            {
                MessageBox.Show("there are some filed not completed yet!");
                return;
            }

            _clsClientInfo.Balance = Convert.ToInt32(txtBalance.Text);
            //_clsClientInfo.AccountNumber = txtAccNumber.Text;
            _clsClientInfo.CreateDate = DateTime.Now;
            _clsClientInfo.CreatedByUserID = clsGlobal.CurrnetUser.UserID;
            _clsClientInfo.PinCode = txtPinCode.Text;
            _clsClientInfo.IsActive = (chIsActive.Checked ? true : false);
            if (!_clsClientInfo.Save())
            {
                MessageBox.Show("Failed Saving Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Saving Successfully", "Save Data",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            lbClientID.Text = _clsClientInfo.ClientID.ToString();
            _ClientID = _clsClientInfo.ClientID;
            _Mode = enMode.Update;
           btnUpdate.Enabled = false;
            ctrlClientInfoWithFilter1.FilterEnabled = false;
            llShowClient.Enabled = true;

        }

        private void NexrToUpdate(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            btnUpdate.Enabled = true;
            tabUpdatClient.Enabled = true;
        
        }

        private void ctrlClientInfoWithFilter1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowClientInfo frm = new frmShowClientInfo(_ClientID);
            frm.ShowDialog();
        }
    }
}
