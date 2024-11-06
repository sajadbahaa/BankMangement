using BankBussiness;
using BankSystem.GlobalClasses;
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
using Vaildation;

namespace BankSystem.Clients
{
    public partial class frmAddClient : Form
    {
        public delegate void  DataHandler(object sender,int ClientID);
        public DataHandler _DataBack;
        
        private clsBankClient _clsClientInfo;
        private int _ClientID;
        enum enMode { add =1,update =2}
        private enMode _Mode = enMode.add;
        public frmAddClient()
        {
            InitializeComponent();
            _Mode = enMode.add;
        }
        
        private int _PersonID;
        private void ctrlPersonCardWithFilter1_OnPersonSelected(object sender, People.Controls.ctrlPersonCardWithFilter.clsPersonInfo e)
        {
            
            bool IsObjectNUlll = (e.PersonInfo==null?true:false);
            if (IsObjectNUlll)
            {
                return;
            }
            _PersonID = e.PersonInfo.PersonID;

            // if Person ID used by Another user.

            if (clsUser.IsPersonIDExist(_PersonID))
            {
                MessageBox.Show("Person ID used by another User");
                return;
            }
            // if person ID not used by another client

            _ClientID = e.PersonInfo.GetClientID();

            if(_ClientID!=-1)
            {

                MessageBox.Show($"Person ID used by another Client ID [{_ClientID}]");
            return;
            }

        }
    private void _ResetDefaultValue()
        {
            
            btnSave.Enabled = false;
            tabClientInfo.Enabled = false;

            if (_Mode==enMode.add)
            {
                lbMode.Text = "Add Client";
                lbUsername.Text = clsGlobal.CurrnetUser.Username;
                lbClientID.Text = "[????]";
                lbCreateDate.Text = clsFormat.DateToString(DateTime.Now);
                txtAccNumber.Text = "".Trim();
                txtBalance.Text = "".Trim();
                txtPinCode.Text = "".Trim();
                _clsClientInfo = new clsBankClient();
                chIsActive.Checked = true;
                return;
            }
            
            
        }
    
        
        private void NextToClientInfo(object sender, EventArgs e)
        {
            if (ctrlPersonCardWithFilter1.PersonID!=-1)
            {
                if (clsUser.IsPersonIDExist(_PersonID))
                {
                    MessageBox.Show("Person ID used by another User");
                    return;
                }


                _ClientID = ctrlPersonCardWithFilter1.PersonInfo.GetClientID();
                if (_ClientID != -1)
                {

                    MessageBox.Show($"Person ID used by another Client ID [{_ClientID}]");
                    return;
                }
                tabClientInfo.Enabled = true;
                btnSave.Enabled = true;
                tabControl1.SelectedIndex = 1;
                lbName.Text = ctrlPersonCardWithFilter1.PersonInfo.Name;
                _PersonID = ctrlPersonCardWithFilter1.PersonID;
            }
            else
            {
                MessageBox.Show("Choose Person ID");
                ctrlPersonCardWithFilter1.FilterFocuse();
            }


            // if person ID not used by another client



        }

        private void frmAddClient_Load(object sender, EventArgs e)
        {
            _ResetDefaultValue();
        }

        private void txtAccNumber_Validating(object sender, CancelEventArgs e)
        {
            
            if (string.IsNullOrEmpty(txtAccNumber.Text))
            {
                e.Cancel = true;
                txtAccNumber.Focus();
                errorProvider1.SetError(txtAccNumber,"this Field is Required");
                return;
            }
            
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtAccNumber, "");
            }

            if (txtAccNumber.Enabled&&clsBankClient.IsExist(txtAccNumber.Text))
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
                errorProvider1.SetError(txtPinCode,"this Field is Required");
                return;
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPinCode,"");
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
                errorProvider1.SetError(txtBalance,"this Field is Required");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtBalance,"");
            }

            if (!clsVaildation.IsNumber(txtBalance.Text))
            {
                e.Cancel = true;
                txtBalance.Focus();
                errorProvider1.SetError(txtBalance,"Enter Only Numbers");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtBalance, "");
            }
        }

        private void Save(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to add Client?","",MessageBoxButtons.YesNo)==DialogResult.No)
            {
                return;
            }
            if (!this.ValidateChildren())
            {
                MessageBox.Show("there are some filed not completed yet!");
                return;
            }
            _clsClientInfo.PersonID = _PersonID;
            _clsClientInfo.Balance = Convert.ToInt32(txtBalance.Text);
            _clsClientInfo.AccountNumber = txtAccNumber.Text;
            _clsClientInfo.CreateDate = DateTime.Now;
            _clsClientInfo.CreatedByUserID = clsGlobal.CurrnetUser.UserID;
            _clsClientInfo.PinCode = txtPinCode.Text;
            _clsClientInfo.IsActive = (chIsActive.Checked ? true : false);
            if (!_clsClientInfo.Save())
            {
                MessageBox.Show("Failed Saving Data","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Saving Successfully","Save Data",
                MessageBoxButtons.OK,MessageBoxIcon.Information);
            lbClientID.Text = _clsClientInfo.ClientID.ToString();
            _ClientID = _clsClientInfo.ClientID;
            _Mode = enMode.update;
            btnSave.Enabled = false;
            _DataBack?.Invoke(this, _ClientID);
        
        }

        private void Close(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
