namespace Q3
{
    public class ServiceEm
    {
        public string Title { get; set; }
        public string FreeType { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public double Amount { get; set; }
        public string Employee { get; set; }

        public ServiceEm()
        {
        }

        public ServiceEm(string title, string freeType, int month, int year, double amount, string employee)
        {
            Title = title;
            FreeType = freeType;
            Month = month;
            Year = year;
            Amount = amount;
            Employee = employee;
        }
    }
}
