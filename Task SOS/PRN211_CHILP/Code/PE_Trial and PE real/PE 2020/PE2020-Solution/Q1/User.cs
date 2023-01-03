using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    public class User
    {
        string username;
        string email;
        int roleid;
        public string Username { get; set; }
        public string Email { get; set; }
        public int Roleid { get; set; }

        public User()
        {
            Username = "anhnhthe150726";
            Email = "anhnhthe150726@gmail.com";
            Roleid = 1;
        }

        public User(string username, string email, int roleid)
        {
            Username = username;
            Email = email;
            Roleid = roleid;
        }

        public override string ToString()
        {
            return $"User Info: \nUsername: {Username}, Email: {Email}, Roleid: {Roleid}";
        }

        public override bool Equals(object obj)
        {

            

            if (!(obj is User)) 
            {
                throw new Exception("The item is not an user!");
                return false;
                //Console.WriteLine("The item is not an user!");
                
            }

            User u = (User)obj;
            return this.Username.Equals(u.Username);
        }
    }
}
