using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_01_Namespace.Structs
{
    internal struct Email
    {
        public string domain;
        public string identifier;

        public string GetFullMail()
        {
            return $"{identifier}@{domain}";
        }

        public void ShowEmail()
        {
            Program p = new Program();
        }
    }
}
