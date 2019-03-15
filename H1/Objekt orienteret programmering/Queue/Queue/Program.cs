using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                #region main menu
                Console.WriteLine(
                    "Main Menu \n\n" +
                    "[1] Add patient \n" +
                    "[2] Call up the next patient \n"
                    );
                #endregion
                string menuInput = Console.ReadLine();
                switch (menuInput)
                {
                    case "1":

                        break;

                    case "2":

                        break;
                }



                Console.WriteLine("END OF PROGRAM");
                Console.ReadLine();
            }
        }
    }
}
