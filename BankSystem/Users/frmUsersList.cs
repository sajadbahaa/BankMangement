using BankSystem.People;
using BankSystem.Users.ChangePassword;
using clsPeople;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BankSystem.Users
{
    public partial class frmUsersList : Form
    {
        public frmUsersList()
        {
            InitializeComponent();
        }
        private DataView dtvAllUsers;
        private void LoadData(object sender, EventArgs e)
        {
            cbFilter.SelectedIndex = 0;
            cbIsActive.Visible = false;
            txtFilter.Visible = false;
            dtvAllUsers = clsUser.GetAllUsers().DefaultView;
            dtgUsers.DataSource = dtvAllUsers;
            lbRecord.Text = dtgUsers.RowCount.ToString();

        }

        private void AddUser(object sender, EventArgs e)
        {
            frmAddUser frm = new frmAddUser();
            frm.ShowDialog();
            LoadData(null, null);
        }

        private void editUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUser frm = new frmAddUser((int)dtgUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            LoadData(null,null);
        }

        private void showPersonInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowPersonInfo frm = new frmShowPersonInfo((int)dtgUsers.CurrentRow.Cells[1].Value);
            frm.ShowDialog();
            LoadData(null, null);
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUser frm = new frmAddUser();
            frm.ShowDialog();
            LoadData(null, null);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure","Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Question)
                ==DialogResult.No)
            {
                return;
            }

            if (clsUser.Delete((int)dtgUsers.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("Deleted Successfully");
                LoadData(null,null);
            }
            else
            {
                MessageBox.Show("this User ID linked with anther Table");
                return;
            }
        }

        private void showUserDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowUserInfo frm = new frmShowUserInfo((int)dtgUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            LoadData(null, null);
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool IsCbFilterNone = cbFilter.Text == "None" ? true : false;
            if (IsCbFilterNone)
            {
                txtFilter.Visible = !IsCbFilterNone;
                cbIsActive.Visible = !IsCbFilterNone;
                return;
            }

            bool IsCbFilterActive = cbFilter.Text == "IsActive" ? true : false;
            txtFilter.Visible = !IsCbFilterActive;
            cbIsActive.Visible = IsCbFilterActive;
        }
 private void _GetFilter()
        {
            //            None
            //UserID
            //PersonID
            //FullName
            //Username
            //IsActive
            string FilterColumn = "";
            switch (cbFilter.Text)
            {
                case "None":
                    FilterColumn = "None";
                    break;
                case "UserID":
                    FilterColumn = "UserID";
                    break;
                case "PersonID":
                    FilterColumn = "PersonID";
                    break;
                case "FullName":
                    FilterColumn = "FullName";
                    break;
                case "Username":
                    FilterColumn = "Username";
                    break;
                case "IsActive":
                    FilterColumn = "IsActive";
                    break;
            }
            if (txtFilter.Text=="".Trim()||FilterColumn=="None")
            {
                dtvAllUsers.RowFilter = "";
                return;
            }
            if (FilterColumn!="FullName"&&FilterColumn!="Username")
            {
                dtvAllUsers.RowFilter = $"{FilterColumn} = {txtFilter.Text}";
            }
            else
            {
                dtvAllUsers.RowFilter = $"{FilterColumn} Like '"+ txtFilter.Text +"%'";
            }
            dtgUsers.DataSource = dtvAllUsers;



        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            _GetFilter();
        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbIsActive.Text=="All")
            {
                dtvAllUsers.RowFilter = "";
                return;
            }
            byte IsActive = (Byte)(cbIsActive.Text=="Yes"?1:0);
            dtvAllUsers.RowFilter = $"{cbFilter.Text} = {IsActive}";
            dtgUsers.DataSource = dtvAllUsers;
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void showChangePassword(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword((int)dtgUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            LoadData(null, null);
        }
    }
}
