using clsPeople;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using BankBussiness;
namespace BankSystem
{
    
    public  class clsGlobal
    {

        public static bool DoyouHavePermission(clsSettings.enPermissions Permission)
        {
            if ((clsSettings.enPermissions)clsGlobal.CurrnetUser.Permission == clsSettings.enPermissions.eAll)
            {
                return true;
            }
            if (((clsSettings.enPermissions)clsGlobal.CurrnetUser.Permission & Permission) == Permission)
             {
                return true;
            }
            return false;
            {

            }


        }
        public static clsUser CurrnetUser;
        public static clsBankClient CurrentClientInfo;
        static  public  bool GetStoredData(ref  string  Username,ref string Password)
        {
            // we need check File name Exist
            // first get current Path.
            // second Named File Name.

            string CurrentDirectory = System.IO.Directory.GetCurrentDirectory();
            string FileName = CurrentDirectory + "\\UserInfo.txt";
            string Line;
            try
            {
                // check if File does not exist
                
                if (File.Exists(FileName))
                {
                    using (StreamReader stReader = new StreamReader(FileName))
                    {
                        // Get Data from File
                        while ((Line = stReader.ReadLine()) != null)
                        {
                            string[] GetData = Line.Split(new string [] {"," },System.StringSplitOptions.None);
                            Username = GetData[0];
                            Password = GetData[1];
                        }
                        stReader.Close();

                        return true;
                    }
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "error in Retreving Data frim File");
                return false;
            }
           
        }
    static public bool RemmberData(string Username,string Password)
        {
            // we use try and Catch to handel Errors in Files
            try
            {
                // first we need to get Current Directory 
                string CurrentDirectory = System.IO.Directory.GetCurrentDirectory();
                string FileName = CurrentDirectory + "\\UserInfo.txt";

                if (File.Exists(FileName) && Username == "")
                {
                    File.Delete(FileName);

                    return true; 
                        }
                // we define var  to geather password and Username
                string Line = Username + ',' + Password;
                using (StreamWriter stWriter = new StreamWriter(FileName))
                {
                    stWriter.WriteLine(Line);
                    stWriter.Close();
                }
            }

              catch (Exception ex) {
                // handel errors if there problems 

                MessageBox.Show(ex.Message+ "Failed Save Data Inf File !",
                   "Error Manageing",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    
    }
}
