using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.CardsGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayerHand = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n))
                .ToList();

            List<int> secondPlayerHand = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n))
                .ToList();

            while (Math.Min(firstPlayerHand.Count, secondPlayerHand.Count) > 0)
            {
                int playerOneCard = firstPlayerHand[0];
                int playerTwoCard = secondPlayerHand[0];

                
                firstPlayerHand.RemoveAt(0);
                secondPlayerHand.RemoveAt(0);
                
                if (playerOneCard > playerTwoCard)
                {
                    firstPlayerHand.Add(playerOneCard);
                    firstPlayerHand.Add(playerTwoCard); 
                }
                else if (playerOneCard < playerTwoCard)
                {
                    secondPlayerHand.Add(playerTwoCard);
                    secondPlayerHand.Add(playerOneCard);
                }
            }

            if (firstPlayerHand.Count == 0)
            {
                Console.WriteLine($"Second player wins! Sum: {secondPlayerHand.Sum()}");
            }
            else
            {
                Console.WriteLine($"First player wins! Sum: {firstPlayerHand.Sum()}");
            }
        }
    }
}
