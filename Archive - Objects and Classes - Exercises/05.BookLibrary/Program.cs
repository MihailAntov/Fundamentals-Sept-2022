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
            Dictionary <string, decimal> totalEarnings = new Dictionary<string, decimal>(); 
            foreach (string author in library.Books.Select(n=>n.Author).Distinct())
            {
                decimal total = library.Books
                    .Where(n => n.Author == author)
                    .Select(n => n.Price)
                    .Sum();
                totalEarnings.Add(author, total); 
            }

            foreach(KeyValuePair<string, decimal> entry in totalEarnings
                .OrderByDescending(n=>n.Value)
                .ThenBy(n=>n.Key))
                
            {
                Console.WriteLine($"{entry.Key} -> {entry.Value:f2}");
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
            Name =name;
            books = new List<Book>();
        }
        public string Name { get; set; }
        public List<Book> Books { get { return books; } }
        private List<Book> books;
    }
}
