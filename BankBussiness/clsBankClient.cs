using BankData;
using clsPeople;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BankBussiness
{
    public class clsBankClient
    {
       public int ClientID { get; set; } 
       public int PersonID{ get; set; }
       public string AccountNumber { get; set; }
       public string PinCode { get; set; }
       public int Balance { get; set; }
       public int CreatedByUserID { get; set; }
       public bool IsActive { get; set; }
        public DateTime CreateDate { get; set; }
        public clsPerson PersonInfo;
        public clsUser UserInfo;
       
        public enum enTransaction { Depoist = 1,WithDraw =2}
public enum enMode { add = 1,update =2};
        private enMode _Mode = enMode.add;
        public clsBankClient()
        {
            ClientID = -1;
            PersonID = -1;
            CreatedByUserID = -1;
            AccountNumber = "";
            PinCode = "";
            Balance = 0;
            CreateDate = DateTime.Now;
            IsActive = true;
            _Mode = enMode.add;
        }
        private clsBankClient(int ClientID, int PersonID, int CreatedByUserID,
        string AccountNumber, string PinCode, 
        int Balance, DateTime CreateDate,bool IsActive)
        {
            this.ClientID = ClientID;
            this.PersonID = PersonID;
            this.Balance = Balance;
            this.CreatedByUserID = CreatedByUserID;
            this.AccountNumber = AccountNumber;
            this.CreateDate = CreateDate;
            this.PinCode = PinCode;
            this.IsActive = IsActive;
            this.PersonInfo = clsPerson.FindByPersonID(PersonID);
            this.UserInfo = clsUser.FindByUserID(CreatedByUserID);
            _Mode = enMode.update;
        }

        static public clsBankClient FindByClientID(int clientID)
        {
            string AccountNumber = "";
            string PinCode = "";
            int balance = 0,  PersonID = -1, UserID = -1;
            DateTime dt = DateTime.Now;
            bool IsActive = false; 
            bool IsFind = dtClient.Find(clientID, ref PersonID,ref AccountNumber, ref PinCode, ref balance, ref UserID, ref dt,ref IsActive);
            if (IsFind)
                return new clsBankClient(clientID, PersonID, UserID, AccountNumber, PinCode, balance, dt,IsActive);
            else
                return null;
        }
        static public clsBankClient FindByAccountNumber(string AccountNumber)
        {
            string PinCode = "";
            int balance = 0, clientID = -1,PersonID =-1,UserID=-1;
            DateTime dt = DateTime.Now;
            bool IsActive = false;

            bool IsFind = dtClient.Find(ref clientID, ref PersonID,  AccountNumber, ref PinCode, ref balance, ref UserID, ref dt, ref IsActive);
            if (IsFind)
                return new clsBankClient(clientID, PersonID, UserID, AccountNumber, PinCode, balance, dt,IsActive);
            else
                return null;
        }
    static public clsBankClient FindByAccountNumberAndPinCode(string AccountNumber, string PinCode)
        {
            int balance = 0, clientID = -1, PersonID = -1, UserID = -1;
            DateTime dt = DateTime.Now;
            bool IsActive = false;

            bool IsFind = dtClient.Find(ref clientID, ref PersonID, AccountNumber, PinCode, ref balance, ref UserID, ref dt,ref IsActive);
            if (IsFind)
                return new clsBankClient(clientID, PersonID, UserID, AccountNumber,
                    PinCode, balance, dt,IsActive);
            else
                return null;
        }
    private bool _Add()
        {
            this.ClientID = dtClient.Add(this.PersonID, this.AccountNumber,
                this.PinCode, this.Balance, this.CreatedByUserID,
                this.CreateDate,this.IsActive);
            return this.ClientID > -1;
        }
    private bool _Update()
        {
            return (dtClient.Update(this.ClientID,this.PersonID,
                this.PinCode,this.Balance,this.CreatedByUserID,
                this.CreateDate,this.IsActive));
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
                case enMode.update:
                    return _Update();
            }
            return false;
        }
   public static bool IsExist(string AccountNumber)
        {
            return dtClient.Exist(AccountNumber);
        }
   public static int GetTotalBalance()
        {
            return (dtClient.GetTotalBalance());
        }
        public static bool IsPersonIDUsed(int PersonID)
        {
            return (clsBankClient.GetClientID(PersonID)!=-1);
        }
        
        public static DataTable GetAllClients()
        {
        return dtClient.GetAllClients();
        }
        public static int GetClientID(int PersonID)
        {
            return dtClient.GetClientID(PersonID);
        } 
   public static bool Delete(int ClientID)
        {
            // we need to check if this client did transfer or not
            if (!clsTransfer.IsExist(ClientID))
            {
                return dtClient.Delete(ClientID);
            }
            int UserID = dtTransfer.GetUserID(ClientID);
            if (!clsTransfer.Delete(UserID))
            {
                return false;
            }
            return dtClient.Delete(ClientID);

        }


        public bool Depoist(int Amount)
        {
            this.Balance += Amount;

            return UpdateBalance(this.Balance);
        }
        public bool WithDraw(int Amount)
        {
            if (Amount>this.Balance)
            {
                return false;
            }
            if (this.Balance==0)
            {
                return false;
            }
            this.Balance -= Amount;
            return UpdateBalance(this.Balance);
        }

        private bool UpdateBalance(int Balance)
        {
            this.Balance = Balance;
            return (dtClient.UpdateBalance(this.ClientID,this.Balance));
            
        }
    }
    
}

