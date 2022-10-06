using System;

namespace _02.Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfArticles = int.Parse(Console.ReadLine());
            Article[] articles = new Article[numberOfArticles];
            for (int i = 0; i < numberOfArticles; i++)
            {
                try
                {
                    string[] input = Console.ReadLine().Split(", ");
                    Article article = new Article(input[0], input[1], input[2]);
                    articles[i] = article;
                }
                catch 
                {
                    continue;
                }
                
            }
            foreach(Article article in articles)
            {
                Console.WriteLine(article.ToString());
            }
            
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 0; i < n; i++)
            //{
            //    string[] subInput = Console.ReadLine().Split(": ");
            //    switch (subInput[0])
            //    {
            //        case "Edit":
            //            article.Edit(subInput[1]);
            //            break;
            //        case "ChangeAuthor":
            //            article.ChangeAuthor(subInput[1]);
            //            break;
            //        case "Rename":
            //            article.Rename(subInput[1]);
            //            break;

            //    }

            //}

            //Console.WriteLine(article.ToString());
        }
    }
    public class Article
    {
        public Article( string _title, string _content, string _author) 
        { 
            title = _title;
            content = _content;
            author = _author;
        }
        string title;
        string content;
        string author;
        public void Edit (string newContent)
        {
            this.content = newContent;
        }

        public void ChangeAuthor(string newAuthor)
        {
            this.author = newAuthor;
        }

        public void Rename(string newTitle)
        {
            this.title = newTitle;
        }

        public override string ToString()
        {
            return $"{title} - {content}: {author}";
        }
    }
}
