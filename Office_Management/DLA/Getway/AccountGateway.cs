using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Office_Management.DLA.DAO;

namespace Office_Management.DLA.Getway
{
    class AccountGateway : DBConnection
    {
        private string queray;
        private SqlCommand command;
        public string SaveAccountInfo(Account account)
        {
            try
            {
                connection.Open();
                string message;
                queray = "Insert into account_tbl Values('" + account.AccountType + "','" + account.Username + "','" + account.Password + "')";
                command = new SqlCommand(queray, connection);
                int effectiveRow = command.ExecuteNonQuery();
                if (effectiveRow != 0)
                {
                    message = "Account Create Successful.";
                }
                else
                {
                    message = "Sorry Please Tyr Again.";
                }
                connection.Close();
                return message;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }

            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public string GetAccountUserName(string userName)
        {
            try
            {
                string name = "";
                connection.Open();
                queray = "Select username From account_tbl where username=('" + userName + "')";
                command = new SqlCommand(queray, connection);
                int effectiveRow = command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read() == true)
                {
                    name = reader[0].ToString();
                }
                connection.Close();
                return name;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }

            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public Account CheckAccountInfo(Account account)
        {
            try
            {
                connection.Open();
                Account accountread = new Account();
                queray = "Select * From account_tbl where username=('" + account.Username + "')";
                command = new SqlCommand(queray, connection);
                int effectiveRow = command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read() == true)
                {
                   
                    accountread.AccountType = reader[0].ToString();
                    accountread.Username= reader[1].ToString();
                    accountread.Password= reader[2].ToString();
                }
                connection.Close();
                return accountread;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }

            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

    }
}
