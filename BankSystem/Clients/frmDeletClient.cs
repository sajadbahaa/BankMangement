using BankBussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem.Clients
{
    public partial class frmDeletClient : Form
    {
        public frmDeletClient()
        {
            InitializeComponent();
        }
        public frmDeletClient(int ClientID)
        {
            InitializeComponent();
            _ClientID = ClientID;
        }
        private void _LoadData()
        {
            ctrlClientInfoWithFilter1.FilterEnabled = false;
            ctrlClientInfoWithFilter1.LoadClientInfo(_ClientID);
        }
        private void DeletClient(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure?", "Delete Client",
               MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                == DialogResult.No)
            {
                return;
            }
            if (clsBankClient.Delete(_ClientID))
            {
                MessageBox.Show("Deleted Client Successfully");
                return;
            }
            else
            {
                MessageBox.Show("this Client Linked with another table");
            }
        }

        private void Close(object sender, EventArgs e)
        {

        }
        private int _ClientID = -1;
        private void ctrlClientInfoWithFilter1_OnClientInfoSelect(object sender, Controls.ctrlClientInfoWithFilter.GetClientInfo e)
        {
            bool IsObjectNUlll = (e.ClientInfo == null ? true : false);
            if (IsObjectNUlll)
            {
                return;
            }
            _ClientID = e.ClientInfo.ClientID;
            btnDelete.Enabled = true;
        }

        private void frmDeletClient_Load(object sender, EventArgs e)
        {
            ctrlClientInfoWithFilter1.DisableAddClient();

            if (_ClientID==-1)
            {
                btnDelete.Enabled = false;
                return;
            }
            _LoadData();
        }
    }
}
