using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Patient
    {
        #region properties
        //private properties
        private string pName;

        //public properties
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
        #endregion

        #region constructors
        //empty constructor
        public Patient()
        {

        }

        //constructor used
        public Patient(string patientName)
        {
            Name = patientName;
        }
        #endregion
    }
}
