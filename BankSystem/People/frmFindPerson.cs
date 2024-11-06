using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem.People
{
    public partial class frmFindPerson : Form
    {
        public frmFindPerson()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ctrlPersonCardWithFilter1_OnPersonSelected(object sender, Controls.ctrlPersonCardWithFilter.clsPersonInfo e)
        {
            int PersonID = ( e.PersonInfo==null?-1:e.PersonInfo.PersonID);
            MessageBox.Show("person ID : "+ PersonID);
        }
    }
}
