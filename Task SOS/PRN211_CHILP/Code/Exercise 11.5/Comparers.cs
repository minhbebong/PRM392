using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_11._5
{
    class DescUserNameComparer: IComparer<Account>
    {
        public int Compare(Account first, Account second)
        {
            return -first.Username.CompareTo(second.Username);
        }
    }

    class PasswordComparer : IComparer<Account>
    {
        public int Compare(Account first, Account second)
        {
            return first.Password.CompareTo(second.Password);
        }
    }

    class TypeComparer : IComparer<Account>
    {
        public int Compare(Account first, Account second)
        {
            if (first.GetType().Name.Equals(second.GetType().Name))
                return first.Username.CompareTo(second.Username);
            else
                return first.GetType().Name.CompareTo(second.GetType().Name);
        }
    }
}
