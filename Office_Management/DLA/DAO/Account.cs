using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office_Management.DLA.DAO
{
    class Account
    {
        private string accountType;
        private string username;
        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string AccountType
        {
            get { return accountType; }
            set { accountType = value; }
        }
    }
}
