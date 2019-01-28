using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valutaomregner
{
    class Program
    {
        static void Main(string[] args)
        {
            //input af dansk valuta
            Console.WriteLine("indskriv venligst antal danske kroner");
            double DDK = double.Parse(Console.ReadLine());

            //her konventere programmet danske kroner om til det ønskede valuta
            double USD = DDK * 0.152206;
            double GBP = DDK * 0.11668;
            double EUR = DDK * 0.13393;
            double SVK = DDK * 1.37528;

            //udskrivning af valuta
            Console.WriteLine("Danish Crowns:  " + DDK);
            Console.WriteLine("");
            Console.WriteLine("US Dollars:     " + USD);
            Console.WriteLine("British Pound:  " + GBP);
            Console.WriteLine("Euro:           " + EUR);
            Console.WriteLine("Swedish Crowns: " + SVK);

            Console.ReadLine();
        }
    }
}
