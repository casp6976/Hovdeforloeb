using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opjektprogrammering
{
    class Program
    {
        static void Main(string[] args)
        {
            Person perObj = new Person();

            perObj.Sleep(12);
            perObj.Age = 12;

            Console.WriteLine(perObj.Age);












        }
    }
}
