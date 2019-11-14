using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;

namespace BookLibrary
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
            
            Library myLibrary = new Library();
            myLibrary.Books = myBooks;

            foreach (var item in myBooks)
            {
                Console.WriteLine(item.Author);
            }
            foreach (var book in myLibrary.Books.GroupBy(x => x.Author).OrderByDescending(x => x.Sum(y => y.Price)).ThenBy(x => x.Key))
            {                
                Console.WriteLine($"{book.Key} -> {book.Sum(x => x.Price):F2}");
            }
        }
    }
}
