using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetoderOpgLette
{
    class GuiAddition
    {
        public static void Addition()
        {
            //the gui for addition, the user input 2 numbers that will be sent to logic
            Console.Clear();
            Console.WriteLine("[Addition]\n");
            Console.WriteLine("{first number} + {second number} = {result}\n");
            Console.WriteLine("inset first number:");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("inset second number:");
            int secondNumber = int.Parse(Console.ReadLine());

            int numberReturned = Logic.Addition(firstNumber, secondNumber);

            Console.WriteLine("=");
            

            Console.WriteLine(numberReturned);

            Console.ReadKey();
        }
    }
}
