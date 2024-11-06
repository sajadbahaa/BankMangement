using BankData;
using clsPeople;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BankBussiness
{
    public class clsPerson
    {
        public int PersonID { get; set; }
        public string Name { get; set; }
        public string NationalNo { get; set; }
        public byte Gendor { get; set; }
        public DateTime Birth { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int Nationality { get; set; }
        public string ImagePath { get; set; }
     public string CountryName { get; set; }
public string Address { get; set; }
  enum enMode { add  =1 ,update =2}
        private enMode _Mode = enMode.add;
      public clsPerson()
        {
            PersonID = -1;
            Name = "";
            Nationality = -1;
            NationalNo = "";
            Phone = "";
            Gendor = 0;
            Birth = DateTime.Today;
            Address = null;
            _Mode = enMode.add;
            Email = null;
            ImagePath = null;
        }
public clsPerson(int PersonID,string Name,string NationalNo,
    byte Gendor,DateTime Birth,string Phone,string Email, string Address
    ,int Nationality,string ImagePath) 
        {
            this.PersonID = PersonID;
            this.NationalNo = NationalNo;
            this.Nationality = Nationality;
            this.ImagePath = ImagePath;
            this.Birth = Birth;
            this.Email = Email;
            this.Gendor = Gendor;
            this.Phone = Phone;
            this.Name = Name;
            this.Address = Address;
            this.CountryName = clsCountries.FindByCountryID(Nationality).CountryName;
            _Mode = enMode.update;
        }
    public static clsPerson FindByPersonID(int PersonID)
        {
            int Nationality = -1;
            string Phone = "", Name = "", ImagePath = null, 
                Email = null,NationalNo = "",Address =null;
            DateTime Birth = DateTime.Today;
            Byte Gendor = 0;
            bool IsFind = dtPeople.Find(PersonID,ref Name,
                ref NationalNo,ref Gendor,ref Birth,ref Phone,
               ref Email,ref Address,ref Nationality,ref ImagePath);

            if (IsFind)
                return new clsPerson(PersonID, Name,
                   NationalNo, Gendor, Birth, Phone, Email,Address
                   ,Nationality, ImagePath);
            else
                return null;
        }

        public static clsPerson FindByNationalNo(string NationalNo)
        {
            int  PersonID  = -1 ,Nationality = -1;
            string Phone = "", Name = "", ImagePath = null,
                Email = null, Address = null;
            DateTime Birth = DateTime.Today;
            Byte Gendor = 0;
            bool IsFind = dtPeople.Find(ref  PersonID, ref Name,
                 NationalNo, ref Gendor, ref Birth, ref Phone,
               ref Email,ref Address,
               ref Nationality, ref ImagePath);

            if (IsFind)
                return new clsPerson(PersonID, Name,
                   NationalNo, Gendor, Birth, Phone, Email,Address, 
                   Nationality, ImagePath);
            else
                return null;
        }

  private bool _Add()
        {
            this.PersonID = dtPeople.AddPerson(this.Name, this.NationalNo, this.Gendor,
               this.Birth, this.Phone, this.Email,this.Address, this.Nationality, this.ImagePath);
            return (this.PersonID>-1);
        }
private bool _Update()
        {
            return dtPeople.UpdatePerson(
                this.PersonID, this.Name, this.NationalNo,
                this.Gendor,this.Birth, this.Phone,
                this.Email, this.Address,
               this.Nationality, this.ImagePath);
        }
    public static bool Delete(int PersonID) 
        {
            return (dtPeople.Delete(PersonID));
        }
    public static bool IsExist(int PersonID) 
        {
            return (dtPeople.Exist(PersonID));
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
  static public DataTable GetAllPeople()
        {

            return dtPeople.GetAllPeople_View();
        }
   static public bool IsNationalNoExist(string NationalNo)
        {
            return dtPeople.Exist(NationalNo);
        }
    public int GetClientID()
        {
            return clsBankClient.GetClientID(this.PersonID);
        }
    }
}
