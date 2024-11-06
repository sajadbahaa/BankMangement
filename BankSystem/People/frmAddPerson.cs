using BankBussiness;
using BankSystem.GlobalClasses;
using BankSystem.Properties;
using clsPeople;
using Vaildation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem.People
{

    public partial class frmAddPerson : Form
    {

    enum enMode { add = 1,update= 2}
        private enMode _Mode = enMode.add;
  enum enGendor {male =0,female =1}
        private clsPerson PersonInfo;
        private int _PersonID = -1;
        public delegate void HandelDataBack(object sender, int PersonID);
        public HandelDataBack _DataBack;
        public frmAddPerson()
        {
            InitializeComponent();
            _Mode = enMode.add;
        }
        public frmAddPerson(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
            _Mode = enMode.update;
        }


        private void txtFullName_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txtFullName.Text))
            {
                e.Cancel = true;
                txtFullName.Focus();
                errorProvider1.SetError(txtFullName,"this Field is Required");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtFullName, null);
            }
            //handel prevent user enter numbers
            if (clsVaildation.IsNumber(txtFullName.Text))
            {
                e.Cancel = true;
                txtFullName.Focus();
                errorProvider1.SetError(txtFullName, "Wrong this field should not put numbers");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtFullName,null);

            }
        }

        private void txtNationalNo_Validating(object sender, CancelEventArgs e)
        {
            if (txtNationalNo.Text!=PersonInfo.NationalNo &&
                clsPerson.IsNationalNoExist(txtNationalNo.Text))
            {
                e.Cancel = true;
                txtNationalNo.Focus();
                errorProvider1.SetError(txtNationalNo, "this Nationa No Used By Another Person");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtNationalNo, null);
            }
            if (string.IsNullOrEmpty(txtNationalNo.Text))
            {
                e.Cancel = true;
                txtNationalNo.Focus();
                errorProvider1.SetError(txtNationalNo,"this Field is Required");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtNationalNo, null);

            }
            if (clsVaildation.IsNumber(txtNationalNo.Text))
            {
                e.Cancel = true;
                txtNationalNo.Focus();
                errorProvider1.SetError(txtNationalNo, "you should not enter numbers");
                return;

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtNationalNo, null);
            }

            



        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPhone.Text))
            {
                e.Cancel = true;
                txtPhone.Focus();
                errorProvider1.SetError(txtPhone, "this Field is Required");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPhone, null);

            }
            // handel txtPhone must be numbers
            if (!clsVaildation.IsNumber(txtPhone.Text))
            {
                e.Cancel = true;
                txtPhone.Focus();
                errorProvider1.SetError(txtPhone, "you must enter only Numbers");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPhone, null);

            }

        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (txtEmail.Text =="")
            {
                return;    
            }

            // handel Email Patteren
            if (!clsVaildation.VaildationEmail(txtEmail.Text))
            {
                e.Cancel = true;
                txtEmail.Focus();
                errorProvider1.SetError(txtEmail,"this Email not vail");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtEmail, null);

            }

        }

        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            //txtAddress
            if (string.IsNullOrEmpty(txtAddress.Text))
            {
                e.Cancel = true;
                txtAddress.Focus();
                errorProvider1.SetError(txtAddress, "this Field is Required");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtAddress, null);
            }
            // handel address should not enter numbers first.
            if (clsVaildation.IsNumber(txtAddress.Text))
            {
                e.Cancel = true;
                txtAddress.Focus();
                errorProvider1.SetError(txtAddress, "you should not enter numbers");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtAddress, null);
            }
        }

        private void _FillComboBoxCountries()
        {
            DataTable dt = clsCountries.GetAllCountries();
            foreach (DataRow row in dt.Rows)
            {
                cbCountry.Items.Add(row["CountryName"]);
            }
        }
        private void _FillDefaultValue()
        {
            _FillComboBoxCountries();
            if (_Mode == enMode.add)
            {
                lbMode.Text = "Add Person";
                lbPersonID.Text = "[????]";
                dt.MaxDate = DateTime.Now.AddYears(-18);
                dt.MinDate = DateTime.Now.AddYears(-100);
                dt.Value = dt.MaxDate;
                cbCountry.SelectedIndex = cbCountry.FindString("Iraq");
                lRemove.Visible = false;
                PersonInfo = new clsPerson();
                return;
            }
            else
                lbMode.Text = "Update Person";

        }
        private bool _HandelImage()
        {
            if (PersonInfo.ImagePath != pbImage.ImageLocation)
            {
                if (PersonInfo.ImagePath != null)
                {
                    File.Delete(PersonInfo.ImagePath);
                }

                if (pbImage.ImageLocation != null)
                {
                    string ImagePath = pbImage.ImageLocation.ToString();

                    if (clsUtil.CopyImageToProjectFolder(ref ImagePath))
                    {
                        pbImage.ImageLocation = ImagePath;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show(" Creating Image failed");
                        return false;
                    }

                }
                else
                    return true;
               }
            return true;
        }
        private void _LoadData()
        {
            PersonInfo = clsPerson.FindByPersonID(_PersonID);
            if (PersonInfo == null)
            {
MessageBox.Show("this Person ID not Found","Load Data",MessageBoxButtons.OK,
   MessageBoxIcon.Error);
                return;
            }
            txtAddress.Text = PersonInfo.Address.Trim();
            txtEmail.Text = PersonInfo.Email;
            txtFullName.Text = PersonInfo.Name;
            txtPhone.Text = PersonInfo.Phone;
            txtNationalNo.Text = PersonInfo.NationalNo;
            dt.Value = PersonInfo.Birth;
            cbCountry.SelectedIndex =
                    cbCountry.FindString(PersonInfo.CountryName);
            if (PersonInfo.ImagePath != null)
                pbImage.ImageLocation = PersonInfo.ImagePath;

            lRemove.Visible = pbImage.ImageLocation !=null;
            
            lbPersonID.Text = PersonInfo.PersonID.ToString();
        
            if (PersonInfo.Gendor == (Byte)enGendor.male)
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;
        
        }
        private void LoadDataForm(object sender, EventArgs e)
        {
            _FillDefaultValue();
            if (_Mode == enMode.update)
                _LoadData();

        }

        private void rbMale_Click(object sender, EventArgs e)
        {
            pbImage.Image = Resources.man;
        }

        private void txtNationalNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rbFemale_Click(object sender, EventArgs e)
        {
            pbImage.Image = Resources.girl;
        }

        private void SaveImage(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp;";
            openFileDialog1.RestoreDirectory = true;
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                string FileName = openFileDialog1.FileName;
                pbImage.ImageLocation = FileName;
                lRemove.Visible = true;
            }

        }

        private void Close(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Save(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some Fiels are still Empty");
                return;
            }

            // handel Image
            if (!_HandelImage())
                return;

            int CountryID = clsCountries.FindByCountryName(cbCountry.Text).CountryID;
            PersonInfo.Name = txtFullName.Text;
            PersonInfo.NationalNo = txtNationalNo.Text;
            PersonInfo.Email = txtEmail.Text;
            PersonInfo.Nationality = CountryID;
            PersonInfo.Birth = dt.Value;
            PersonInfo.Phone = txtPhone.Text;
            PersonInfo.Address = txtAddress.Text;
            if (rbMale.Checked)
                PersonInfo.Gendor = (Byte)enGendor.male;
            else
                PersonInfo.Gendor = (Byte)enGendor.female;
            
            if(pbImage.ImageLocation!=null)
            PersonInfo.ImagePath = pbImage.ImageLocation;


            if (!PersonInfo.Save())
            {
                MessageBox.Show("Failed Saving Data",
                    "Add Person",MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Saved Successfully");
            lbPersonID.Text = PersonInfo.PersonID.ToString();
            _DataBack?.Invoke(this, PersonInfo.PersonID);
            _Mode = enMode.update;
            lbMode.Text = "Update Person";
            btnSave.Enabled = false;
        }

        private void lRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbImage.ImageLocation = null;
            if (rbMale.Checked)
                pbImage.Image = Resources.man;
            else
                pbImage.Image = Resources.girl;
            lRemove.Visible = false;
                }
    }
}
