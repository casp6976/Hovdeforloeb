using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetoderOpgLette
{
    class Gui
    {
        //
        static void Main()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("[Main menu]\n");
                Console.WriteLine("[1] Opg 1");
                Console.WriteLine("[0] Exit");

                string menuInput = Console.ReadLine();

                
                switch (menuInput)
                {
                    case "1":
                        Opg1();
                        break;

                    case "0":
                        Environment.Exit(0);
                        break;

                    default:

                        break;
                }
            }
        }
        public static void Opg1()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("[Opg 1]\n");
                Console.WriteLine("[1] Addition");
                Console.WriteLine("[2] Dividing");
                Console.WriteLine("[3] Modulus");
                Console.WriteLine("[0] Return to Main menu");
                string menuInput = Console.ReadLine();
                
                switch (menuInput)
                {
                    case "1":
                        GuiAddition.Addition();

                        break;

                    case "2":
                        GuiDividing.Dividing();
                        break;

                    case "3":
                        GuiModulus.Modulus();
                        break;

                    case "0":
                        Main();
                        break;

                    default:
                        break;
                }
                
            }
        }

    }
}
