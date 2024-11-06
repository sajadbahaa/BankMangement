using BankBussiness;
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

namespace BankSystem.Transfer
{
    public partial class ctrlShowHistory : UserControl
    {
        private int _UserID;
        public ctrlShowHistory()
        {
            InitializeComponent();
        }
        private DataView dtvHistory;
        private  void _LoadDataHisory()
        {
            dtvHistory = clsTransfer.GetAllTransferHisoryByUserID(_UserID).DefaultView;
            dtgview.DataSource = dtvHistory;
            lbRecord.Text = dtgview.RowCount.ToString();
        }
        public void LoadHistory(int UserID)
        {
            if (!clsUser.IsUserExist(UserID))
            {
                MessageBox.Show("this User ID not Found","Check",
                   MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            _UserID = UserID;
            _LoadDataHisory();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ctrlShowHistory_Load(object sender, EventArgs e)
        {

        }

        private void dtgview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
