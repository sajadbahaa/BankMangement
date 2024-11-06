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

namespace BankSystem.Transfer
{
    public partial class frmAllTransfer : Form
    {
        public frmAllTransfer()
        {
            InitializeComponent();
        }
        //private DataView _dtview;
        private DataTable dtAllTransfer;
        private void frmAllTransfer_Load(object sender, EventArgs e)
        {
            dtAllTransfer = clsTransfer.GetAllTransfers();
            dtgview.DataSource = dtAllTransfer;
            lbRecord.Text = dtgview.RowCount.ToString();
            if (dtgview.RowCount>0)
            {
                dtgview.Columns[0].Width = 150;
                dtgview.Columns[1].Width = 100;
                dtgview.Columns[2].Width = 100;
                dtgview.Columns[3].Width = 100;
                dtgview.Columns[4].Width = 100;
                dtgview.Columns[5].Width = 100;
                dtgview.Columns[6].Width = 250;

            }
        }

        private void addTransferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTransferScreen frm = new frmTransferScreen();
            frm.ShowDialog();

        }

        private void Close(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
