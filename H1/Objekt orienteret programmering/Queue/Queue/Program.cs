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
                #region main menu text
                Console.Clear();
                Console.WriteLine(

                    "8888888b.     d88888888888888888888888888888888888b    88888888888888 \n"+
                    "888   Y88b   d88888    888      888  888       8888b   888    888 \n"+
                    "888    888  d88P888    888      888  888       88888b  888    888 \n"+
                    "888   d88P d88P 888    888      888  8888888   888Y88b 888    888 \n"+
                    "8888888P* d88P  888    888      888  888       888 Y88b888    888 \n"+
                    "888      d88P   888    888      888  888       888  Y88888    888 \n"+
                    "888     d8888888888    888      888  888       888   Y8888    888 \n"+
                    "888    d88P     888    888    88888888888888888888    Y888    888 \n"+



                    " .d88888b. 888     8888888888888888     8888888888888  \n"+
                    "d88P* *Y88b888     888888       888     888888         \n" +
                    "888     888888     888888       888     888888         \n" +
                    "888     888888     8888888888   888     8888888888     \n" +
                    "888     888888     888888       888     888888         \n" +
                    "888 Y8b 888888     888888       888     888888         \n" +
                    "Y88b.Y8b88PY88b. .d88P888       Y88b. .d88P888         \n" +
                    " *Y888888*  *Y88888P* 8888888888 *Y88888P* 8888888888  \n" +
                    "      Y8b                                              \n\n\n" +


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
                    //add patient
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Enter the name of the patient");

                        string addInput = Console.ReadLine();
                        theQueue.AddToQueue(addInput);

                        Console.WriteLine($"{addInput} added");
                        Console.ReadKey();
                        break;

                        //dequeue patient
                    case "2":
                        Console.Clear();
                        Console.WriteLine(theQueue.CallNext() + " Entered the doctors office");
                        Console.ReadKey();
                        break;

                        //show all patient in queue
                    case "3":
                        Console.Clear();
                        Console.WriteLine(theQueue.PeekQueue());
                        Console.ReadKey();
                        break;

                        //show how many patients is in queue
                    case "4":
                        Console.Clear();
                        Console.WriteLine("there are " + theQueue.PeopleInQueue() + " patients in queue");
                        Console.ReadKey();
                        break;

                        //exit
                    case"0":
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
