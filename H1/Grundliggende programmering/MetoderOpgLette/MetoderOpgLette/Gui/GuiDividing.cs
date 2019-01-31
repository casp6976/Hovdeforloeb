using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetoderOpgLette
{
    class GuiDividing
    {
        public static void Dividing()
        {
            //the gui for dividing, the user input 2 numbers that will be sent to logic
            Console.Clear();
            Console.WriteLine("[Dividing]\n");
            Console.WriteLine("{first number} / {second number} = {result}\n");
            Console.WriteLine("inset first number:");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("inset second number:");
            int secondNumber = int.Parse(Console.ReadLine());

            float numberReturned = Logic.Dividing(firstNumber, secondNumber);

            Console.WriteLine("result is: " + numberReturned);
            Console.ReadKey();
        }
    }
}
