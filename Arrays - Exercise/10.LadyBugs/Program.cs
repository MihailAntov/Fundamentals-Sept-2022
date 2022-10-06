using System;
using System.Linq;

namespace _10.LadyBugs
{
    internal class Program
    {


        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            

            int[] field = new int[fieldSize];
            for (int i = 0; i < fieldSize; i++)
            {
                field[i] = 0;
            }
            int[] bugStartingIndices = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(n => int.Parse(n)).ToArray();

            for (int i = 0; i < bugStartingIndices.Length; i++)
            {
                if(bugStartingIndices[i] >= 0 && bugStartingIndices[i] < fieldSize)
                {
                    field[bugStartingIndices[i]] = 1;
                }
                
            }

            //Console.WriteLine(String.Join(" ", field));
            string input = string.Empty;

            void moveLeft(int origin, int spaces, int attempt)
            {
                
                if(origin-(spaces * attempt) <0 || origin-(spaces * attempt) > fieldSize-1)
                {
                    return;
                }
                else if (field[origin - (spaces*attempt)] == 1)
                {
                    
                    moveLeft(origin, spaces, attempt+1) ;
                }
                else
                {
                    field[origin - (spaces * attempt)] = 1;
                }
            }

            void moveRight(int origin, int spaces, int attempt)
            {
                
                if (origin + (spaces * attempt) < 0 || origin + (spaces * attempt) > fieldSize-1)
                {
                    return;
                }
                else if (field[origin+ (spaces * attempt)] == 1)
                {

                    
                    moveRight(origin, spaces, attempt+1);
                }
                else
                {
                    field[origin + (spaces * attempt)] = 1;
                }
            }
            while (input != "end")
            {
                input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }

                string[] command = input.Split(" ");
                if (int.Parse(command[0])<0 || int.Parse(command[0]) > fieldSize-1)
                {
                    continue;
                }

                if (field[int.Parse(command[0])] == 0)
                {
                    continue;
                }
                else
                {
                    field[int.Parse(command[0])] = 0;
                    switch (command[1])
                    {
                        case "left":
                            moveLeft(int.Parse(command[0]), int.Parse(command[2]), 1);
                            break;
                        case "right":
                            moveRight(int.Parse(command[0]), int.Parse(command[2]), 1);
                            break;

                            
                    }
                }
                //Console.WriteLine(String.Join(" ", field));
            }

            Console.WriteLine(String.Join(" ", field));
        }
    }
}
