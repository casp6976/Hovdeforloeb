using System;

namespace Geomitri
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square1 = new Square(13);
            Square square2 = new Square(5);
            Square square3 = new Square(3);
            Square square4 = new Square();

            Console.WriteLine(square1.Perimeter());
            Console.WriteLine(square2.Perimeter());
            Console.WriteLine(square3.Perimeter());
            Console.WriteLine(square4.Perimeter());

            Console.WriteLine(square1.Area());
            Console.WriteLine(square2.Area());
            Console.WriteLine(square3.Area());
            Console.WriteLine(square4.Area());

            Console.WriteLine("END OF PROGRAM");
            Console.ReadKey();

        }
    }
}
