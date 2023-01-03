using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class DAO
    {
        public int AddRoom(room ro)
        {
            int n = 0;
            string sql = @"
insert into Rooms(Title, Square, Floor, Description, Comment)
values ("+ro.title+", "+ro.roomSquare+","+ro.floor+"" +
", '"+ro.description+"', '"+ro.comment+"')" ;
            n = DBContext.executeSQL(sql);
            return n;
        }
    }
}
