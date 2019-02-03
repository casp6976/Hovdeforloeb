using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetoderOpgLette
{
    class GuiOpg3
    {
        public static void Opg3()
        {
            Console.Clear();

            string name = "";
            byte age = new byte();

            Console.WriteLine("name:");
            name = Console.ReadLine();
            Console.WriteLine("age:");
            age = byte.Parse(Console.ReadLine());

            //sends name and age to logic and returns a sentence
            Console.WriteLine(Logic.Opg3(name,age));

            Console.ReadKey();
        }
    }
}
