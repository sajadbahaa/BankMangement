using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem.Users
{
    public partial class frmShowUserInfo : Form
    {
        public frmShowUserInfo(int UseID)
        {
            InitializeComponent();
            ctrlUserInfoCard1.LoadUserInfo(UseID);
        }

        private void Close(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
