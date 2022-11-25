using System;
using System.Text;

namespace _01.WorldTour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string route = Console.ReadLine();
            string input;

            while((input = Console.ReadLine()) != "Travel")
            {
                string[] inputArgs = input.Split(":", StringSplitOptions.RemoveEmptyEntries);
                string command = inputArgs[0];

                switch(command)
                {
                    case "Add Stop":
                        int newIndex = int.Parse(inputArgs[1]);
                        if(newIndex <0 || newIndex > route.Length)
                        {
                            Console.WriteLine(route);
                            continue;
                        }
                        string newStop = inputArgs[2];
                        route = route.Insert(newIndex, newStop);
                        Console.WriteLine(route);
                        break;
                    case "Remove Stop":
                        int startIndex = int.Parse(inputArgs[1]);
                        int endIndex = int.Parse(inputArgs[2]);
                        
                        if(startIndex< 0 || endIndex >= route.Length)
                        {
                            Console.WriteLine(route);
                            continue;
                        }

                        route = route.Remove(startIndex, endIndex - startIndex+1);
                        Console.WriteLine(route);
                        break;
                    case "Switch":
                        string oldString = inputArgs[1];
                        string newString = inputArgs[2];
                        route = route.Replace(oldString, newString);
                        Console.WriteLine(route);
                        break;
                }
                
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {route}");
        }
    }
}
