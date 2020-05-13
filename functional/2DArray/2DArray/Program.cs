using System;

namespace _2DArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2D Array");
            Console.WriteLine("Enter no of rows");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter no of column");
            int column = Convert.ToInt32(Console.ReadLine());
            creating2DArray(rows, column);
        }
        static void creating2DArray(int x,int y)
        {
            Console.WriteLine("Enter the type of data u like to store");
            
            switch (Console.ReadLine())
            {
                case "int":
                    createIntArray(x, y);
                    break;

                case "double":
                    createDoubleArray(x, y);
                    break;

                case "boolean":
                    createBoolArray(x, y);
                    break;
                default:
                    Console.WriteLine("type is not valid");
                    break;
            }
        }
        static void createIntArray(int x, int y)
        {
            int[,] twoDArray = new int[x, y];
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.WriteLine("Enter value for index {0} and {1}",i,j);
                    twoDArray[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            foreach (var item in twoDArray)
            {
                Console.WriteLine(item);
            }
        }
        static void createDoubleArray(int x, int y)
        {
            double[,] twoDArray = new double[x, y];
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.WriteLine("Enter value for index {0} and {1}", i, j);
                    twoDArray[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }
            foreach (var item in twoDArray)
            {
                Console.WriteLine(item);
            }
        }
        static void createBoolArray(int x, int y)
        {
            bool[,] twoDArray = new bool[x, y];
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.WriteLine("Enter value for index {0} and {1}", i, j);
                    twoDArray[i, j] = Convert.ToBoolean(Console.ReadLine());
                }
            }
            foreach (var item in twoDArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
