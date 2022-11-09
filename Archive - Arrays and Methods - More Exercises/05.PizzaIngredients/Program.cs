using System;
using System.Linq;
namespace _05.PizzaIngredients
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] ingredients = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int length = int.Parse(Console.ReadLine());
            string[] filteredIngredients = ingredients
                .Where(n => n.Length == length)
                .ToArray();
            string[] usedIngredients = new string[10];
            if (filteredIngredients.Length != 0)
            {
                

                for (int i = 0; i < filteredIngredients.Length; i++)
                {
                    usedIngredients[i] = filteredIngredients[i];
                    Console.WriteLine($"Adding {usedIngredients[i]}.");
                    if(i == 9)
                    {
                        break;
                    }
                }

                
            }
            usedIngredients = usedIngredients
                .Where(n => n != null)
                .ToArray();

            Console.WriteLine($"Made pizza with total of {usedIngredients.Length} ingredients.");

            Console.WriteLine($"The ingredients are: {string.Join(", ",usedIngredients)}.");

        }
    }
}
