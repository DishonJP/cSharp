using System;

namespace harmonicNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            double holder = 0.0;
            Console.WriteLine("Enter a number to find nth harmonic number");
            int userInput = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= userInput; i++)
            {
                Console.WriteLine("1/{0}", i);
                holder += 1 / (float)i;
            }
            Console.WriteLine("harmonic value of {0} : {1}", userInput, holder);
        }
    }
}
