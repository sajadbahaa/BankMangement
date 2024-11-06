using BankData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DvlcDataLayer
{
   public  class dtCountries
    {
        public static bool Find(ref int CountryID,string CountryName)
        {
            bool IsFind = false;
            SqlConnection connection =
                new SqlConnection(dtAccess.Connection);
            string query = @"Select * from Countries
            where CountryName = @CountryName";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CountryName", CountryName);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFind = true;
                    CountryID = (int)reader["CountryID"];
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
        public static bool Find( int CountryID, ref string CountryName)
        {
            bool IsFind = false;
            SqlConnection connection = new SqlConnection(dtAccess.Connection);
            string query = @"Select * from Countries where CountryID = @CountryID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CountryID", CountryID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFind = true;
                    CountryName = (string)reader["CountryName"];
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
        public static DataTable GetAllCountries()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(dtAccess.Connection);
            string query = "Select * from Countries";
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
            catch(Exception r)
            {

            }finally
            {
                connection.Close();
            }
            return dt;
        }
    }
}
