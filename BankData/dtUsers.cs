using BankData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DvlcDataLayer
{
    public class dtUsers
    {
    public static bool Find(int UserID,ref int PersonID,ref string Username,ref string Password,ref bool IsActive
        ,ref int Permission)
        {
            bool IsFind = false;
            SqlConnection connection = new SqlConnection(dtAccess.Connection);
            string query = @"Select * from Users Where UserID = @UserID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID",UserID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFind = true;
                    PersonID = (int)reader["PersonID"];
                    Username = (string)reader["Username"];
                    Password = (string)reader["Password"];
                    IsActive = (bool)reader["IsActive"];
                    Permission = (int)reader["Permission"];
                } 
                reader.Close();
            }catch(Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return IsFind;
        }
        public static bool Find(ref int UserID, int PersonID,
            ref string Username, ref string Password, 
            ref bool IsActive,ref  int Permission)
        {
            bool IsFind = false;
            SqlConnection connection = new SqlConnection(dtAccess.Connection);
            string query = @"Select * from Users Where PersonID = @PersonID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFind = true;
                    UserID = (int)reader["UserID"];
                    Username = (string)reader["Username"];
                    Password = (string)reader["Password"];
                    IsActive = (bool)reader["IsActive"];
                    Permission = (int)reader["Permission"];
                }
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
        public static bool Find(ref int UserID,ref  int PersonID,  string Username
            ,  string Password, ref bool IsActive, ref int Permission)
        {
            bool IsFind = false;
            SqlConnection connection = new SqlConnection(dtAccess.Connection);
            string query = @"Select * from Users Where Username = @Username And Password = @Password";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Username", Username);
            command.Parameters.AddWithValue("@Password",Password);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFind = true;
                    UserID = (int)reader["UserID"];
                    PersonID = (int)reader["PersonID"];
                    IsActive = (bool)reader["IsActive"];
                    Permission = (int)reader["Permission"];

                }
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
        public static int Add( int PersonID,string Username,string Password
            ,  bool IsActive, int Permission)
        {
            int NewUserID= -1;
            SqlConnection connection = new SqlConnection(dtAccess.Connection);
            string query = @"Insert into Users 
(PersonID
,Username
,Password
,IsActive
,Permission)
values(
@PersonID
,@Username
,@Password
,@IsActive
,@Permission
);
Select Scope_Identity();";
            
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Username", Username);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@Permission",Permission);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result!=null&&int.TryParse(result.ToString(),out int ID))
                {
                NewUserID = ID;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return NewUserID;
        }
        public static bool Update(int UserID, int PersonID, string Username, string Password
            , bool IsActive, int Permission)
        {
            int Affect = -1;
            SqlConnection connection = new SqlConnection(dtAccess.Connection);
            string query = @"Update Users 
               Set
Username = @Username
,Password = @Password
,IsActive = @IsActive
,PersonID = @PersonID
,Permission = @Permission
            where UserID = @UserID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID",UserID);
            command.Parameters.AddWithValue("@Username", Username);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@Permission", Permission);

            try
            {
                connection.Open();
                Affect = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return (Affect>-1);
        }
        public static bool ChangePassword(int UserID,string Password)
        {
            int Affect = -1;
            SqlConnection connection = new SqlConnection(dtAccess.Connection);
            string query = @"Update Users 
               Set Password = @Password
            where UserID = @UserID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@Password", Password);
            try
            {
                connection.Open();
                Affect = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return (Affect > -1);
        }
        public static bool Delete(int UserID)
        {
            int Affect = -1;
            string query = @"Delete from Users Where UserID = @UserID";
            SqlConnection connection = new SqlConnection(dtAccess.Connection);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);
            try
            {
                connection.Open();
                Affect = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return (Affect > -1);
        }
        public static bool IsUserExist(int UserID)
        {

            bool IsFind = false;
            string query = @"Select find ='yes'from Users Where UserID = @UserID";
            SqlConnection connection = new SqlConnection(dtAccess.Connection);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
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
        public static bool IsUserExist(string Username)
        {

            bool IsFind = false;
            string query = @"Select find ='yes'from Users Where Username = @Username";
            SqlConnection connection = new SqlConnection(dtAccess.Connection);         
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Username", Username);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
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
        
      
        public static DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();
            
            string query = @"Select * from UserInfo_View";
            SqlConnection connection = new SqlConnection(dtAccess.Connection);
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
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
        public static bool IsPersonIDExistInUsers(int PersonID)
        {
            bool IsFind = false;
            SqlConnection connection = new SqlConnection(dtAccess.Connection);
            string query = @"Select Find = 'yes' from Users Where PersonID = @PersonID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
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
    }
}
