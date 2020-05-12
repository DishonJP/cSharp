using System;

namespace primeFactor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            string message = findPrimeFactor(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine(message);
        }
       public static string findPrimeFactor(int number)
        {
            string message = "prime factor of " + number + " are ";
            int checkPrimeFactor = 1;
            int userInput = number;
            for (int i = number / 2; i >=2; i--)
            {
                // Console.WriteLine(findPrimeNumber(i)+" "+i); 
                if (findPrimeNumber(i))
                {
                    if (number % i == 0)
                    {
                        Console.WriteLine(number+" "+i);
                        checkPrimeFactor *= i;
                        message = message + i + "*";
                        number /= i;
                        i++;
                    }
                }
            }
            if (checkPrimeFactor==userInput)
            {
                Console.WriteLine("done");
                return message;
            }
            Console.WriteLine("nope");
            return "Not prime factor";
        }
        public static bool findPrimeNumber(int value)
        {
            int i = 2;
            while (i<=value/2)
            {
                if (value % i == 0)
                {
                    return false;
                }
                i++;
            }
            return true;
        }
    }
}
