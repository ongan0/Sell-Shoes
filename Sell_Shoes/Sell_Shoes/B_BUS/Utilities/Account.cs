using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sell_Shoes.B_BUS.Utilities
{
    internal class Account
    {
        public string username { get; set; }
        public string password { get; set; }

        public Account()
        {
        }

        public Account(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
    }
}
