using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetoderOpgLette
{
    class GuiDividing
    {
        public static void Dividing ()
        {
            Console.Clear();
            Console.WriteLine("[Dividing]\n");
            Console.WriteLine("inset first number:");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("/");
            int secondNumber = int.Parse(Console.ReadLine());
            float totalNumber = 0;

            float numberReturned = Logic.Dividing(firstNumber, secondNumber, totalNumber);

            Console.WriteLine(numberReturned);
            Console.ReadKey();
        }
    }
}
