using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_04_Proprietes.Models
{
    internal class Personne
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        private DateOnly _birthdate;

        public DateOnly BirthDate
        {
            private get { return _birthdate; }
            set { _birthdate = value; }
        }

        public int YearsOld
        {
            get
            {
                int age = DateTime.Now.Year - _birthdate.Year;
                if(
                    (_birthdate.Month > DateTime.Now.Month)
                    || (
                    _birthdate.Month == DateTime.Now.Month 
                    && 
                    _birthdate.Day > DateTime.Now.Day)
                    )
                {
                    age--;
                }
                return age;
            }
        }

    }
}
