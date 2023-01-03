using System;
using System.Collections.Generic;

#nullable disable

namespace Q1.Models
{
    public partial class InfectedCase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte? Age { get; set; }
        public bool? Sex { get; set; }
        public string Nationality { get; set; }
        public string Province { get; set; }
        public string TraveledFrom { get; set; }
        public string HistoryOfEpidemiology { get; set; }
        public int? RelatedTo { get; set; }
        public DateTime? ConfirmationDate { get; set; }
    }
}
