using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PRN211_Assignment2.Models
{
    public partial class Cart
    {
        public int RecordId { get; set; }
        public string CartId { get; set; } = null!;

        public int AlbumId { get; set; }
        public int Count { get; set; }
        public DateTime DateCreated { get; set; }

        public virtual Album Album { get; set; } = null!;
    }
}
