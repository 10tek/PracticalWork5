using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW5
{
    public class User
    {
        public string FIO { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public static bool operator ==(User firstUser, User secondUser)
        {
            return firstUser.FIO == secondUser.FIO;
        }

        public static bool operator !=(User firstUser, User secondUser)
        {
            return !(firstUser == secondUser);
        }
    }
}
