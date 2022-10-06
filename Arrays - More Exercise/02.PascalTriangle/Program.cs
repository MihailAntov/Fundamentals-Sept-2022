using System;

namespace _02.PascalTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] previousRow = new int[1] {0};
            int[] currentRow;

            for (int i = 0; i <n; i++)
            {
                currentRow = new int[i+1];
                for (int j = 0; j < currentRow.Length; j++)
                {
                    if (j == 0)
                    {
                        if (i == 0)
                        {
                            currentRow[j] = 1;
                        }
                        else
                        {
                            currentRow[j] = previousRow[j];
                        }
                        
                    }
                    else if (j == currentRow.Length - 1)
                    {
                        currentRow[j] = previousRow[j-1];
                    }
                    else
                    {
                        currentRow[j] = previousRow[j-1] + previousRow[j];
                    }
                    
                    
                }
                Console.WriteLine(String.Join(" ", currentRow));
                previousRow = currentRow;
            }
        }
    }
}
