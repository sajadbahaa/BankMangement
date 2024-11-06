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

namespace BankSystem.Clients.Controls
{
    public partial class ctrlClientList : UserControl
    {
        public ctrlClientList()
        {
            InitializeComponent();
        }
        private DataView dtvClientList;
        public void LoadAllClientList()
        {
            dtvClientList = clsBankClient.GetAllClients().DefaultView;
            dtgClientList.DataSource = dtvClientList;
            lbTotalBalance.Text = clsBankClient.GetTotalBalance()+"$".ToString();
        }
        private void ctrlClientList_Load(object sender, EventArgs e)
        {

        }
    }
}
