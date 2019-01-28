using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rumfanget
{
    class Program
    {
        static void Main(string[] args)
        {
            //input længte
            Console.WriteLine("indsæt længte");
            double L = double.Parse(Console.ReadLine());
            Console.Clear();

            //input højde
            Console.WriteLine("indsæt højde");
            double H = double.Parse(Console.ReadLine());
            Console.Clear();

            //input bredde
            Console.WriteLine("indsæt bredde");
            double B = double.Parse(Console.ReadLine());
            Console.Clear();

            //udregning af rumfang
            double Rumfang = L * H * B;

            //output
            Console.WriteLine("længte: " + L);
            Console.WriteLine("højde:  " + H);
            Console.WriteLine("bredde: " + B);
            Console.WriteLine("");
            Console.WriteLine("Rumfanget er " + Rumfang);
            Console.ReadKey();
        }
    }
}
