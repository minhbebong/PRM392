using System;
using System.Collections.Generic;

#nullable disable

namespace Q3.Models
{
    public partial class Author
    {
        public Author()
        {
            AuthorBooks = new HashSet<AuthorBook>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Dob { get; set; }
        public string Description { get; set; }

        public virtual ICollection<AuthorBook> AuthorBooks { get; set; }
    }
}
