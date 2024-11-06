using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem.TransActions.ShareScreen
{
    public partial class frmShareScreen : Form
    {
        public frmShareScreen(string Label)
        {
            InitializeComponent();    
            lbTitle.Text = Label;
        }

        private void frmShareScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
