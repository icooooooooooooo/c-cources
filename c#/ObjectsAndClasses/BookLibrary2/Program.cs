using System;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;

namespace BookLibrary2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Book> myBooks = new List<Book>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                Book book = new Book();

                book.Title = input[0];
                book.Author = input[1];
                book.Publisher = input[2];
                book.ReleaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                book.ISBNnumber = int.Parse(input[4]);
                book.Price = double.Parse(input[5]);
                myBooks.Add(book);
            }

            DateTime instance = DateTime.ParseExact(Console.ReadLine(),"dd.MM.yyyy", CultureInfo.InvariantCulture);

            Library myLibrary = new Library();
            myLibrary.Books = myBooks;

            foreach (var book in myLibrary.Books.Where(x => x.ReleaseDate>instance).OrderBy(x=> x.ReleaseDate).ThenBy(x=> x.Title))
            {
                Console.WriteLine($"{book.Title} -> {book.ReleaseDate.ToString("dd.MM.yyyy")}");

            }

        }
    }

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; } //in dd.MM.yyyy format
        public int ISBNnumber { get; set; }
        public double Price { get; set; }

    }

    public class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }

    }
}
