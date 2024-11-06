using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BankData
{
    public class dtPeople
    {
   public static bool Find
    (int PersonID,ref string Name,ref string NationalNo,
  ref   byte Gendor,ref  DateTime Birth,ref string Phone,
  ref string Email,ref string Address, ref int Nationality, ref string ImagePath)
        {
            bool IsFind = false;
            SqlConnection connection = new SqlConnection(dtAccess.Connection);
            string query = @"Select  * from People
where PersonID = @PersonID";
            SqlCommand command = new SqlCommand(query,connection);
            command.Parameters.AddWithValue("@PersonID",PersonID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
               
                if (reader.Read())
                {
            // this Person ID is Exist
                    IsFind = true;
                    Name = (string)reader["Name"];
                    NationalNo = (string)reader["NationalNo"];
                    Gendor = (Byte)reader["Gendor"];
                    Birth = (DateTime)reader["Birth"];
                    Phone = (string)reader["Phone"];
                    Nationality = (int)reader["Nationality"];
                    // handel Email if it is Null
                    if (reader["Email"] == System.DBNull.Value)
                        Email = null;
                    else
                        Email = (string)reader["Email"];
                    // handel ImagePath if it is Null
                    if (reader["ImagePath"] == System.DBNull.Value)
                        ImagePath = null;
                    else
                        ImagePath = (string)reader["ImagePath"];

                    //Address
                    if (reader["Address"] == System.DBNull.Value)
                        Address = null;
                    else
                        Address = (string)reader["Address"];

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
        public static bool Find
   (ref int PersonID, ref string Name,  string NationalNo,
  ref byte Gendor, ref DateTime Birth, ref string Phone,
  ref string Email,ref string Address, ref int Nationality, ref string ImagePath)
        {
            bool IsFind = false;
            SqlConnection connection = new SqlConnection(dtAccess.Connection);
            string query = @"Select  * from People
where NationalNo = @NationalNo";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // this Person ID is Exist
                    IsFind = true;
                    Name = (string)reader["Name"];
                    PersonID = (int)reader["PersonID"];
                    Gendor = (Byte)reader["Gendor"];
                    Birth = (DateTime)reader["Birth"];
                    Phone = (string)reader["Phone"];
                    
                    if (reader["Email"] == System.DBNull.Value)
                        Email = null;
                    else
                    Email = (string)reader["Email"];
                    
                    if (reader["ImagePath"] == System.DBNull.Value)
                        ImagePath = null;
                    else
                        ImagePath = (string)reader["ImagePath"];

                    Nationality = (int)reader["Nationality"];
                    //Address
                    if (reader["Address"] == System.DBNull.Value)
                        Address = null;
                    else
                        Address = (string)reader["Address"];

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


        public static int AddPerson(string Name, string NationalNo,
    byte Gendor, DateTime Birth, string Phone,
    string Email, string Address, int Nationality, string ImagePath)
        {
            int NewPersonID = -1;
                SqlConnection connection = new SqlConnection(dtAccess.Connection);
            string query = @" Insert into People
(
Name,
NationalNo,
Gendor,
Birth,
Phone,
Email,
Address,
Nationality,
ImagePath
)
values
(
@Name,
@NationalNo,
@Gendor,
@Birth,
@Phone,
@Email,
@Address,
@Nationality,
@ImagePath
);
select Scope_Identity();
";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Name",Name);
            command.Parameters.AddWithValue("@Birth",Birth);
            command.Parameters.AddWithValue("@Nationality", Nationality);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@Gendor",Gendor);
            command.Parameters.AddWithValue("@Phone",Phone);
            
            if (Email != "")
                command.Parameters.AddWithValue("@Email", Email);
            else
                command.Parameters.AddWithValue("@Email", System.DBNull.Value);

            if (ImagePath!=null)
            command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);

            if (Address != null)
                command.Parameters.AddWithValue("@Address", Address);
            else
                command.Parameters.AddWithValue("@Address", System.DBNull.Value);

            try
            {
                connection.Open();
                object res = command.ExecuteScalar();
                if (res != null)
                {
                    NewPersonID = Convert.ToInt32(res);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return NewPersonID;
        }

   public static bool UpdatePerson(
       int PersonID, string Name, string NationalNo,
    byte Gendor, DateTime Birth, string Phone,
    string Email,string Address, int Nationality, string ImagePath)
        {
            int Affect = 0;
            SqlConnection connection = new SqlConnection(dtAccess.Connection);
            string query = @"Update People
Set Name =  @Name,
NationalNo = @NationalNo,
 Gendor = @Gendor,
 Birth = @Birth,
Phone = @Phone,
Email = @Email,
Address = @Address,
Nationality = @Nationality,
ImagePath = @ImagePath

Where PersonID = @PersonID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID",PersonID);
            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@Birth", Birth);
            command.Parameters.AddWithValue("@Nationality", Nationality);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@Gendor", Gendor);
            command.Parameters.AddWithValue("@Phone", Phone);

            if (Email != "")
                command.Parameters.AddWithValue("@Email", Email);
            else
                command.Parameters.AddWithValue("@Email", System.DBNull.Value);

           
            if (ImagePath != null)
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);

            if (Address != null)
                command.Parameters.AddWithValue("@Address", Address);
            else
                command.Parameters.AddWithValue("@Address", System.DBNull.Value);

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
            return Affect>0;
        }
    
        public static bool Delete(int PersonID)
        {
            int Affect = 0;
            SqlConnection connection = new SqlConnection(dtAccess.Connection);
            string query = @"Delete from People where PersonID = @PersonID";
            SqlCommand command = new SqlCommand(query,connection);
            command.Parameters.AddWithValue("@PersonID",PersonID);
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
            return Affect > 0;
        }
        public static bool Exist(int NationalNo)
        {
            bool IsFind = false;
            SqlConnection connection = new SqlConnection(dtAccess.Connection);
            string query = @"Select find = 'yes' from People where PersonID = @PersonID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", NationalNo);
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


        public static DataTable GetAllPeople()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(dtAccess.Connection);
            string query = "Select * from People";
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
        //PeopleInfo_View
        public static DataTable GetAllPeople_View()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(dtAccess.Connection);
            string query = "Select * from PeopleInfo_View";
            SqlCommand command = new SqlCommand(query, connection);
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
        public static bool Exist(string NationalNo)
        {
            bool IsFind = false;
            SqlConnection connection = new SqlConnection(dtAccess.Connection);
            string query = @"Select find = 'yes' from People where  NationalNo = @NationalNo";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
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
