using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terningkastet
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input: the program finds a random number between 1 and 6
            Random random = new Random();
            int DiceThrow = random.Next(1, 7);

            //Output: the program choses an output corresponding with the number it found
            if (DiceThrow == 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Du slog en etter");
            }
            else if (DiceThrow == 2)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Du slog en to'er");
            }
            else if (DiceThrow == 3)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Du slog en tre'er");
            }
            else if (DiceThrow == 4)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Du slog en fir'er");
            }
            else if (DiceThrow == 5)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Du slog en fem'er");
            }
            else if (DiceThrow == 6)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Du slog en seks'er");
            }

            Console.ReadLine();
        }
    }
}
