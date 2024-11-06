using BankBussiness;
using DvlcDataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace clsPeople
{
    public class clsUser
    { 
        
        public int UserID { get; set; }
        public int PersonID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public int Permission { get; set; }
        public clsPerson PersonInfo { get; set; }
        enum enMode { add = 1,update =2}
        private enMode _Mode;
        public clsUser()
        {
            UserID = -1;
            PersonID = -1;
            Username = "";
            Password = "";
            IsActive = false;
            Permission = -1;
            _Mode = enMode.add;
        }
        
    private clsUser(int UserID,int PersonID,string Username,
        string Password,bool IsActive, int Permission)
        {
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.Username = Username;
            this.Password = Password;
            this.IsActive = IsActive;
            this.PersonInfo = clsPerson.FindByPersonID(PersonID);
            this.Permission = Permission;
            _Mode = enMode.update;
        }
        
        public static clsUser FindByUsernameAndPassword(string Username,string  Password)
        {
            int UserID = -1,PersonID = -1;
            bool IsActive = false;
            int Permission = -1;
            if (dtUsers.Find(ref UserID, ref PersonID, Username, Password,
                ref IsActive,ref Permission))
            {
                return new clsUser(UserID,PersonID,Username,
                    Password,IsActive,Permission);
            }
            else
            {
                return null;
            }
        }
        static public bool IsUserExist(int UserID)
        {
            return (dtUsers.IsUserExist(UserID));
        }
        public bool IsUserActive()
        {
            return this.IsActive;
        }
        public static clsUser FindByUserID(int UserID)
        {
            int PersonID = -1;
            string Username = "", Password = "";
            bool IsActive = false;
            int Permission = -1;
            if (dtUsers.Find(UserID, ref PersonID,ref Username,ref  Password
                ,ref IsActive,ref Permission))
            {
                return new clsUser(UserID, PersonID, Username, Password,
                    IsActive,Permission);
            }
            else
            {

                return null;
            }
        }
        public static clsUser FindByPersonID(int PersonID)
        {
            int UserID  = -1;
            string Username = "", Password = "";
            bool IsActive = false;
            int Permission = -1;
            if (dtUsers.Find(ref UserID, PersonID, ref Username, ref Password,
                ref IsActive,ref Permission))
            {
                return new clsUser(UserID, PersonID, Username, Password
                    , IsActive,Permission);
            }
            else
            {

                return null;
            }
        }
        private bool _Add()
        {
            this.UserID = dtUsers.Add(this.PersonID, this.Username, this.Password,this.IsActive,
                this.Permission);
            return this.UserID > -1;
                
        }
        private bool _Update()
        {
            return dtUsers.Update(this.UserID, this.PersonID, this.Username, this.Password
                , this.IsActive,this.Permission);
        }
        public static bool Delete(int UserID)
        {
            return (dtUsers.Delete(UserID));
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
        public static DataTable GetAllUsers()
        {
            return (dtUsers.GetAllUsers());
        }

        static public bool IsPersonIDExist(int PersonID)
        {
            return dtUsers.IsPersonIDExistInUsers(PersonID);
        }

        public static bool IsUsernameExist(string Username)
        {
            return (dtUsers.IsUserExist(Username));
        }
        public bool IsPersonIDExist()
        {
            return dtUsers.IsPersonIDExistInUsers(this.PersonID);
        }

        public bool ChangePassword(string Password)
        {
            bool UpdatePassord = dtUsers.ChangePassword(this.UserID,Password);
            if (!UpdatePassord)
                return false;
            // if it not false;
            else
                return true;
        }
    
    }
}
