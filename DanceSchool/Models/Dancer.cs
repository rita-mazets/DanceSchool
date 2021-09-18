using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanceSchool
{
    public class Dancer: Admin
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Dancer(int id) : base(id) { }
        public Dancer(int id, string login, string password, string name, string surname) : base(id, login, password)
        {
            Name = name;
            Surname = surname;
        }
    }
}
