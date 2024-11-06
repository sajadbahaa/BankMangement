using BankBussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem.Clients.Controls
{
    public partial class ctrlClientInfoWithFilter : UserControl
    {
        public event EventHandler<GetClientInfo> OnClientInfoSelect;
        public void OnClientInfoSelected(clsBankClient ClientInfo)
        {
            OnClientInfoSelected(new GetClientInfo(ClientInfo));
        }
        protected virtual void OnClientInfoSelected(GetClientInfo e)
        {
            OnClientInfoSelect?.Invoke(this, e);
        }
      
        public  class GetClientInfo:EventArgs
        {
            public clsBankClient ClientInfo { get; set; }
            public GetClientInfo(clsBankClient ClientInfo)
            {
                this.ClientInfo = ClientInfo;
            }
        }
        private bool _FilterEnable = true;
        public bool FilterEnabled
        {
            get
            {
                return _FilterEnable;
            }
            set
            {
                _FilterEnable = value;
                gbFilter.Enabled = _FilterEnable;
            }
        }
        public void DisableAddClient()
        {
            btnAdd.Enabled = false;
        }
        public clsBankClient ClientBankSelected
        {
            get
            {
                return ctrlClientInfo1.ClientSelected;
            }
        }
        public ctrlClientInfoWithFilter()
        {
            InitializeComponent();
        }
        public void FilterFocuse()
        {
            txtSearch.Focus();
        }
        private void FindNow()
        {
            switch (cbFilter.Text)
            {
                case "AccountNumber":
                    ctrlClientInfo1.LoadClientDataByAccountNumber(txtSearch.Text.Trim());
                    break;
                case "ClientID":
                    ctrlClientInfo1.LoadClientDataByClientID(int.Parse(txtSearch.Text));
                    break;
            }

            if (FilterEnabled&&OnClientInfoSelect!=null)
            {
                OnClientInfoSelected(ctrlClientInfo1.ClientSelected);
            }
        }
     public clsBankClient ClientSelected
        {
            get
            {
                return ctrlClientInfo1.ClientSelected;
            }
        }
        private void ctrlClientInfoWithFilter_Load(object sender, EventArgs e)
        {
            cbFilter.SelectedIndex = 0;
            txtSearch.Focus();
        }
        public clsPerson PersonInfo
        {
            get
            {
                return ctrlClientInfo1.PersonInfo;
            }
        }
        public void LoadClientInfo(int ClientID)
        {
            ctrlClientInfo1.LoadClientDataByClientID(ClientID);
            cbFilter.SelectedIndex = 1;
            txtSearch.Text = ClientID.ToString().Trim();
            FilterEnabled = false;
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.Text=="ClientID")
            {
                e.Handled = (!char.IsControl(e.KeyChar)&&!char.IsDigit(e.KeyChar));
            }
            if (e.KeyChar==(char)13)
            {
                btnSearch.PerformClick();
                int ID = int.Parse(txtSearch.Text);
                txtSearch.Text = "".Trim();
                txtSearch.Text = ID.ToString();
            }
        }
        
        private void AddClient(object sender, EventArgs e)
        {
            frmAddClient frm = new frmAddClient();
            frm._DataBack += GetNewClient;
            frm.ShowDialog();
        }
        public void GetNewClient(object sender,int ClientID)
        {
            cbFilter.SelectedIndex = 1;
            txtSearch.Text = ClientID.ToString();
            FindNow();
        }

        private void txtSearch_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                e.Cancel = true;
                txtSearch.Focus();
                errorProvider1.SetError(txtSearch,"this field is Required");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtSearch, null);

            }
        }
        
        private void Search(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some field is still not completed");
                return;
            }
            if (txtSearch.Text == "")
                return;

            FindNow();
        }
    }
}
