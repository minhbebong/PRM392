using System;
using System.Collections.Generic;

namespace PE_PRN211_SP23_554489_VinhDQ.Models
{
    public partial class BookCategory
    {
        public BookCategory()
        {
            Books = new HashSet<Book>();
        }

        public int BookCategoryId { get; set; }
        public string BookGenreType { get; set; } = null!;
        public string Description { get; set; } = null!;

        public virtual ICollection<Book> Books { get; set; }
        public override string ToString()
        {
            return BookGenreType;
        }
    }
}
