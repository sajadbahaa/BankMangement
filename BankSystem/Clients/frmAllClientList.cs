using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem.Clients
{
    public partial class frmAllClientList : Form
    {
        public frmAllClientList()
        {
            InitializeComponent();
            ctrlClientList1.LoadAllClientList();
        }

        private void ctrlClientList1_Load(object sender, EventArgs e)
        {

        }

        private void Close(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmClientList_Load(object sender, EventArgs e)
        {

        }
    }
}
