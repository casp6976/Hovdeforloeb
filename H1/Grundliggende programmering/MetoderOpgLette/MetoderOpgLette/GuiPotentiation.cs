using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetoderOpgLette
{
    class GuiPotentiation
    {
        public static void Potentiation()
        {
            Console.Clear();
            Console.WriteLine("[Potentiation]\n");
            Console.WriteLine("Raise {first number} with {second number}\n");
            Console.WriteLine("inset first number");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("inset second number");
            int secondNumber = int.Parse(Console.ReadLine());

            float numberReturned = Logic.Potentiation(firstNumber, secondNumber);

            Console.WriteLine(numberReturned);

            Console.ReadKey();
        }
    }
}
