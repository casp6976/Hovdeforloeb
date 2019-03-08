using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opjektprogrammering
{
    class Person
    {
        public string name;
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        
        public void Eat()
        {
            Console.WriteLine("eat...mums");
        }

        public String Sleep(int time)
        {
            return "ZZZzzzZZZ";
        }


    }
}
