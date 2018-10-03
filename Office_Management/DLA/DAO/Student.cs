using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office_Management.DLA.DAO
{
    class Student
    {
        private int roll;
        private string name;
        private string dept;
        private string session;
        private string sex;
        private string note;

        public string Note
        {
            get { return note; }
            set { note = value; }
        }

        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        public string Session
        {
            get { return session; }
            set { session = value; }
        }

        public string Dept
        {
            get { return dept; }
            set { dept = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Roll
        {
            get { return roll; }
            set { roll = value; }
        }
    }
}
