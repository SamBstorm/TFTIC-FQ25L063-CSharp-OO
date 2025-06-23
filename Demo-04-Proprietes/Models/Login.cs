using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Demo_04_Proprietes.Models
{
    internal class Login
    {
        #region Variables membres / Champs
        private string _password;
        #endregion

        #region Propriétés
        public string Email{ get; set; }
        public string Password
        {
            private get
            {
                return _password;
            }
            set
            {
                if (_password is not null) return;
                if (string.IsNullOrWhiteSpace(value)) return;
                value = value.Trim();
                if (value.Length < 8 || value.Length > 32) return;
                _password = value;
            }
        }
        #endregion

        #region Méthodes
        public bool CheckLogin(string email, string password)
        {
            return Email == email && Password == password;
        }
        #endregion
    }
}
