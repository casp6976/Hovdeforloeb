using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Patient
    {
        private string pName;

        public string Name
        {
            get
            {
                return pName;
            }
            set
            {
                pName = value;
            }
        }

        public Patient()
        {

        }

        public Patient(string patientName)
        {
            Name = patientName;
        }
    }
}
