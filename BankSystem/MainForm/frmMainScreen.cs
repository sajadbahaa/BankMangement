using BankBussiness;
using BankSystem.Clients;
using BankSystem.Login;
using BankSystem.MessgaeDenieAccess;
using BankSystem.People;
using BankSystem.TransActions.Deposit;
using BankSystem.Transfer;
using BankSystem.Users;
using BankSystem.Users.ChangePassword;
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
    public partial class frmMainScreen : Form
    {
        public frmMainScreen()
        {
            InitializeComponent();
        }

        private void OnTransactionClick(object sender, EventArgs e)
        {

        }

        private void OnUserClick(object sender, EventArgs e)
        {
            if (!clsGlobal.DoyouHavePermission(clsSettings.enPermissions.eManageUser))
            {
                frmDenieAccress frm1 = new frmDenieAccress();
                frm1.ShowDialog();
                return;
            }
            frmUsersList frm = new frmUsersList();
            frm.ShowDialog();
        }

        private void OnClickClients(object sender, EventArgs e)
        {
            if (!clsGlobal.DoyouHavePermission(clsSettings.enPermissions.eAll))
            {
                frmDenieAccress frm1 = new frmDenieAccress();
                frm1.ShowDialog();
                return;
            }
            frmClientsList frm = new frmClientsList();
            frm.ShowDialog();
        }

        private void OnClickSettings(object sender, EventArgs e)
        {
           // MessageBox.Show("Un Implemented Yet",
           //"Transaction Screen"
           //, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void OnShowPersonList(object sender, EventArgs e)
        {
            frmPeopleList frm = new frmPeopleList();
            frm.ShowDialog();
        }

        private void ShowPersonInfo(object sender, EventArgs e)
        {
            frmShowPersonInfo frm = new frmShowPersonInfo(clsGlobal.CurrnetUser.PersonID);
            frm.ShowDialog();
        
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword(clsGlobal.CurrnetUser.UserID);
            frm.Show();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrentClientInfo = null;
            clsGlobal.CurrnetUser = null;
            this.Close();
        }

        private void frmTransaction(object sender, EventArgs e)
        {
            frmTransactionScreen frm = new frmTransactionScreen(clsGlobal.CurrentClientInfo.ClientID);
            frm.ShowDialog();
        }

        private void menuStrip1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnLoginClient_Click(object sender, EventArgs e)
        {

        }

        private void transferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTransferScreen frm = new frmTransferScreen();
            frm.ShowDialog();
        }

        private void loginClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoginClient frm = new frmLoginClient();
            frm.ShowDialog();
        }

        private void loginClientToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmLoginClient frm = new frmLoginClient();
            frm.ShowDialog();
        }

        private void frmMainScreen_Load(object sender, EventArgs e)
        {

        }

        private void showClientListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.DoyouHavePermission(clsSettings.enPermissions.eClientList))
            {
                frmDenieAccress frm1 = new frmDenieAccress();
                frm1.ShowDialog();
                return;
            }
            frmAllClientList frm = new frmAllClientList();
            frm.ShowDialog();
        }

        private void addClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.DoyouHavePermission(clsSettings.enPermissions.eAddClient))
            {
                frmDenieAccress frm1 = new frmDenieAccress();
                frm1.ShowDialog();
                return;
            }
            frmAddClient frm = new frmAddClient();
            frm.ShowDialog();

        }

        private void updateClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.DoyouHavePermission(clsSettings.enPermissions.eUpdateClient))
            {
                frmDenieAccress frm1 = new frmDenieAccress();
                frm1.ShowDialog();
                return;
            }
            frmUpdateClient frm = new frmUpdateClient();
            frm.ShowDialog();
        }

        private void deleteClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.DoyouHavePermission(clsSettings.enPermissions.eDeleteClient))
            {
                frmDenieAccress frm1 = new frmDenieAccress();
                frm1.ShowDialog();
                return;
            }
            frmDeletClient frm = new frmDeletClient();
            frm.ShowDialog();

        }

        private void findClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.DoyouHavePermission(clsSettings.enPermissions.eFindClient))
            {
                frmDenieAccress frm1 = new frmDenieAccress();
                frm1.ShowDialog();
                return;
            }

            frmFindClient frm = new frmFindClient();
            frm.ShowDialog();
        }

        private void manageUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.DoyouHavePermission(clsSettings.enPermissions.eManageUser))
            {
                frmDenieAccress frm1 = new frmDenieAccress();
                frm1.ShowDialog();
                return;
            }

            frmUsersList frm = new frmUsersList();
            frm.ShowDialog();
        }

        private void tranfactionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void transferToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmLoginClient frm = new frmLoginClient();
            frm.ShowDialog();
        }

        private void transferListToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void btnTransferList_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAddTrans_Click(object sender, EventArgs e)
        {
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.DoyouHavePermission(clsSettings.enPermissions.eManageUser))
            {
                frmDenieAccress frm1 = new frmDenieAccress();
                frm1.ShowDialog();
                return;
            }
            if (clsGlobal.CurrentClientInfo==null)
            {
                MessageBox.Show("you can not Do Transaction without Login");
                return;
            }
            frmTransactionScreen frm = new frmTransactionScreen(clsGlobal.CurrentClientInfo.ClientID);
            frm.Show();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSeparator5_Click(object sender, EventArgs e)
        {

        }

        private void transferListToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (!clsGlobal.DoyouHavePermission(clsSettings.enPermissions.eFindClient))
            {
                btnAddTransfer.Enabled = false;
                btnTransferList.Enabled = false;
                frmDenieAccress frm1 = new frmDenieAccress();
                frm1.ShowDialog();
                return;
            }
            frmAllTransfer frm = new frmAllTransfer();
            frm.ShowDialog();


        }

        private void transferMoneyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTransferScreen frm = new frmTransferScreen();
            frm.ShowDialog();

        }
    }
}
