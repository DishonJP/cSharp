using System;

namespace functionalPrograms
{   
    class Quadratic
    {
        public static double quadraticEquation(int a,int b, int c)
        {
            double rootX = (-b + Math.Sqrt(delta(a, b, c))/(2*a));
            double rootY= (-b - Math.Sqrt(delta(a, b, c)) / (2 * a));
            return a*Math.Sqrt(rootX)+b*rootY+c;
        }
        static double delta(int a,int b,int c)
        {
            return (b*b)-(4*a*c);
        }
    }
}
