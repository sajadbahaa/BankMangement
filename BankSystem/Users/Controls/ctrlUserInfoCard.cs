using clsPeople;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem.Users.Controls
{
    public partial class ctrlUserInfoCard : UserControl
    {
        public ctrlUserInfoCard()
        {
            InitializeComponent();
        }
        private void _RestDefualtValue()
        {
            ctrlPersonInfo1._ResetDefaultData();
            lbUserID.Text = "[????]";
            lbUsername.Text = "[????]";
            lbIsActive.Text = "[????]";
        }
        public void LoadUserInfo(int UserID)
        {
            clsUser UserInfo = clsUser.FindByUserID(UserID);
            if (UserInfo==null)
            {
                MessageBox.Show("this User ID not found");
                return;
            }

            ctrlPersonInfo1.LoadDataByPersonID(UserInfo.PersonID);
            lbUserID.Text = UserInfo.UserID.ToString();
            lbUsername.Text = UserInfo.Username;
            lbIsActive.Text = (UserInfo.IsActive?"Is Active":"Not Active");
        }
        private void ctrlUserInfoCard_Load(object sender, EventArgs e)
        {

        }

        private void ctrlPersonInfo1_Load(object sender, EventArgs e)
        {

        }
    }
}
