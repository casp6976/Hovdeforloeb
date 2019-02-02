using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetoderOpgLette
{
    class GuiOpg2
    {
        public static void Opg2()
        {
            Console.Clear();
            Console.WriteLine("[pythagoras]\n");
            Console.WriteLine("performs pythagoras theorem (a^2 + b^2 = c^2) by inputing two numbers[a and b]," +
            " and find find out what number is largest\n");
            Console.WriteLine("inset a");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("inset b");
            int secondNumber = int.Parse(Console.ReadLine());
            
            //sends the input to logic, returns c^2
            double numberReturned = Logic.Potentiation(firstNumber, secondNumber);
            //sends the input to logic, tells whether of the input numbers is the largest
            string sizeCheck = Logic.CheckNumberSize(firstNumber, secondNumber);

            Console.WriteLine("\n" + numberReturned);
            Console.WriteLine("\n" + sizeCheck);
            Console.ReadKey();
        }
    }
}
