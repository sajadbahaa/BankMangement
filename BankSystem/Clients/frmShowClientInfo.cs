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
    public partial class frmShowClientInfo : Form
    {
        public frmShowClientInfo(int ClientID)
        {
            InitializeComponent();
            ctrlClientInfo1.LoadClientDataByClientID(ClientID);
        }

        private void frmShowClientInfo_Load(object sender, EventArgs e)
        {

        }

        private void Close(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
