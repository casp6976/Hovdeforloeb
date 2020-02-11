using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyggegummimaskinen
{
    class Array
    {
        private string pFlavor;

        public string Flavor
        {
            get
            {
                return pFlavor;
            }
            set
            {
                pFlavor = value;
            }
        }

        public Array(string flavorId)
        {
            Flavor = flavorId;
        }
    }
}
