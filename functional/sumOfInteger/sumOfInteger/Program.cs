using System;

namespace sumOfInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10] { 1, 2, 3, 4, 5, -2, 7, 8, -1, -5 };
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[i]+array[j]==0)
                    {
                        Console.WriteLine("sun of {0} + {1} are 0", array[i] , array[j]);
                    }
                }
            }
        }
    }
}
