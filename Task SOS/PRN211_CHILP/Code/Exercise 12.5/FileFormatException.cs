using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_12._5
{
    class FileFormatException: Exception
    {
        public string DetailMessage { get; set; }

        public FileFormatException(string mess, string errorMessage): base(mess)
        {
            DetailMessage = errorMessage;
        }
    }
}
