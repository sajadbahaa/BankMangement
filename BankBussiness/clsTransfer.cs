using BankData;
using clsPeople;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace BankBussiness
{
    public class clsTransfer
    {
    private int TransferID { get; set; }
    public int Client1ID { get; set; }
    public int Client2ID { get; set; }
    public int BalanceAccountClient1BeforTransfer { get; set; }
    public int BalanceAccountClient1AfterTransfer { get; set; }
    public int BalanceAccountClient2AfterTransfer { get; set; }
    public int UserID { get; set; }
    public clsBankClient ClientInfo1 { get; set; }
    public clsBankClient ClientInfo2 { get; set; }
    public clsUser UserInfoTranfer { get; set; }
    public DateTime TransferDate { get; set;}

    private enum enMode { add = 1,update =2}
    
        private enMode _Mode;

        public clsTransfer()
        {
            TransferID = -1;
            Client1ID = -1;
            Client2ID = -1;
            BalanceAccountClient1AfterTransfer = 0;
            BalanceAccountClient2AfterTransfer = 0;
            BalanceAccountClient1BeforTransfer = 0;
            UserID = -1;
            TransferDate = DateTime.Now;
            _Mode = enMode.add;
        }
    private clsTransfer(int TransferID,int Client1ID,int Client2ID,
        int BalanceAccountClient1AfterTransfer,
        int BalanceAccountClient2AfterTransfer,
        int BalanceAccountClient1BeforTransfer,
        int UserID,DateTime TransferDate)
        {
            this.TransferID = TransferID;
            this.Client1ID = Client1ID;
            this.Client2ID = Client2ID;
            this.BalanceAccountClient1BeforTransfer = BalanceAccountClient1BeforTransfer;
            this.BalanceAccountClient1AfterTransfer = BalanceAccountClient1AfterTransfer;
            this.BalanceAccountClient2AfterTransfer = BalanceAccountClient2AfterTransfer;
            this.UserID = UserID;
            this.ClientInfo1 = clsBankClient.FindByClientID(Client1ID);
            this.ClientInfo2 = clsBankClient.FindByClientID(Client2ID);
            this.UserInfoTranfer = clsUser.FindByUserID(UserID);
            this.TransferDate = TransferDate;
            //_Mode = enMode.update;        
        }
        private bool _Add()
        {
            this.TransferID =
            dtTransfer.Add(this.Client1ID, this.Client2ID, this.BalanceAccountClient1BeforTransfer,
            this.BalanceAccountClient1AfterTransfer, this.BalanceAccountClient2AfterTransfer,
            this.TransferDate, this.UserID);
            return (this.TransferID>-1);
        }
        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.add:
                    if (_Add())
                    {
                        _Mode = enMode.update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
            }
            return false;

        }
        public static bool IsExist(int ClientID)
        {
            return (GetUserID(ClientID)!=-1);
        }
        public static bool Delete(int UserID)
        {
            return (dtTransfer.Delete(UserID));
        }
        public static int GetUserID(int ClientID)
        {
            return (dtTransfer.GetUserID(ClientID));
        }
        static public bool Transfer(ref int TransferID,int BalanceClientInfo1, ref clsBankClient ClientInfo1, ref clsBankClient ClientInfo2,int Amount,int UserID)
        {
            
            // we do With draw with Client info 1

            if (!ClientInfo1.WithDraw(Amount))
            {
                return false;
            }
            // we do Depoist with Client info 2
            if (!ClientInfo2.Depoist(Amount))
            {
                return false;
            }

            // we create object of transfer

            clsTransfer TransferInfo = new clsTransfer();
            // we got balance for Client info 1 before transfer.
            TransferInfo.BalanceAccountClient1BeforTransfer
 = BalanceClientInfo1;
            TransferInfo.Client1ID = ClientInfo1.ClientID;
            TransferInfo.Client2ID = ClientInfo2.ClientID;

            // we got on Balance Account Client 1 after Transfer

            TransferInfo.BalanceAccountClient1AfterTransfer = ClientInfo1.Balance;
            // we got on Balance Account Client 2 after Transfer

            TransferInfo.BalanceAccountClient2AfterTransfer = ClientInfo2.Balance;
            TransferInfo.UserID = UserID;
            TransferInfo.TransferDate = DateTime.Now;
            if (!TransferInfo.Save())
            {
                return false;
            }
            TransferID = TransferInfo.TransferID;
            return true;
        }
    public static DataTable GetAllTransferHisoryByUserID(int UserID)
        {
            return (dtTransfer.AllTransfersByUserID(UserID));
        }
    public static DataTable GetAllTransfers()
        {
            return (dtTransfer.AllTransfers());
        }
    }
}
