using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celciusomregner
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("indskriv en tempratur i celcius");
            
            //Her omdanner den det indskrævet svar til en double
            double Celcius = double.Parse(Console.ReadLine());
            
            //Her konventere programmet celcius om til reamur og fahrenheit
            double Reamur = Celcius * 0.8;
            double Fahrenheit = Celcius * 1.8 + 32;


            Console.WriteLine("Reamur: " + Reamur);
            Console.WriteLine("Fahrenheit: " + Fahrenheit);

            Console.ReadKey();
        }
    }
}
