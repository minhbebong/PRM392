using System.Collections.Generic;
using System.Data;

namespace Q3.Controllers
{
    public class Service
    {
        public string title { get; set; }
        public string FeeType { get; set; }
        public string Month { get; set; }
        public string Year { get; set; }
        public string Amount { get; set; }
        public string name { get; set; }

        public Service()
        {
        }

        public Service(string title, string feeType, string month, string year, string amount, string name)
        {
            this.title = title;
            FeeType = feeType;
            Month = month;
            Year = year;
            Amount = amount;
            this.name = name;
        }
    }

    public class DAOEMP
    {
        public List<Service> listAll(string where = "")
        {
            string sql = @"select a.RoomTitle, a.FeeType, a.Month
, a.Year, a.Amount, b.Name
from [Services] a left join Employees b
on a.Employee = b.Id " + where;

            DataTable dt = DBContext.GetDataBySql(sql);
            List<Service> list = new List<Service>();
            foreach (DataRow dr in dt.Rows)
                list.Add(new Service(
                    dr[0].ToString(),
                    dr[1].ToString(),
                    dr[2].ToString(),
                    dr[3].ToString(),
                    dr[4].ToString(),
                    dr[5].ToString()

                    ));
            return list;

        }
    }

}
