using System;

namespace flipCoin
{
    class Program
    {
        static void Main(string[] args)
        {
			try
			{
                Console.WriteLine("How many times do u like flip a coin");
                int times = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(times);
                Random random = new Random();
                int playerA = 0;
                int playerB = 0;
                for (int i = 0; i < times; i++)
                {
                    Console.WriteLine("Round : "+i);
                    float playerOne =(float)random.NextDouble();
                    float playerTwo = (float)random.NextDouble();
                    if (playerOne>playerTwo)
                    {
                        Console.WriteLine("player one wins in round " + i);
                        playerA++;
                    }
                    else
                    {
                        Console.WriteLine("player two wins in round " + i);
                        playerB++;
                    }
                        }
                if (playerA>playerB)
                {
                    Console.WriteLine("player one wins");
                }else if (playerB > playerA)
                {
                    Console.WriteLine("player two wins");
                }
                else
                {
                    Console.WriteLine("Draw");
                }
            }
			catch (Exception)
			{

                Console.WriteLine("no");
			}
        }
    }
}
