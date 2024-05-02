using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Registration
{
    internal class User
    {
        public string fName { get; }
        public string lName { get;}

        public User(string fName, string lName)
        {
            this.fName = fName;
            this.lName = lName;
        }

    }
}
