using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem.MessgaeDenieAccess
{
    public partial class frmDenieAccress : Form
    {
        public frmDenieAccress()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Close(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDenieAccress_Load(object sender, EventArgs e)
        {
            MessageBox.Show("you dont have permission to access",
                "Denie Access",
                MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
    }
}
