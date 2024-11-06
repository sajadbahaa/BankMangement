using BankBussiness;
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

namespace BankSystem.Clients.Controls
{
    public partial class ctrlClientInfo : UserControl
    {
        private int _ClientID;
        public clsPerson PersonInfo
        {
            get
            {
                return _PersonInfo;
            }

        }
        private clsPerson _PersonInfo;
        public int ClientID
        {
            get
            {
                return _ClientID;
            }
        }
        private clsBankClient _ClientInfo;
        public clsBankClient ClientSelected
        {
            get
            {
                return _ClientInfo;
            }
        }

        public ctrlClientInfo()
        {
            InitializeComponent();
        }
        public void _RestDefaultValue()
        {

            lbAccNumber.Text = "[????]";
            lbBalance.Text  =  "[0000$]";
            lbClientID.Text =  "[????]";
            lbGendor.Text   =  "[????]";
            lbIsActive.Text =  "[????]";
            lbName.Text     =  "[????]";
            lbPinCode.Text  =  "[????]";
            lbUsername.Text =  "[????]";
            _HandelImage();
        }
        private void _LoadData()
        {
            _PersonInfo = _ClientInfo.PersonInfo;
            _ClientID = _ClientInfo.ClientID;

            lbAccNumber.Text = _ClientInfo.AccountNumber;
            lbBalance.Text = _ClientInfo.Balance.ToString();
            lbClientID.Text = _ClientInfo.ClientID.ToString();
    lbGendor.Text = (_ClientInfo.PersonInfo.Gendor==0?"Male":"Female");
            lbIsActive.Text = (_ClientInfo.IsActive?"Active":"Not Active");
            lbName.Text = _ClientInfo.PersonInfo.Name;
            lbPinCode.Text = _ClientInfo.PinCode;
            lbUsername.Text = _ClientInfo.UserInfo.Username;
            _HandelImage();
        }
        private void _HandelImage()
        {
            if (_ClientInfo==null)
            {
                pbImage.Image = Resources.UnKnownPerson;
                return;
            }
            if (_ClientInfo.PersonInfo.ImagePath==null)
            {
                pbImage.Image = (_ClientInfo.PersonInfo.Gendor==0?Resources.man:Resources.girl);
                return;
            }
            if (_ClientInfo.PersonInfo.ImagePath!=null)
            {
                string ImagePath = _ClientInfo.PersonInfo.ImagePath;
                try
                {
                    if (File.Exists(ImagePath))
                    {
                        pbImage.ImageLocation = ImagePath;
                        return;
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show("we could not find path image");
                    return; 
                }
            }
        }
        public void LoadClientDataByClientID(int ClientID)
        {
            _ClientInfo = clsBankClient.FindByClientID(ClientID);
            if (_ClientInfo==null)
            {
                MessageBox.Show("this ClientID not Found");
                _RestDefaultValue();
                return;
            }
            _LoadData();

        }
        public void LoadClientDataByAccountNumber(string AccountNumber)
        {
            _ClientInfo = clsBankClient.FindByAccountNumber(AccountNumber);
            if (_ClientInfo == null)
            {
                MessageBox.Show("this Account Number  not Found");
                _RestDefaultValue();
                return;
            }
            _LoadData();

        }
        private void lbNationalNo_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void llEditClient_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void ctrlClientInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
