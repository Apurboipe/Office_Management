using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office_Management.DLA.DAO
{
    class Administration
    {
        private string name;
        private string username;
        private string type;
        private string gender;
        private string note;

        public string Note
        {
            get { return note; }
            set { note = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
