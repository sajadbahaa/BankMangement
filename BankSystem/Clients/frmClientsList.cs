using BankBussiness;
using BankSystem.People;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem.Clients
{
    public partial class frmClientsList : Form
    {
        private DataView _dtvClient;
        public frmClientsList()
        {
            InitializeComponent();
        }
//        None


        private void frmClientsList_Load(object sender, EventArgs e)
        {
            cbFilter.SelectedIndex = 0;
            txtFilter.Visible = false;
            cbIsActive.Visible = false;
            _dtvClient = clsBankClient.GetAllClients().DefaultView;
            dtgClient.DataSource = _dtvClient;
            lbRecord.Text = dtgClient.RowCount.ToString();
        }
        private void _GetFilter()
        {
            
            string FilterColumn = "";
            switch (cbFilter.Text)
            {
                case "None":
                    FilterColumn = "None";
                    break;
                case "PersonID":
                    FilterColumn = "PersonID";
                    break;
                case "AccountNumber":
                    FilterColumn = "AccountNumber";
                    break;
                case "ClientID":
                    FilterColumn = "ClientID";
                    break;
            }
            if (txtFilter.Text == "".Trim() || FilterColumn == "None")
            {
                _dtvClient.RowFilter = "";
                return;
            }
            if (FilterColumn != "AccountNumber")
            {
                _dtvClient.RowFilter = $"{FilterColumn} = {txtFilter.Text}";
            }
            else
            {
                _dtvClient.RowFilter = $"{FilterColumn} Like '" + txtFilter.Text + "%'";
            }
            dtgClient.DataSource = _dtvClient;

        }
            private void AddClient(object sender, EventArgs e)
        {
            frmAddClient frm = new frmAddClient();
            frm.ShowDialog();
            frmClientsList_Load(null, null);

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {

        }

        private void updateClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateClient frm = new frmUpdateClient((int)dtgClient.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmClientsList_Load(null, null);
        }

        private void showPersonInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowPersonInfo frm = new frmShowPersonInfo((int)dtgClient.CurrentRow.Cells[1].Value);
            frm.ShowDialog();
            frmClientsList_Load(null, null);
        }

        private void addClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddClient frm = new frmAddClient();
            frm.ShowDialog();
            frmClientsList_Load(null, null);

        }

        private void deleteCleientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //(int)dtgClient.CurrentRow.Cells[0].Value
            frmDeletClient frm = new frmDeletClient();
            frm.ShowDialog();
            frmClientsList_Load(null, null);
            
        }

        private void showClientInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowClientInfo frm = new frmShowClientInfo((int)dtgClient.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmClientsList_Load(null, null);
        }

        private void showFindClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFindClient frm = new frmFindClient();
            frm.ShowDialog();
            frmClientsList_Load(null,null);
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool IsCbFilterNone = cbFilter.Text == "None" ? true : false;
            if (IsCbFilterNone)
            {
                txtFilter.Visible = !IsCbFilterNone;
                cbIsActive.Visible = !IsCbFilterNone;
                return;
            }

            bool IsCbFilterActive = cbFilter.Text == "IsActive" ? true : false;
            txtFilter.Visible = !IsCbFilterActive;
            cbIsActive.Visible = IsCbFilterActive;

        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbIsActive.Text == "All")
            {
                _dtvClient.RowFilter = "";
                return;
            }
            byte IsActive = (Byte)(cbIsActive.Text == "Yes" ? 1 : 0);
            _dtvClient.RowFilter = $"{cbFilter.Text} = {IsActive}";
            dtgClient.DataSource = _dtvClient;

        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            _GetFilter();
        }

        private void allClientListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAllClientList frm = new frmAllClientList();
            frm.ShowDialog();
        }
    }
}
