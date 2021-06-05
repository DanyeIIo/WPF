using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace authorization
{
    public class User
    {
        public string Login { get; private set; }
        public string Password { get; private set; }
        public string Nickname { get; private set; }
        public string Position { get; private set; }
        public User()
        {
            Login = string.Empty;
            Password = string.Empty;
            Nickname = string.Empty;
            Position = string.Empty;
        }
        public User(string login, string password, string nickname, string position)
        {
            Login = login;
            Password = password;
            Nickname = nickname;
            Position = position;
        }
    }
}
