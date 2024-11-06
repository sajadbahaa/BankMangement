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
    public partial class frmTransferHisory : Form
    {
        public frmTransferHisory(int UserID)
        {
            InitializeComponent();
            ctrlUserInfoCard1.LoadUserInfo(UserID);
            ctrlShowHistory1.LoadHistory(UserID);
        }

        private void frmTransferHisory_Load(object sender, EventArgs e)
        {

        }

        private void Close(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
