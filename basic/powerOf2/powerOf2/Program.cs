using System;

namespace powerOf2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int value = Convert.ToInt32(Console.ReadLine());
            int power=  FindPower.powerOf2(value);
            Console.WriteLine(power);
        }
    }
}
