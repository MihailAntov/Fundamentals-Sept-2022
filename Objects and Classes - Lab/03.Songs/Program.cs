using System;
using System.Linq;
using System.Collections.Generic;
namespace _03.Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();

            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine()
                    .Split("_", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                songs.Add(new Song(cmdArgs[0], cmdArgs[1], cmdArgs[2]));
            }

            string filter = Console.ReadLine();
            if(filter!= "all")
            {
                foreach (Song s in songs.Where(s => s._typeList == $"{filter}"))
                {
                    Console.WriteLine(s._name);
                }
            }
            else
            {
                foreach(Song s in songs)
                {
                    Console.WriteLine(s._name);
                }
            }
            
        }
    }

    public class Song
    {
        public Song(string typeList, string name, string time) 
        {
            _typeList = typeList;
            _name = name;
            _time = time;
        }
        public string _typeList;
        public string _name;
        public string _time;
    }
}
