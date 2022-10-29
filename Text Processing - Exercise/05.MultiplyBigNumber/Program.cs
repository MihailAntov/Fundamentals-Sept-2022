using System;


namespace _05.MultiplyBigNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());
            int carry = 0;
            string result = String.Empty;

            for (int i = number.Length -1; i >= 0; i--)
            {
                int currentDigit = int.Parse(number[i].ToString());
                int currentProduct = currentDigit * multiplier + carry;

                result = result.Insert(0, (currentProduct % 10).ToString());
                carry = currentProduct / 10;
            }
            
            if(carry!= 0)
            {
                result = result.Insert(0, carry.ToString());
            }

            while (result[0]=='0')
            {
                result = result.Substring(1);
                if(result.Length == 1)
                {
                    break;
                }

            }
            Console.WriteLine(result);
            
        }
    }
}
