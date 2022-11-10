using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.HandsOfCards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            Dictionary<string, int> scores = new Dictionary<string, int>();
            Dictionary<string, int> powers = new Dictionary<string, int>
            {
                {"2", 2 },
                {"3", 3 },
                {"4", 4 },
                {"5", 5 },
                {"6", 6 },
                {"7", 7 },
                {"8", 8 },
                {"9", 9 },
                {"10",10 },
                {"J", 11 },
                {"Q", 12 },
                {"K", 13 },
                {"A", 14 },
            };
            Dictionary<string, int> types = new Dictionary<string, int> 
            {
                {"S",4 },
                {"H",3 },
                {"D",2 },
                {"C",1 }
            };
            Dictionary<string, List<string>> hands = new Dictionary<string, List<string>>();

            while((input = Console.ReadLine()) != "JOKER")
            {
                string[] inputArgs = input.Split(": ", StringSplitOptions.RemoveEmptyEntries);

                string name = inputArgs[0];
                if(!scores.ContainsKey(name))
                {
                    scores.Add(name, 0);
                }
                
                string[] cardInput = inputArgs[1].Split(", ", StringSplitOptions.RemoveEmptyEntries);
                
                if(!hands.ContainsKey(name))
                {
                    hands.Add(name, new List<string>());
                }


                for(int i = 0; i < cardInput.Length; i++)
                {
                    string nextCard = cardInput[i];
                    if (hands[name].Contains(nextCard))
                    {
                        continue;
                    }
                    string power = nextCard.Substring(0, nextCard.Length - 1);
                    string type = nextCard[nextCard.Length - 1].ToString();
                    hands[name].Add(nextCard);
                    scores[name] += powers[power] * types[type];

                }

            }

            foreach(KeyValuePair<string, int> score in scores)
            {
                Console.WriteLine($"{score.Key}: {score.Value}");
            }
        }
    }
}
