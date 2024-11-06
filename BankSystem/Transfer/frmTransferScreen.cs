using BankBussiness;
using BankSystem.Clients;
using BankSystem.GlobalClasses;
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

namespace BankSystem.Transfer
{
    public partial class frmTransferScreen : Form
    {
        public frmTransferScreen()
        {
            InitializeComponent();
        }

        private clsBankClient ClientInfo1;
        private clsBankClient ClientInfo2;
        private void frmTransferScreen_Load(object sender, EventArgs e)
        {
            lbDate.Text = clsFormat.DateToString(DateTime.Now);
            btnNext.Enabled = false;
            btnNextToTransfer.Enabled = false;
            btnTransfer.Enabled = false;
            llShowClientInfo1.Enabled = false;
            llShowClientInfo2.Enabled = false;
            llShowHistory.Enabled = false;
            tabTransferProcess.Enabled = false;
            tabTransferTo.Enabled = false;
            lbUsername.Text = clsGlobal.CurrnetUser.Username;
                
                }

        private void NextToAccount2(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            tabTransferTo.Enabled = true;
        }

        private void Close(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TransferMoney(object sender, EventArgs e)
        {
            
            if (!this.ValidateChildren())
            {
                MessageBox.Show("some field are still not Completed","Validation",
                    MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
            if (MessageBox.Show("Do you want Transfer ?","Transfer Money",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.No)
            {
                MessageBox.Show($"Failed Transfer money to the Account[{ClientInfo2.AccountNumber}]");
                return;
            }
            int Amount = Convert.ToInt32(txtAmount.Text);
            int TransferID = -1;
            bool IsTransfer = clsTransfer.Transfer(ref TransferID, ClientInfo1.Balance,ref ClientInfo1,ref ClientInfo2, Amount, clsGlobal.CurrnetUser.UserID);
            
            if (!IsTransfer)
            {
                MessageBox.Show($"Failed Transfer Process");
                return;
            }

            MessageBox.Show("Transfer Process Saved Successfully","Transfer",
                MessageBoxButtons.OK,MessageBoxIcon.Information);
        lbTransferID.Text = TransferID.ToString();

            lbBAcc1AfterTransfer.Text = ClientInfo1.Balance.ToString();
            lbBAcc2AfterTransfer.Text = ClientInfo2.Balance.ToString();
            llShowClientInfo1.Enabled = true;
            llShowClientInfo2.Enabled = true;
            llShowHistory.Enabled = true;
        }

        private void BackToMainScreen(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void label4_Click(object sender, EventArgs e)
        {
                    }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Back(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void NextToTransferProcess(object sender, EventArgs e)
        {
            lbAccNumber1.Text = ClientInfo1.AccountNumber;
            lbAccNumber2.Text = ClientInfo2.AccountNumber;
            lbBAcc1Befor.Text = ClientInfo1.Balance.ToString();
            tabControl1.SelectedIndex = 2;
            tabTransferProcess.Enabled = true;
            btnTransfer.Enabled = true;
        }

        private void txtAmount_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtAmount.Text))
            {
                e.Cancel = true;
                txtAmount.Focus();
                errorProvider1.SetError(txtAmount, "this Field is Required");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtAmount, "");
            }
            if (!clsVaildation.IsNumber(txtAmount.Text))
            {
                e.Cancel = true;
                txtAmount.Focus();
                errorProvider1.SetError(txtAmount, "only enter Numbers");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtAmount, null);
            }
        }

        private void ctrlAccount1_OnClientInfoSelect(object sender, Clients.Controls.ctrlClientInfoWithFilter.GetClientInfo e)
        {
            bool IsObjectNull = (e.ClientInfo==null?true:false);
            if (IsObjectNull)
            {
                return;
            }
            ClientInfo1 = e.ClientInfo;
            // check if Client  not Active .
            if (!ClientInfo1.IsActive)
            {
                MessageBox.Show("Card Client not Active",
                "Check", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
            // check if balance does not equal 0;
            if (ClientInfo1.Balance==0)
            {
                MessageBox.Show("you dont have enough money for transfer",
                    "Check",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                btnNext.Enabled = false;

                return;
            }
            btnNext.Enabled = true;

        }

        private void BackToMiddelScreen(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void ctrlAccount2_OnClientInfoSelect(object sender, Clients.Controls.ctrlClientInfoWithFilter.GetClientInfo e)
        {
            bool IsObjectNull = (e.ClientInfo==null?true:false);
            if (IsObjectNull)
            {
                return;
            }
            ClientInfo2 = e.ClientInfo;
            // check if Account  does not match with other Accounts   
            if (ClientInfo1.AccountNumber==ClientInfo2.AccountNumber)
            {
                MessageBox.Show("you can not  transfer Money at the same Account",
                    "Check from Account",MessageBoxButtons.OK,MessageBoxIcon.Error);
                btnNextToTransfer.Enabled = false;
                return;
            }

            // check if Client Card Active
            
            if (!ClientInfo2.IsActive)
            {
                MessageBox.Show("Card Client not Active",
                                "Check", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            btnNextToTransfer.Enabled = true;

        }

        private void llShowHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmTransferHisory frm = new frmTransferHisory(clsGlobal.CurrnetUser.UserID);
            frm.ShowDialog();
        }

        private void llShowClientInfo1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowClientInfo frm = new frmShowClientInfo(ClientInfo1.ClientID);
            frm.ShowDialog();
        }

        private void llShowClientInfo2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowClientInfo frm = new frmShowClientInfo(ClientInfo2.ClientID);
            frm.ShowDialog();
        }
    }
}
