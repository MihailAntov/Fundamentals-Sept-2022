using System;


namespace _08.PersonalException
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            
            
            try
            {
                while (true)
                {
                    int input = int.Parse(Console.ReadLine());
                    if (input < 0)
                    {
                        throw new MyException();
                    }
                    Console.WriteLine(input);
                }
            }
            catch (MyException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            
            
            

        }
    }

    public class MyException : Exception
    {
        public MyException() : base("My first exception is awesome!!!") { }
       
        
    }
}
