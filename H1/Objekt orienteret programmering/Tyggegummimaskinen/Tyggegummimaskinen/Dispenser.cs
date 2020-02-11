using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Tyggegummimaskinen
{
    class Dispenser
    {
        private ArrayList bob = new ArrayList();
        private Array[] gumCap = new Array[54];

        public Array[] Capacity
        {
            get
            {
                return gumCap;
            }
            set
            {
                gumCap = value;
            }
        }

        public Dispenser(Array[] capValue)
        {
            Capacity = capValue;
        }

        public void FillDispenser()
        {
            
        }
    }
}
