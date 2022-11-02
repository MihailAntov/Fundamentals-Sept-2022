using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace _1.WinningTicket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string splitter = @"[,\s]+";
            string[] tickets = Regex.Split(Console.ReadLine(), splitter);
            List<string> validTickets = new List<string>();
            string halfTicketChecker = @"([$@#^])\1{5,}";

            
            foreach(string ticket in tickets)
            {
                if(ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }
                
                string firstHalf = ticket.Substring(0, 10);
                string secondHalf = ticket.Substring(10, 10);

                string winningsInFirstHalf = Regex.Match(firstHalf, halfTicketChecker).Value;
                string winningsInSecondHalf = Regex.Match(secondHalf, halfTicketChecker).Value;

                if(winningsInFirstHalf.Length==0 || winningsInSecondHalf.Length==0)
                {
                    Console.WriteLine($"ticket \"{ticket}\" - no match");
                    continue;
                    
                }

                if (winningsInFirstHalf[0]!= winningsInSecondHalf[0])
                {
                    Console.WriteLine($"ticket \"{ticket}\" - no match");
                    continue;
                }

                if(winningsInFirstHalf.Length + winningsInSecondHalf.Length == 20)
                {
                    Console.WriteLine($"ticket \"{ticket}\" - 10{winningsInFirstHalf[0]} Jackpot!");
                }
                else
                {
                    int matchLength = Math.Min(winningsInFirstHalf.Length, winningsInSecondHalf.Length);
                    Console.WriteLine($"ticket \"{ticket}\" - {matchLength}{winningsInFirstHalf[0]}");
                }

            }

        }
    }
}
