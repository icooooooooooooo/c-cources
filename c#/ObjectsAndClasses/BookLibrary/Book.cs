using System;
using System.Collections.Generic;
using System.Text;

namespace BookLibrary
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; } //in dd.MM.yyyy format
        public int ISBNnumber { get; set; } 
        public double Price { get; set; } 

        
    }
}
