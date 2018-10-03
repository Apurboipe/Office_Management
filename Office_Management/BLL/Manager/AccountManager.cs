using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Office_Management.DLA.DAO;
using Office_Management.DLA.Getway;

namespace Office_Management.BLL.Manager
{
    class AccountManager
    {
        AccountGateway accountGateway=new AccountGateway();

        public string SaveAccountInfo(Account account)
        {
            string message = null;
            if (account.AccountType != "" && account.Username != "" && account.Password != "")
            {
                if (account.AccountType== "Teacher")
                {
                    if (account.Password.Contains("Teacher"))
                    {
                        if (accountGateway.GetAccountUserName(account.Username) != account.Username)
                        {
                            message = accountGateway.SaveAccountInfo(account);
                        }
                        else
                        {
                            message = "User Name Already Exist.";
                        }
                    }
                    else
                    {
                        message = "Your Password Is Not For Teacher.";
                    }
                }
                else if(account.AccountType == "Chairman")
                {
                    if (account.Password.Contains("Chairman"))
                    {
                        if (accountGateway.GetAccountUserName(account.Username) != account.Username)
                        {
                            message = accountGateway.SaveAccountInfo(account);
                        }
                        else
                        {
                            message = "User Name Already Exist.";
                        }
                    }
                    else
                    {
                        message = "Your Password Is Not For Chairman.";
                    }
                }
                else if (account.AccountType == "Administrator")
                {
                    if (account.Password.Contains("Administrator"))
                    {
                        if (accountGateway.GetAccountUserName(account.Username) != account.Username)
                        {
                            message = accountGateway.SaveAccountInfo(account);
                        }
                        else
                        {
                            message = "User Name Already Exist.";
                        }
                    }
                    else
                    {
                        message = "Your Password Is Not For Administrator.";
                    }
                }
                else if (account.AccountType == "Office")
                {
                    if (account.Password.Contains("Office"))
                    {
                        if (accountGateway.GetAccountUserName(account.Username) != account.Username)
                        {
                            message = accountGateway.SaveAccountInfo(account);
                        }
                        else
                        {
                            message = "User Name Already Exist.";
                        }
                    }
                    else
                    {
                        message = "Your Password Is Not For Office.";
                    }
                }
                else
                {
                    if (accountGateway.GetAccountUserName(account.Username) != account.Username)
                    {
                        message = accountGateway.SaveAccountInfo(account);
                    }
                    else
                    {
                        message = "User Name Already Exist.";
                    }
                }
            }
            else if (account.AccountType == "")
            {
                message = "Please Select Account Type.";
            }
            else if (account.Username == "")
            {
                message = "Please Enter User Name.";
            }
            else if (account.Password == "")
            {
                message = "Please Enter Password.";
            }
            return message;
        }

        public string CheckAccountInfo(Account account)
        {
            string message = "";
            Account anAccount=new Account();
            anAccount = accountGateway.CheckAccountInfo(account);
            if (account.AccountType==anAccount.AccountType && account.Username==anAccount.Username && account.Password==anAccount.Password)
            {
                message = "LogIn Successful";
            }
            else
            {
                message = "Username Or Password Wrong";
            }
            return message;
        }
    }
}
