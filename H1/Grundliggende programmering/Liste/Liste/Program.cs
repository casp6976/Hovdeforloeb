using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liste
{
    class Program
    {
        static void Main(string[] args)
        {
            //starting out by making a list with all the even numbers from 1 to 20
            List<int> listeB = new List<int> { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };

            //shows the list to the user
            for (int i = 0; i < listeB.Count; i++)
            {
                Console.WriteLine(listeB[i]);
            }
            Console.WriteLine(" ");
            Console.ReadKey();

            //removing the numbers that goes up with 3
            for (int i = 0; i < listeB.Count; i++)
            {
                if (listeB[i] % 3 == 0)
                {
                    listeB.RemoveAt(i);
                }
            }

            //shows the updated list to the user
            for (int i = 0; i < listeB.Count; i++)
            {
                Console.WriteLine(listeB[i]);
            }
            Console.WriteLine(" ");
            Console.ReadKey();

            //insets number 17 in the 3rd index space
            listeB.Insert(2, 17);

            //shows the updated list to the user
            for (int i = 0; i < listeB.Count; i++)
            {
                Console.WriteLine(listeB[i]);
            }
            Console.WriteLine(" ");
            Console.ReadKey();

            //creates a new list containing the values from the old
            List<int> listeC = listeB;
            //reverses the order of the numbers in the new list
            listeC.Reverse();

            //shows the new list to the user
            for (int i = 0; i < listeC.Count; i++)
            {
                Console.WriteLine(listeC[i]);
            }
            Console.ReadKey();
        }
    }
}
