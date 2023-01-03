using Q1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1.DataAccess
{
    internal class Managerment
    {
        public static List<DEmployee> listAllEmployee()
        {
            return EmployeeDAO.getAllEmployee();
        }
        public static List<string> listAllPosition()
        {
            List<string> allPosition =  EmployeeDAO.getAllPosition();
            allPosition.Insert(0, "All position");
            return allPosition;
        }
        public static List<DEmployee> searchBySex(string sex)
        {
            return EmployeeDAO.searchBySex(sex);
        }
    }
}
