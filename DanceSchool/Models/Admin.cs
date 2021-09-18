using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanceSchool
{
    public class Admin
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public Admin(){}
        public Admin(int id)
        {
            Id = id;
        }
        public Admin(int id, string login, string password):this(id)
        {
            Login = login;
            Password = password;
        }
    }
}
