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

namespace BankSystem.People
{
    public partial class frmPeopleList : Form
    {
        public frmPeopleList()
        {
            InitializeComponent();
        }
        private DataView dtvAllPeople ;
        private int _PersonID;
        private void OnClickAddPerson(object sender, EventArgs e)
        {
            // MessageBox.Show("Un Implemented Yet",
            //"Transaction Screen"
            //, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            frmAddPerson frm = new frmAddPerson();
            frm.ShowDialog();
            frmPeopleList_Load(null, null);
        }

       
        private void frmPeopleList_Load(object sender, EventArgs e)
        {
            cbFilter.SelectedIndex = 0;
            txtFilter.Visible = false;
            dtvAllPeople = clsPerson.GetAllPeople().DefaultView;
            dtgPeople.DataSource = dtvAllPeople;
            lbRecord.Text = dtgPeople.RowCount.ToString();

            

        }
        private void _GetFilter()
        {
            string FilterColumn = "";
            switch (cbFilter.Text)
            {
                case "PersonID":
                    FilterColumn = "PersonID";
                    break;
                case "NationalNo":
                    FilterColumn = "NationalNo";
                    break;
                case "Country":
                    FilterColumn = "Country";
                    break;
            }
            if (txtFilter.Text =="".Trim()||cbFilter.Text =="None")
            {
                dtvAllPeople.RowFilter = "";
                return;
            }
            if (FilterColumn!= "CountryName" && FilterColumn!="NationalNo")
            {
                dtvAllPeople.RowFilter = $"{FilterColumn} = {txtFilter.Text}";
                dtgPeople.DataSource = dtvAllPeople;
                return;
            }
            dtvAllPeople.RowFilter = $"{FilterColumn} Like '"+ txtFilter.Text + "%'"; 
            dtgPeople.DataSource = dtvAllPeople;

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            _PersonID = (int)dtgPeople.CurrentRow.Cells[0].Value;

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
//            _PersonID = (int)dtgPeople.CurrentRow.Cells[0].Value;
            frmAddPerson frm = new frmAddPerson(_PersonID);
            frm.ShowDialog();
            frmPeopleList_Load(null, null);

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure delete this Person? ",
                "Person Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.No)
                return;

            if (clsPerson.Delete((int)dtgPeople.CurrentRow.Cells[0].Value))
                MessageBox.Show("Deleted Successfully");
            else
                MessageBox.Show("error: this Person linked with Another Table"
                    ,"Delete Person",MessageBoxButtons.OK,MessageBoxIcon.Error);
            frmPeopleList_Load(null, null);
        
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmAddPerson frm = new frmAddPerson();
            frm.ShowDialog();
            frmPeopleList_Load(null, null);

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

            frmShowPersonInfo frm = new frmShowPersonInfo(_PersonID);
            frm.ShowDialog();
            frmPeopleList_Load(null, null);
        }
          
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            _GetFilter();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilter.Visible = (cbFilter.Text=="None"?false:true);
        }
    }
}
