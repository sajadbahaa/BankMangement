using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankData
{
    public class dtClient
    {
        public static bool Find(int ClientID, ref int PersonID,
        ref string AccountNumber, ref string PinCode, ref int Balance,
        ref int CreatedByUserID, ref DateTime CreateDate,ref bool IsActive)
        {
            bool IsFind = false;
            SqlConnection connection = new SqlConnection(dtAccess.Connection);
            string query = @"Select * from Clients
       where ClientID = @ClientID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ClientID", ClientID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFind = true;
                    PersonID = (int)reader["PersonID"];
                    PinCode = (string)reader["PinCode"];
                    Balance = (int)reader["Balance"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    CreateDate = (DateTime)reader["CreateDate"];
                    AccountNumber = (string)reader["AccountNumber"];            
                    IsActive = (bool)reader["IsActive"];
                    

                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return IsFind;
        }
        public static bool Find( ref int ClientID, ref int PersonID,
         string AccountNumber, ref string PinCode, ref int Balance,
        ref int CreatedByUserID, ref DateTime CreateDate,ref bool IsActive)
        {
            bool IsFind = false;
            SqlConnection connection = new SqlConnection(dtAccess.Connection);
            string query = @"Select * from Clients
where AccountNumber = @AccountNumber";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFind = true;
                    PersonID = (int)reader["PersonID"];
                    ClientID = (int)reader["ClientID"];
                    PinCode = (string)reader["PinCode"];
                    Balance = (int)reader["Balance"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    CreateDate = (DateTime)reader["CreateDate"];
                    IsActive = (bool)reader["IsActive"];
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return IsFind;
        }
        public static bool Find(ref int ClientID, ref int PersonID,
          string AccountNumber,  string PinCode, ref int Balance,
        ref int CreatedByUserID, ref DateTime CreateDate,ref bool IsActive)
        {
            bool IsFind = false;
            SqlConnection connection = new SqlConnection(dtAccess.Connection);
            string query = @"Select * from Clients
where AccountNumber = @AccountNumber And PinCode = @PinCode";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            command.Parameters.AddWithValue("@PinCode",PinCode);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFind = true;
                    PersonID = (int)reader["PersonID"];
                    ClientID = (int)reader["ClientID"];
                    Balance = (int)reader["Balance"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    CreateDate = (DateTime)reader["CreateDate"];
                    IsActive = (bool)reader["IsActive"];
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return IsFind;
        }
        
        public static int Add(int PersonID,
          string AccountNumber, string PinCode,  int Balance,
         int CreatedByUserID,  DateTime CreateDate,bool IsActive)
        {
            int NewID = -1;
            SqlConnection connection = new SqlConnection(dtAccess.Connection);
            string query = @"Insert into Clients
(
     PersonID    ,
AccountNumber    ,
     PinCode     ,
    Balance      ,
CreatedByUserID  ,
     CreateDate  ,
 IsActive
)
Values
(
@PersonID,
@AccountNumber,
@PinCode,
@Balance,
@CreatedByUserID,
@CreateDate,
@IsActive
);
Select Scope_Identity();
";
            SqlCommand commnad = new SqlCommand(query, connection);
            commnad.Parameters.AddWithValue("@PersonID", PersonID);
            commnad.Parameters.AddWithValue("@PinCode", PinCode);
            commnad.Parameters.AddWithValue("@Balance", Balance);
            commnad.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            commnad.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            commnad.Parameters.AddWithValue("@CreateDate",CreateDate);
            commnad.Parameters.AddWithValue("@IsActive", IsActive);

            try
            {
                connection.Open();
                object res = commnad.ExecuteScalar();
                if (res!=null)
                {
                    NewID = Convert.ToInt32(res);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return NewID;
        }
        public static bool Update(int ClientID, int PersonID,
           string PinCode, int Balance,
         int CreatedByUserID, DateTime CreateDate,bool IsActive)
        {
            int Affect = 0;
            SqlConnection connection = new SqlConnection(dtAccess.Connection);
            string query = @"Update Clients
   Set  PersonID = @PersonID,
     PinCode     = @PinCode,
    Balance      = @Balance,
CreatedByUserID  = @CreatedByUserID,
     CreateDate  = @CreateDate,
    IsActive = @IsActive
Where ClientID = @ClientID;
";
            SqlCommand commnad = new SqlCommand(query, connection);
            commnad.Parameters.AddWithValue("@ClientID", ClientID);
            commnad.Parameters.AddWithValue("@PersonID", PersonID);
            commnad.Parameters.AddWithValue("@PinCode", PinCode);
            commnad.Parameters.AddWithValue("@Balance", Balance);
            commnad.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            commnad.Parameters.AddWithValue("@CreateDate", CreateDate);
            commnad.Parameters.AddWithValue("@IsActive", IsActive);

            try
            {
                connection.Open();
                Affect = commnad.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return Affect > 0;
        }

     public static bool Delete(int ClientID)
        {
            int Affect = 0;
            SqlConnection connection = new SqlConnection(dtAccess.Connection);
            string query = @"Delete From Clients
Where ClientID = @ClientID;";
            SqlCommand commnad = new SqlCommand(query, connection);
            commnad.Parameters.AddWithValue("@ClientID", ClientID);
            try
            {
                connection.Open();
                Affect = commnad.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return Affect > 0;
        }
        public static bool Exist(string AccountNumber)
        {
            bool IsFind = false;
            SqlConnection connection = new SqlConnection(dtAccess.Connection);
            string query = @"Select find = 'yes' From Clients
Where AccountNumber = @AccountNumber;";
            SqlCommand commnad = new SqlCommand(query, connection);
            commnad.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            try
            {
                connection.Open();
                SqlDataReader reader = commnad.ExecuteReader();

                IsFind = reader.HasRows;
                reader.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return IsFind;
        }
     
     
        public static int GetClientID(int PersonID)
        {
            int ClientID = -1;
            SqlConnection connection = new SqlConnection(dtAccess.Connection);
            string query = @"Select ClientID From Clients
Where PersonID = @PersonID;";
            SqlCommand commnad = new SqlCommand(query, connection);
            commnad.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                connection.Open();
               
                object res = commnad.ExecuteScalar();
                if (res!=null)
                {
                    ClientID = Convert.ToInt32(res);
                }
            }

            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return ClientID;
        }
        public static DataTable GetAllClients()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(dtAccess.Connection);
            string query = @"Select * From Clients";
            SqlCommand command = new SqlCommand(query,connection);
            
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                    dt.Load(reader);
                reader.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return dt;
        }
        public static bool UpdateBalance(int ClientID,int Balance)
        {
            int Affect = 0;
            SqlConnection connection = new SqlConnection(dtAccess.Connection);
            string query = @"Update Clients
   Set  
    Balance      = @Balance
Where ClientID = @ClientID;
";
            SqlCommand commnad = new SqlCommand(query, connection);
            commnad.Parameters.AddWithValue("@ClientID", ClientID);
            commnad.Parameters.AddWithValue("@Balance", Balance);
            
            try
            {
                connection.Open();
                Affect = commnad.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return Affect > 0;
        }
     static  public int GetTotalBalance()
        {
            int TotalBalance = 0;
            SqlConnection connection = new SqlConnection(dtAccess.Connection);
            string query = @"
select Sum(Balance) from Clients";
            SqlCommand command = new SqlCommand(query,connection);
            try{
                connection.Open();
                object res = command.ExecuteScalar();
                if (res!=null)
                {
                    TotalBalance = Convert.ToInt32(res);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return TotalBalance;
        }

    }
}
