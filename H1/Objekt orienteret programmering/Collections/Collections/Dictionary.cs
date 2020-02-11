using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Dictionary
    {
        Dictionary<string, int> platypus = new Dictionary<string, int>();

        public Dictionary()
        {

        }

        public void Add(string name, int age)
        {
            platypus.Add(name, age);
        }
    }
}
