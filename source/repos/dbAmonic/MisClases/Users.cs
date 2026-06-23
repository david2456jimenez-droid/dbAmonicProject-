using System;
using System.Collections.Generic;
using System.Text;

namespace MisClases
{
    public class Users
    {
        public int UserID { get; set; }

        public string Email { get; set; }

        public int Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public bool Active { get; set; }

        public string TitleOffices { get; set; }

        public string TitleRoles { get; set; }
    

    public int Edad
        {
            get
            {
                int edad = DateTime.Now.Year - BirthDate.Year;
                if (DateTime.Now < BirthDate.AddYears(edad))
                {
                    edad--;
                }

                return edad;
            }
        }
    }
}
