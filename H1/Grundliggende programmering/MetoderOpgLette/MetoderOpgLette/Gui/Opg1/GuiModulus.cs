using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetoderOpgLette
{
    class GuiModulus
    {
        public static void Modulus()
        {
            //the gui for modulus, the user input 2 numbers that will be sent to logic
            Console.Clear();
            Console.WriteLine("[Modulus]\n");
            Console.WriteLine("Find out how many times {first number} goes up in {second number}\n");
            Console.WriteLine("inset first number");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("inset second number");
            int secondNumber = int.Parse(Console.ReadLine());

            float numberReturned = Logic.Modulus(firstNumber, secondNumber);

            Console.WriteLine(secondNumber + " goes up in " + firstNumber + ", " + numberReturned + " Times");

            Console.ReadKey();
        }
    }
}
