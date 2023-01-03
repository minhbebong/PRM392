using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Book
    {
        int code;
        string title;
        int year;
        List<string> authors;

        public int Code { get; set; }
        public string Title { get { return title; } 
            set { 
                if (String.IsNullOrEmpty(value))
                {
                    throw new Exception("Title can not be blank");
                } else
                {
                    title = value;
                }
            } }
        public int Year { get; set; }
        public List<string> Authors { get; set; }
        
        public Book()
        {
        }

        public Book(int code, string title, int year)
        {
            Code = code;
            Title = title;
            Year = year;
        }
        public void AddAuthor(string s)
        {
            if (authors is null)
                authors = new List<string>();
            foreach (string s2 in authors)
            {
                if (s.Equals(s2))
                {
                    throw new Exception("Author is already exists!");
                    return;
                }
            }
            authors.Add(s);
        }


        public override string ToString()
        {
            return $"Book's Info: {Code} - {Title} - {Year} {showAuthor()}";
        }
        public string showAuthor()
        {
            string rs = "\nAuthors of book:\n";
            foreach (string au in authors)
            {
                rs += au + "\n";
            }
            return rs;
        }
    }
}
