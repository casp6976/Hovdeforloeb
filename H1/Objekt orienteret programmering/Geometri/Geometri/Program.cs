using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    class Program
    {
        static void Main(string[] args)
        {
            Square firstSquare = new Square(5);
            Square secondSquare = new Square(18);
            Square thirdSquare = new Square(11);


            Console.WriteLine(firstSquare.Perimeter());
            Console.WriteLine(secondSquare.Perimeter());
            Console.WriteLine(thirdSquare.Perimeter());
            Console.WriteLine(firstSquare.Area());

            Console.ReadLine();
        }
    }
}
