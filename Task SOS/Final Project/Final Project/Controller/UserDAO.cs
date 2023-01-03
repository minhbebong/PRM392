using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Controller
{
    internal class UserDAO
    {
        public Boolean checkLogin(String user,String pass,Boolean checkRobot)
        {
            return (user == "admin" && pass == "123" && checkRobot == true);
        }
    }
}
