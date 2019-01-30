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
            Console.Clear();
            Console.WriteLine("[Addition]\n");
            Console.WriteLine("inset first number:");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("+");
            int secondNumber = int.Parse(Console.ReadLine());
            int totalNumber = 0;
            
            int numberReturned = Logic.Addition(firstNumber, secondNumber, totalNumber);

            Console.WriteLine("=");
            

            Console.WriteLine(numberReturned);

            Console.ReadKey();
        }
    }
}
