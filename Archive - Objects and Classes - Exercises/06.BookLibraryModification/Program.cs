using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace _05.BookLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Library library = new Library("Library");
            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string title = cmdArgs[0];
                string author = cmdArgs[1];
                string publisher = cmdArgs[2];
                DateTime publishDate = DateTime.ParseExact(cmdArgs[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                string isbn = cmdArgs[4];
                decimal price = decimal.Parse(cmdArgs[5]);

                library.Books.Add(new Book(title, author, publisher, publishDate, isbn, price));


            }
            DateTime cutoffDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
            foreach (Book book in library.Books
                .Where(n => cutoffDate < n.PublishDate)
                .OrderBy(n => n.PublishDate)
                .ThenBy(n => n.Title))
            {
                string date = book.PublishDate.ToString("dd.MM.yyyy");
                Console.WriteLine($"{book.Title} -> {date}");
            }
        }
    }

    public class Book
    {
        public Book(string title, string author, string publisher, DateTime publishDate, string iSBN, decimal price)
        {
            Title = title;
            Author = author;
            Publisher = publisher;
            PublishDate = publishDate;
            ISBN = iSBN;
            Price = price;
        }

        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime PublishDate { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }
    }

    public class Library
    {
        public Library(string name)
        {
            Name = name;
            books = new List<Book>();
        }
        public string Name { get; set; }
        public List<Book> Books { get { return books; } }
        private List<Book> books;
    }
}
