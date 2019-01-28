using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Igang_med_løkker
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = new int();
            while(i < 100)
            {
                i++;
                if(i < 50)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
