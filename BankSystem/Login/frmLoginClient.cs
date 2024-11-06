using BankBussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem.Login
{

    public partial class frmLoginClient : Form
    {
        private byte trim = 3;
        public frmLoginClient()
        {
            InitializeComponent();
        }
        public void LoginLocked()
        {
            lbMessage.Text = "your Accounting has been locked";
            btnLogin.Enabled = false;
        }
        public void ShowTrim()
        {
            if (trim<1)
            {
                LoginLocked();
                return;
            }
            lbMessage.Text = lbMessage.Text = $"you have {trim} trim";
        }
        private void frmLoginClient_Load(object sender, EventArgs e)
        {
            ShowTrim();
        }

        private void LoginClient(object sender, EventArgs e)
        {
            clsBankClient ClientInfo =
            clsBankClient.FindByAccountNumberAndPinCode
            (txtAccNumber.Text.Trim(), txtPinCode.Text.Trim());
            if (ClientInfo==null)
            {

                --trim;
                ShowTrim();
                MessageBox.Show("AccountNumber/PinCode is Wrong");
                return;
            }
            clsGlobal.CurrentClientInfo = ClientInfo;
            MessageBox.Show("Login Successfully","check Login",
               MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Close();
        }

        private void Close(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
