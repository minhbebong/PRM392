using System;
using System.Collections.Generic;

#nullable disable

namespace Q1.Models
{
    public partial class DailyReport
    {
        public string Country { get; set; }
        public DateTime Date { get; set; }
        public int NewCases { get; set; }
        public int? NewDeaths { get; set; }
        public int? TotalCases { get; set; }
        public int? TotalDeaths { get; set; }
    }
}
