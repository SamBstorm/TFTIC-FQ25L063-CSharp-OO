using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_02_Encapsulation.Structs
{
    internal struct Login
    {
        public string email;
        private string _password;

        public void SavePassword(string newPassword)
        {
            _password = newPassword;
        }

        public bool CheckLogin(string email, string password)
        {
            return this.email == email && _password == password;
        }
    }
}
