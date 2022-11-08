using System;

public class Substring_broken
{
	public static void Main()
	{
		string text = Console.ReadLine();
		int count = int.Parse(Console.ReadLine());

		char search = 'p';
		bool hasMatch = false;

		for (int i = 0; i < text.Length; i++)
		{
			if (text[i] == search)
			{
				hasMatch = true;
				int matchLength = count+1;
				if (i+matchLength >= text.Length)
				{
					matchLength = text.Length - i;
				}

				string matchedString = text.Substring(i, matchLength);
				Console.WriteLine(matchedString);
				text = text.Substring(i+matchLength);
				i = -1;
			}
		}

		if (!hasMatch)
		{
			Console.WriteLine("no");
		}
	}
}
