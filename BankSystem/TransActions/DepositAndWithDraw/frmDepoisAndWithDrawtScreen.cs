using BankBussiness;
using BankSystem.Clients;
using BankSystem.GlobalClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vaildation;

namespace BankSystem.TransActions.Deposit
{

    public partial class frmTransactionScreen : Form
    {
        private clsBankClient ClientInfo;
        private int _ClientID = -1;
        public enum enTransaction { Depoist = 1, WithDraw = 2 }
        public enTransaction GetTransactionStatus()
        {
            if (rbDepoist.Checked)
                return enTransaction.Depoist;
            else
                return enTransaction.WithDraw;
        }
       

        public frmTransactionScreen()
        {
            InitializeComponent();
        }
        public frmTransactionScreen(int ClientID)
        {
            InitializeComponent();
            _ClientID = ClientID;
            ctrlClientInfoWithFilter1.FilterEnabled = false;
        }
        private void _LoadData()
        {
ctrlClientInfoWithFilter1.LoadClientInfo(_ClientID);
            ClientInfo = ctrlClientInfoWithFilter1.ClientBankSelected;            
            txtAmount.Enabled = true;
            gbTrainsAction.Enabled = true;
            btnSave.Enabled = true;
        }
        private void _RestDefaultValue()
        {
            btnSave.Enabled = false;
            txtAmount.Enabled = false;
            gbTrainsAction.Enabled = false;
            llshowClient.Enabled = false;
            GetTransactionStatus();
        }
        private void frmDepoistScreen_Load(object sender, EventArgs e)
        {
            _RestDefaultValue();

            if (_ClientID!=-1)
            {
                _LoadData();
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void ctrlClientInfoWithFilter1_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
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
                errorProvider1.SetError(txtAmount,"only enter Numbers");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtAmount,null);
            }
        }

        private void rbDepoist_CheckedChanged(object sender, EventArgs e)
        {
            lbTitlt.Text = "Deposit";
            GetTransactionStatus();
            return;
        }

        private void rbWithDraw_CheckedChanged(object sender, EventArgs e)
        {
            lbTitlt.Text = "With Draw";
            GetTransactionStatus();
            return;

        }

        private void ctrlClientInfoWithFilter1_OnClientInfoSelect(object sender, Clients.Controls.ctrlClientInfoWithFilter.GetClientInfo e)
        {
            //check if object not null
            bool IsObjectNull = (e.ClientInfo == null ? true : false);
            if (IsObjectNull)
                return;
            
            ClientInfo = e.ClientInfo;

            // Check if client not Active
            if (!ClientInfo.IsActive)
            {
                MessageBox.Show("your Card is not Active");
                return; 
            }
            // now you can do any trainsaction

            btnSave.Enabled = true;
            txtAmount.Enabled = true;
            gbTrainsAction.Enabled = true;
        }

        private void llshowClient_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowClientInfo frm = new frmShowClientInfo(ClientInfo.ClientID);
            frm.ShowDialog();
        }
         private bool TransactionPerformace(enTransaction trans,int Amount)
         {
            switch (trans)
            {
                case enTransaction.Depoist:
                    return ClientInfo.Depoist(Amount);
                
                case enTransaction.WithDraw:
                    if (clsVaildation.IsNum1SmallerThanNum2(ClientInfo.Balance,Amount))
                    {
                        MessageBox.Show("you dont have enouph money ");
                        return false;

                    }
                    else 
                    {
                      
                        return ClientInfo.WithDraw(Amount);
                    }
                    
            }
            return false;
        }
        private void Save(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("there is required still empty");
                return;
            }
            int Amount = int.Parse( txtAmount.Text);
            // handel if Amount Bigger than Current Balance
            if (!TransactionPerformace(GetTransactionStatus(), Amount))
            {
                MessageBox.Show("Failed Transaction");
                return;
            }
            MessageBox.Show("Treansaction Saved Successfully","Transactuion",
                MessageBoxButtons.OK,MessageBoxIcon.Information);
            llshowClient.Enabled = true;
            //btnSave.Enabled = true;
            btnSave.Enabled = false;
        }

        private void Close(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
