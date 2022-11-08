using System;
using System.Collections.Generic;
using System.Linq;

public class BePositive_broken
{
	public static void Main()
	{
		int countSequences = int.Parse(Console.ReadLine());

		for (int i = 0; i < countSequences; i++)
		{
			List<int> numbers = Console.ReadLine()
				.Split(' ', StringSplitOptions.RemoveEmptyEntries)
				.Select(n => int.Parse(n))
				.ToList();
			
			List<int> results = new List<int>();	
			

			

			for (int j = 0; j < numbers.Count; j++)
			{
				int currentNum = numbers[j];

				if (currentNum >= 0)
				{
					results.Add(currentNum);
				}
				else
				{
					if(j < numbers.Count - 1)
                    {
						int currentAndNextNum = numbers[j] + numbers[j + 1];

						if (currentAndNextNum >= 0)
						{
							results.Add(currentAndNextNum);
						}
					}
					

					
					j++;
				}
			}

			if (results.Count == 0)
			{
				Console.WriteLine("(empty)");
			}
			else
            {
                Console.WriteLine(String.Join(" ",results));
            }
		}
	}
}