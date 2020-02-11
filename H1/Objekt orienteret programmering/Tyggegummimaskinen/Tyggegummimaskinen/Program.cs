using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyggegummimaskinen
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Dispenser

            #endregion

            #region Menu
            while (true)
            {
                Console.Clear();
                Console.WriteLine("[1] Dispense Gum");
                Console.WriteLine("[0] Exit");

                string input = Console.ReadLine();

                switch (input)
                {

                    case "1":

                        break;

                    case "0":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Unknown Input");
                        Console.ReadKey();
                        break;
                }
            }
            #endregion


        }
    }
}
