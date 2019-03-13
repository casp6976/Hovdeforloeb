using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblotek
{
    class Program
    {
        static void Main(string[] args)
        {


            Libary CanLent = new Libary();

            while (true)
            {
                Console.Clear();
                Console.WriteLine(CanLent.userLent.Count);
                Console.WriteLine("[1] add book to stack \n[2] Lent Book \n[0] Exit");


                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine(
                            "choose book: \n" +
                            "[1]  Metro 2033 \n" +
                            "[2]  C# for Dummies\n" +
                            "[3]  The Last Wish\n" +
                            "[4]  Sword of Destiny\n" +
                            "[5]  Blood of Elves\n" +
                            "[6]  Time of Contempt\n" +
                            "[7]  Baptism of Fire\n" +
                            "[8]  The Tower of Swallows\n" +
                            "[9]  Lady of the Lake\n" +
                            "[10] Season of Stroms");


                        byte idInput = byte.Parse(Console.ReadLine());
                        CanLent.AddToStack(idInput);
                        break;

                    case "2":
                        Console.WriteLine(CanLent.RentBooks());
                        Console.ReadKey();
                        break;

                    case "0":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("unknown input");
                        break;
                }
            }
        }
    }
}

