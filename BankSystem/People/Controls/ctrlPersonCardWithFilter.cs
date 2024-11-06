using BankBussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem.People.Controls
{
    public partial class ctrlPersonCardWithFilter : UserControl
    {
        public ctrlPersonCardWithFilter()
        {
            InitializeComponent();
        }
        public event EventHandler <clsPersonInfo> OnPersonSelected;
        public void OnPersonSelect(clsPerson PersonInfo)
        {
            OnPersonSelect(new clsPersonInfo(PersonInfo));
        }

        protected virtual void OnPersonSelect(clsPersonInfo e)
        {
            OnPersonSelected?.Invoke(this, e);
        }

        public class clsPersonInfo:EventArgs
        {
            public clsPerson PersonInfo;
          public clsPersonInfo(clsPerson PersonInfo)
            {
                this.PersonInfo = PersonInfo;
            }
        }
        public clsPerson PersonInfo
        {
            get
            {
                return ctrlPersonInfo1.SelectPersonInfo;
            }
        }
        private bool _FilterEnabled = true;
        public bool FilterEnabled
        {
            get
            {
                return _FilterEnabled;
            }
            set
            {
                _FilterEnabled = value;
                gbFilter.Enabled = _FilterEnabled;
            }
        }
        public void LoadPersonInfo(int PersonID)
        {
            cbFilter.SelectedIndex = 1;
            txtSearch.Text = PersonID.ToString().Trim();
            FindNow();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        
        private void FindNow()
        {
            switch (cbFilter.Text)
            {
                case "PersonID":
                    ctrlPersonInfo1.LoadDataByPersonID(int.Parse(txtSearch.Text));
                    break;
                case "NationalNo":
                    ctrlPersonInfo1.LoadDataByNationalNo(txtSearch.Text);
                    
                    //txtSearch.Text = "";
                    break;

                default:
                    break;
                    }
            if (FilterEnabled&&OnPersonSelected != null)
            {
                OnPersonSelect(PersonInfo);
            }
               
        }

        private void ctrlPersonCardWithFilter_Load(object sender, EventArgs e)
        {
            cbFilter.SelectedIndex = 0;
        }

        private void Search(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("there is some Fields are still not complete!"
                    ,"Search  about Person Info",
                    MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            if (txtSearch.Text == "")
                return;

            FindNow();
        }

        private void txtSearch_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                e.Cancel = true;
                txtSearch.Focus();
                errorProvider1.SetError(txtSearch, "this fild is requied");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtSearch,null);
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.Text=="PersonID")
            {
                e.Handled = (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar));

                if (e.KeyChar == (char)13)
                {
                    btnSearch.PerformClick();
                    int ID = int.Parse(txtSearch.Text);
                    txtSearch.Text = "".Trim();
                    txtSearch.Text = ID.ToString();
                }
            }
            
        }
        public void FilterFocuse()
        {
            txtSearch.Focus();
        }
        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Text = "".Trim();
            //txtSearch.Focus();
        }
        public int PersonID
        {
            get
            {
                return ctrlPersonInfo1.PersonID;
            }
            
        }
        private void GetNewPeresonID(object sender,int PersonID)
        {
            cbFilter.SelectedIndex = 1;
            txtSearch.Text = PersonID.ToString();
            ctrlPersonInfo1.LoadDataByPersonID(PersonID);
            
        }
        private void AddPerson(object sender, EventArgs e)
        {
            frmAddPerson frm = new frmAddPerson();
            frm._DataBack += GetNewPeresonID;
            frm.ShowDialog();
        }

        private void ctrlPersonInfo1_Load(object sender, EventArgs e)
        {

        }
    }
}
