using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOpg2_3
{
    class Program
    {
        static void Main(string[] args)
        {

            //array list containing boy names
            ArrayList boyNames = new ArrayList() { "william", "oliver", "noah", "emil", "victor", "magnus", "frederik", "mikkel", "lucas", "alexander", "oscar", "mathias", "sebastian", "malthe", "elias", "christian", "mads", "gustav", "villads", "tobias" };

            while (true)
            {
                //a simple menu
                Console.Clear();
                Console.WriteLine("[1] search \n[2] add name \n[3] remove name \n[4] exit");

                ConsoleKeyInfo menuInput = Console.ReadKey();
                switch (char.ToLower(menuInput.KeyChar))
                {
                    //search
                    case '1':
                        Console.Clear();

                        //the program saves the user input
                        Console.WriteLine("Enter Search:");
                        string searchName = Console.ReadLine();

                        //the program search the array to see if there's a name matching the saved user input
                        if (boyNames.Contains(searchName.ToLower()))
                        {
                            Console.WriteLine("The name '" + searchName + "' is in the list");
                        }
                        else
                        {
                            Console.WriteLine("Name not found");
                        }

                        Console.ReadKey();
                        break;

                        //add name
                    case '2':
                        Console.Clear();
                        Console.WriteLine("new name:");
                        string newName = Console.ReadLine();

                        boyNames.Add(newName.ToLower());
                        break;

                        //remove name
                    case '3':
                        Console.Clear();
                        Console.WriteLine("remove name:");
                        string removeName = Console.ReadLine();

                        boyNames.Remove(removeName.ToLower());
                        break;

                        //exit
                    case '4':
                        Environment.Exit(0);
                        break;

                    default:

                        break;
                }

            }
        }
    }
}
