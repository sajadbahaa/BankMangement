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
    public partial class frmShowPersonInfo : Form
    {
        public frmShowPersonInfo(int PersonID)
        {
            InitializeComponent();
            ctrlPersonInfo1.LoadDataByPersonID(PersonID);
        }
        public frmShowPersonInfo(string NationalNo)
        {
            InitializeComponent();
            ctrlPersonInfo1.LoadDataByNationalNo(NationalNo);
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoadData(object sender, EventArgs e)
        {

        }
    }
}
