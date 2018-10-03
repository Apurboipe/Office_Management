using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office_Management.DLA.DAO
{
    class Assign
    {
        private string session;
        private string name;
        private int roll;

        public int Roll
        {
            get { return roll; }
            set { roll = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Session
        {
            get { return session; }
            set { session = value; }
        }
    }
}
