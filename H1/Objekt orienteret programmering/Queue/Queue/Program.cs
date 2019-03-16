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
            QueueLogic theQueue = new QueueLogic();

            while (true)
            {
                #region main menu
                Console.Clear();
                Console.WriteLine(
                    "Main Menu \n\n" +
                    "[1] Add patient \n" +
                    "[2] Call up the next patient \n" +
                    "[3] Who is in queue \n" +
                    "[4] How many is in queue \n" +
                    "[0] Exit"
                    );
                #endregion

                string menuInput = Console.ReadLine();
                switch (menuInput)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Enter the name of the patient");

                        string addInput = Console.ReadLine();
                        theQueue.AddToQueue(addInput);

                        Console.WriteLine($"{addInput} added");
                        Console.ReadKey();
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine(theQueue.CallNext() + " Entered the doctors office");
                        Console.ReadKey();
                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine(theQueue.PeekQueue());
                        Console.ReadKey();
                        break;

                    case "4":
                        Console.Clear();
                        Console.WriteLine("there are " + theQueue.PeopleInQueue() + " patients in queue");
                        Console.ReadKey();
                        break;

                    case"0":
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
