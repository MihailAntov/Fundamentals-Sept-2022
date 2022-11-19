using System;
using System.IO;
using System.Text;
using System.Linq;
namespace _05.WriteToFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(),"sample_text.txt");
            string text = File.ReadAllText(path);
            StringBuilder str = new StringBuilder();
            char[] punctuation = new char[] { '.', ',', '!', '?', ':' };
            foreach (char c in text)
            {
                if(!punctuation.Contains(c))
                {
                    str.Append(c);
                }
            }

            string writePath = Path.Combine(Directory.GetCurrentDirectory(), "result.txt");
            File.WriteAllText(writePath, str.ToString());
        }
    }
}
