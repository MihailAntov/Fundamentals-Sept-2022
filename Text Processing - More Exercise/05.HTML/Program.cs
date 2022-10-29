using System;
using System.Collections.Generic;
namespace _05.HTML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string title = Console.ReadLine();
            string content = Console.ReadLine();
            List<string> comments = new List<string>();
            string input;

            while ((input = Console.ReadLine()) != "end of comments")
            {
                comments.Add(input);
            }

            Console.WriteLine("<h1>");
            Console.WriteLine($"\t{title}");
            Console.WriteLine("</h1>");
            Console.WriteLine("<article>");
            Console.WriteLine($"\t{content}");
            Console.WriteLine("</article>");
            foreach(string comment in comments)
            {
                Console.WriteLine("<div>");
                Console.WriteLine($"\t{comment}");
                Console.WriteLine("</div>");

            }
        }
    }
}
