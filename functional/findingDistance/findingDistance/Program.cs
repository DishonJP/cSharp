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
                    double distance = findingDistance.findDistance(x, y);
                    Console.WriteLine(distance.ToString());
                    break;
                default:
                    break;
            }

        }
    }
}
