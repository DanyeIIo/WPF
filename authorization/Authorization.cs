using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace authorization
{
    public static class Authorization
    {
        static List<User> users = new List<User>()
        {
            new User("Clown","3228","Clowner","Clowneveloper"),
            new User("Aizat077","8088","Janibek","Clerk"),
            new User("Zhanna123", "123q", "Zhanibek", "Driver"),
            new User("RealMan","1337","Hasbik","Boss")
        };

        public static bool CheckAutorizationUser(User user)
        {
            return users
                .Any(x => x.Login == user.Login && x.Password == user.Password);
        }

        public static User GetAutorizatedUser(string login,string password)
        {
            User newUser = users
                .FirstOrDefault(x => x.Login == login && x.Password == password);
            
            //if (newUser is null) 
            //    throw new ArgumentException($"Incorrect {nameof(login)} or {nameof(password)}");
            
            return newUser;
        }
    }
}
