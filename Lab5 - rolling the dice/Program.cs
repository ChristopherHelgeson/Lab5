using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5___rolling_the_dice
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            int dieSides = 0;

            Console.Write("Welcome to the Grand Circus Casino!\n\nRoll the dice? (y/n): ");
            string play = Console.ReadLine();

            while (play == "y" || play == "Y")
            {
                Console.Write("\nHow many sides on each die?: ");
                dieSides = int.Parse(Console.ReadLine());
                
                string sameDiceAgain = "y";
                while (sameDiceAgain == "y" || sameDiceAgain == "Y")
                {
                    RollDice(rng, dieSides);

                    Console.Write("Roll same dice again? (y/n): ");
                    sameDiceAgain = Console.ReadLine();
                }

                Console.Write("\nSelect new set of dice? (y/n): ");
                play = Console.ReadLine();
            }

            if (dieSides > 1)
            {
                Console.WriteLine("\nThanks for playing!!\n");
            }
            else
            {
                Console.WriteLine("\nThen why did you come in here? GET OUT!!\n");
            }

            System.Threading.Thread.Sleep(5000);

        }

        public static void RollDice(Random rng, int sides)
        {
            //Random rng = new Random();

            int dieOne = rng.Next(1, sides + 1);
            Console.WriteLine("\nDie one came up: " + dieOne);
            int dieTwo = rng.Next(1, sides + 1);
            Console.WriteLine("Die two came up: " + dieTwo);
            Console.WriteLine();

            if (sides == 6 && dieOne == 1 && dieTwo == 1)
            {
                Console.WriteLine("SNAKE EYES!!\n");
            }
            else if (sides == 6 && dieOne == 6 && dieTwo == 6)
            {
                Console.WriteLine("BOX CARS!!\n");
            }

        }

    }
}
