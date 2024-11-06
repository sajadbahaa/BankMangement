using DvlcDataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsPeople
{
  public class clsCountries
    {
    public int CountryID { get; set; }
     public string CountryName { get; set; }
    public clsCountries()
        {
            CountryID = -1;
            CountryName = "";
        }
    public clsCountries(int CountryID, string CountryName)
        {
            this.CountryID = CountryID;
            this.CountryName = CountryName;
        }
    
        public static clsCountries FindByCountryName(string CountryName)
        {
            int CountryID = -1;
            if (dtCountries.Find(ref CountryID,CountryName))
            {
                return new clsCountries(CountryID,CountryName);
            }
            else
            {
                return null;
            }
        }
       public static clsCountries FindByCountryID(int CountryID)
        {
            string CountryName = "";
            if (dtCountries.Find( CountryID,ref CountryName))
            {
                return new clsCountries(CountryID, CountryName);
            }
            else
            {
                return null;
            }

        }
        public static DataTable GetAllCountries()
        {
            return (dtCountries.GetAllCountries());
        }
    }
}
