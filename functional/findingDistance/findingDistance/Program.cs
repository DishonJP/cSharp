using System;

namespace functionalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            
            switch (Console.ReadLine())
            {
                case "distance":
                    Console.WriteLine("Enter two points x and y");
                    double x = Convert.ToDouble(Console.ReadLine());
                    double y = Convert.ToDouble(Console.ReadLine());
                    double distance = FindingDistance.findDistance(x, y);
                    Console.WriteLine(distance.ToString());
                    break;
                case "quadratic":
                    Console.WriteLine("enter the value for a,b and c");
                    int a = Convert.ToInt32(Console.ReadLine());
                    int b = Convert.ToInt32(Console.ReadLine());
                    int c = Convert.ToInt32(Console.ReadLine());
                    double equation = Quadratic.quadraticEquation(a, b, c);
                    Console.WriteLine("Quadratic equation of {0} {1} {2} is {3}",a,b,c,equation);
                    break;
                default:
                    break;
            }

        }
    }
}
