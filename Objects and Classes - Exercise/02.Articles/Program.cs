using System;

namespace _02.Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Articles 2.0
            
            //int numberOfArticles = int.Parse(Console.ReadLine());
            //Article[] articles = new Article[numberOfArticles];
            //for (int i = 0; i < numberOfArticles; i++)
            //{
            //    try
            //    {
            //        string[] input = Console.ReadLine().Split(", ");
            //        Article article = new Article(input[0], input[1], input[2]);
            //        articles[i] = article;
            //    }
            //    catch 
            //    {
            //        continue;
            //    }

            //}
            //foreach(Article article in articles)
            //{
            //    Console.WriteLine(article.ToString());
            //}

            //End of Articles 2.0



            //Articles 1.0
            string[] inputArgs = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);
            Article article = new Article(inputArgs[0], inputArgs[1], inputArgs[2]);
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] subInput = Console.ReadLine().Split(": ");
                switch (subInput[0])
                {
                    case "Edit":
                        article.Edit(subInput[1]);
                        break;
                    case "ChangeAuthor":
                        article.ChangeAuthor(subInput[1]);
                        break;
                    case "Rename":
                        article.Rename(subInput[1]);
                        break;

                }

            }

            Console.WriteLine(article.ToString());

            //End of Articles 1.0
        }
    }
    public class Article
    {
        public Article( string title, string content, string author) 
        { 
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public void Edit (string newContent)
        {
            this.Content = newContent;
        }

        public void ChangeAuthor(string newAuthor)
        {
            this.Author = newAuthor;
        }

        public void Rename(string newTitle)
        {
            this.Title = newTitle;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
