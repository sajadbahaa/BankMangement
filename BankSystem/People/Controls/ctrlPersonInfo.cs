using BankBussiness;
using BankSystem.GlobalClasses;
using BankSystem.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem.People.Controls
{
    public partial class ctrlPersonInfo : UserControl
    {
        private int _PersonID = -1;
        public int PersonID
        {
            get
            {
                return _PersonID;
            }
        }
        private clsPerson _PersonInfo;
        public clsPerson SelectPersonInfo
        {
            get
            {
                return _PersonInfo;
            }
        }
       public void _ResetDefaultData()
        {
            _PersonID = -1;
            llEditPerson.Enabled = false;
            lbAddress.Text = "[????]";
            lbBirth.Text = "[????]";
            lbEmail.Text   = "[????]";
            lbGendor.Text  = "[????]";
            lbName.Text    = "[????]";
        lbNationality.Text = "[????]";
        lbNationalNo.Text  = "[????]";
        lbPersonID.Text    = "[????]";
        lbPhone.Text       = "[????]";

            _HandelImage();
        }
        public void LoadDataByPersonID(int PersonID)
        {
            _PersonInfo = clsPerson.FindByPersonID(PersonID);
            if (_PersonInfo==null)
            {
                _ResetDefaultData();
                MessageBox.Show("this Person ID not found");
                return;
            }
            _LoadData();
        }
        public void LoadDataByNationalNo(string NationalNo)
        {
            _PersonInfo = clsPerson.FindByNationalNo(NationalNo);
            if (_PersonInfo == null)
            {
                _ResetDefaultData();
               
                MessageBox.Show("this Person ID not found");
                return;
            }
            
            _LoadData();
        }

        private void _HandelImage()
        {
            if (_PersonInfo== null)
            {
                pbImage.Image = Resources.UnKnownPerson;
                return;
            }

            if (_PersonInfo.ImagePath!=null)
                try
                {
                    if (File.Exists(_PersonInfo.ImagePath))
                    {
                        pbImage.ImageLocation = _PersonInfo.ImagePath;
           
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message + "this Image not Found");
                    return;
                }
            else
                pbImage.Image = (_PersonInfo.Gendor==0?Resources.man:Resources.girl);
           

            
        }
        private void _LoadData()
        {
            llEditPerson.Enabled = true;
            _PersonID = _PersonInfo.PersonID;
            lbAddress.Text = _PersonInfo.Address;
            lbBirth.Text = clsFormat.DateToString(_PersonInfo.Birth);
            lbEmail.Text = _PersonInfo.Email;
            lbGendor.Text = (_PersonInfo.Gendor==0?"Male":"Female");
            lbName.Text = _PersonInfo.Name;
            lbNationality.Text = _PersonInfo.CountryName;
            lbNationalNo.Text = _PersonInfo.NationalNo;
            lbPersonID.Text = _PersonInfo.PersonID.ToString();
            lbPhone.Text = _PersonInfo.Phone;
            _HandelImage();
        }
        public ctrlPersonInfo()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ctrlPersonInfo_Load(object sender, EventArgs e)
        {
        }

        private void llEditPerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddPerson frm = new frmAddPerson(_PersonID);
            frm.ShowDialog();
            LoadDataByPersonID(_PersonID);
        }
    }
}
