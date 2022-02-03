using System;

namespace DiceGame // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DiceRoll();
        }

        private static void DiceRoll()
        {
            int playerRandomNum;
            int enemeyRandomNum;

            int playerPoints = 0;
            int enemyPoints = 0;

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Press any key to roll your dice!");
                Console.ReadLine();
                playerRandomNum = random.Next(1, 7);
                Console.WriteLine($"You rolled: {playerRandomNum}");
                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);

                enemeyRandomNum = random.Next(1, 7);
                Console.WriteLine($"Enemey AI rolled : {enemeyRandomNum}");

                if (playerRandomNum > enemeyRandomNum)
                {
                    Console.WriteLine("Congradulations you won!!");
                    playerPoints++;
                }
                else if (playerRandomNum == enemeyRandomNum)
                {
                    Console.WriteLine("Wow it was a tie, What are the chances??");
                }
                else
                {
                    Console.WriteLine("Sorry the AI won..");
                    Console.WriteLine("...");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("Try again?");
                    enemyPoints++;
                }

                Console.WriteLine($"Your Points: {playerPoints}\n" +
                    $"AI Points: {enemyPoints}");
            }

            
        }
    }
}

