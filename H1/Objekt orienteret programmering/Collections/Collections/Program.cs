using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> people = new Dictionary<string, int>();

            people.Add("jonny", 135);
            people.Add("timmy", 564);
            people.Add("Casper", 23);
            people.Add("bob", 412);

            //Console.WriteLine(people["Casper"]);

            //people.Remove("bob");

            foreach (var pair in people)
            {
                Console.WriteLine(pair.Key + " is " + pair.Value + " years old");
            }

            Console.ReadKey();
        }
    }
}
