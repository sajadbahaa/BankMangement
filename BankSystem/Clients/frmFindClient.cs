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
    public partial class frmFindClient : Form
    {
        public frmFindClient()
        {
            InitializeComponent();
        }

        private void ctrlClientInfoWithFilter1_OnClientInfoSelect(object sender, Controls.ctrlClientInfoWithFilter.GetClientInfo e)
        {
            bool IsObjectNull = (e.ClientInfo==null?true:false);

            if (!IsObjectNull)
                MessageBox.Show(e.ClientInfo.PersonInfo.Name);
        }

        private void Close(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
