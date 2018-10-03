using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office_Management.DLA.DAO
{
    class Teacher
    {
        private string username;
        private string name;
        private string designation;
        private string note;
        private string dept;
        private string gender;

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string Dept
        {
            get { return dept; }
            set { dept = value; }
        }

        public string Note
        {
            get { return note; }
            set { note = value; }
        }

        public string Designation
        {
            get { return designation; }
            set { designation = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
    }
}
