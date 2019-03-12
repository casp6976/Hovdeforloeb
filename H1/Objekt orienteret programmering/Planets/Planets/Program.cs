using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planet
{
    class Program
    {
        static void Main(string[] args)
        {

            PlanetList SolarSystem = new PlanetList();
            //shows the info of mercury
            Console.WriteLine(SolarSystem.planetsList[0].PrintData());

            SolarSystem.InsertVenus(1);
            SolarSystem.RemovePluto();
            SolarSystem.InsertPluto(8);


            Console.WriteLine(SolarSystem.PrintSystem());
            Console.WriteLine(SolarSystem.planetsList.Count);

            SolarSystem.AddToLowTemp();
            Console.WriteLine(SolarSystem.PrintLowTemp());

            SolarSystem.MegaDump();

            Console.ReadLine();
        }
    }
}
