using System;

namespace leapYear
{
    class Program
    {
        static void Main(string[] args)
        {
			try
			{
                Console.WriteLine("Enter a number to find leap year or not");
                int year = Convert.ToInt32(Console.ReadLine());
                string message;
                if (year.ToString().Length == 4)
                {
                    message = year % 400 == 0 || year % 4 == 0 && year % 100 != 0 ? "Leap year" : "not a leap year";
                }
                else
                {
                    message = "year should be greater than 1000";
                }
                Console.WriteLine(message);
            }
			catch (Exception)
			{
                Console.WriteLine("should need to be number");
			}
        }
    }
}
