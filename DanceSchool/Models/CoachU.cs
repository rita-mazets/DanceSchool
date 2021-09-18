using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanceSchool
{
    public class CoachU: Admin
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string About { get; set; }
        public string Picture { get; set; }

        public CoachU(): base() { }
        public CoachU(int id) : base(id) { }

        public CoachU(int id, string login, string password, string name, string surname, string about) : base(id, login, password)
        {
            Name = name;
            Surname = surname;
            About = about;
        }
    }
}
