using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[9];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (i + 1) * 2;
            }

            foreach (int indexCounter in array)
            {
                if(indexCounter == array[4])
                {
                    Console.WriteLine("dette er index plads nr. 5");
                }
                else
                {
                    Console.WriteLine("dette er ikke den rigtige index plads");
                }

            }
            Console.ReadKey();
        }
    }
}
