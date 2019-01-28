using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alder
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input: the user gives his/hers name and age to the program
            Console.WriteLine("Navn:");
            string name = Console.ReadLine();
            Console.WriteLine("Alder:");
            byte age = byte.Parse(Console.ReadLine());
            
            //simple if/else if statements 
            if (age < 3)
            {
                Console.WriteLine(name + ", du må gå med ble");
            }
            else if ((age > 2) && (age < 16))
            {
                Console.WriteLine(name + ", du må ingenting");
            }
            else if ((age > 15) && (age < 18))
            {
                Console.WriteLine(name + ", du må drikke");
            }
            else if (age > 17)
            {
                Console.WriteLine(name + ", du må stemme og køre bil");
            }
        }
    }
}
