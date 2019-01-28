using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pythagoras
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input: the program receives input from the user, in this case the length of two sides of a triangle
            double a = double.Parse(Console.ReadLine());

            double b = double.Parse(Console.ReadLine());

            //the program then takes the two sides and use them to find the length of the third side
            double c2 = (a * a) + (b * b);
            double c = Math.Sqrt(c2);

            //Output: the program writes out the length of the third side, and tells if the first or second side is longest
            Console.WriteLine(c);
            if(a > b)
            {
                Console.WriteLine("A er længst");
            }
            else if (b > a)
            {
                Console.WriteLine("B er længst");
            }
            else if (a == b)
            {
                Console.WriteLine("A og B er lige lange");
            }

            Console.ReadKey();
        }
    }
}
