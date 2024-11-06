using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace BankData
{
    public class dtTransfer
    {
    public static 
 bool Find(int TransferID,int TransferAccountFrom,
int TransferAccountTo,int AccountBalanceBeforeTransfer,
int AccountBalanceAfterTransfer,int BalanceAfterTranfer,
DateTime TransferData,
int CreatedByUserID)
        {
    bool IsFind = false;
            SqlConnection connection = new SqlConnection(dtAccess.Connection);
            string query = @"select * from Transfers
Where TransferID = @TransferID";
            SqlCommand command = new SqlCommand(query,connection);
            command.Parameters.AddWithValue("@TransferID", TransferID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFind = true;
                    TransferData = (DateTime)reader["TransferData"];
                    TransferAccountFrom = (int)reader["TransferAccountFrom"];
                    TransferAccountTo = (int)reader["TransferAccountTo"];
                    AccountBalanceBeforeTransfer = (int)reader["AccountBalanceBeforeTransfer"];
                    AccountBalanceAfterTransfer = (int)reader["AccountBalanceAfterTransfer"];
                    BalanceAfterTranfer = (int)reader["BalanceAfterTranfer"];
                }
                reader.Close();
            }
            catch (Exception ex) 
            {
            
            }
            return IsFind;
        }

        public static int Add(int TransferAccountFrom,
        int TransferAccountTo, int AccountBalanceBeforeTransfer,
        int AccountBalanceAfterTransfer, int BalanceAfterTranfer,
        DateTime TransferData,
        int CreatedByUserID)
        {
            int NewID = -1;
            SqlConnection connection = new SqlConnection(dtAccess.Connection);
            string query = @"Insert into Transfers
(TransferAccountFrom
,TransferAccountTo
,AccountBalanceBeforeTransfer
,AccountBalanceAfterTransfer
,BalanceAfterTranfer
,TransferData
,CreatedByUserID)
Values
(@TransferAccountFrom
,@TransferAccountTo
,@AccountBalanceBeforeTransfer
,@AccountBalanceAfterTransfer
,@BalanceAfterTranfer
,@TransferData
,@CreatedByUserID);
Select Scope_Identity();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TransferAccountFrom", TransferAccountFrom);
            command.Parameters.AddWithValue("@TransferAccountTo", TransferAccountTo);
            command.Parameters.AddWithValue("@AccountBalanceBeforeTransfer", AccountBalanceBeforeTransfer);
            command.Parameters.AddWithValue("@AccountBalanceAfterTransfer",AccountBalanceAfterTransfer);
            command.Parameters.AddWithValue("@BalanceAfterTranfer",BalanceAfterTranfer);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@TransferData", TransferData);


            try
            {
                connection.Open();
                object res = command.ExecuteScalar();
                if (res != null)
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
        public static int GetUserID(int ClientID)
        {
            int UserID = -1;
            SqlConnection connection = new SqlConnection(dtAccess.Connection);

            string query = @"select  Transfers.CreatedByUserID from Transfers
 inner join Clients as C1 on
Transfers.TransferAccountFrom = C1.ClientID  or 
Transfers.TransferAccountTo = C1.ClientID
 where ClientID = @ClientID";
            SqlCommand command = new SqlCommand(query,connection);
            command.Parameters.AddWithValue("@ClientID",ClientID);
            try
            {
                connection.Open();
                object res = command.ExecuteScalar();
                if (res!=null)
                {
                    UserID = Convert.ToInt32(res);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return UserID;
        }
        
        public static bool Delete(int UserID)
        {
            int Affect = 0;
            SqlConnection connection = new SqlConnection(dtAccess.Connection);
            string query = @"Delete  from 
Transfers where CreatedByUserID = @UserID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID",UserID);
            try
            {
                connection.Open();
                Affect = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally {
                connection.Close();
            }
            return (Affect>0);
        }
        public static DataTable AllTransfersByUserID(int CreatedByUserID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(dtAccess.Connection);
            string query = @"
select Transfers.TransferData,ClientFrom.AccountNumber as Transferfrom ,
	ClientTo.AccountNumber as TransferTo,
	AccountBalanceBeforeTransfer as BAcc1BTransfer,
	AccountBalanceAfterTransfer as  BAcc1AfTransfer 
	,
BalanceAfterTranfer as BAcc2AfTransfer,
	Users.Username
	from Transfers
	inner join Clients as ClientFrom on Transfers.TransferAccountFrom = ClientFrom.ClientID
	inner join Clients as ClientTo on  Transfers.TransferAccountTo = ClientTo.ClientID
	inner join Users on Transfers.CreatedByUserID =  Users.UserID
	
where Transfers.CreatedByUserID = @CreatedByUserID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
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
           //error                
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }
        //Transfer_View
        public static DataTable AllTransfers()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(dtAccess.Connection);
            string query =
                "select * from Transfer_View";

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
                //error                
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }

    }
} 
