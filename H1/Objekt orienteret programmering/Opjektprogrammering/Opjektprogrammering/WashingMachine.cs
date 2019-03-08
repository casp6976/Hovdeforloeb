using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opjektprogrammering
{
    class WashingMachine
    {
        #region Class Variables
        //if power is on or off
        public bool power;
        //if water is added to the wash
        public bool water;
        //how much soap is left in the machine
        public int soapLeft;
        //how many minutes there is left till the program has run its course
        public byte timeLeft;
        //what mode the machine is in
        public byte mode;
        //if the door is locked or not
        public bool doorLock;
        //the temperature of the water
        public byte waterTemperature;
        //how fast the drum is spinning
        public byte spin;

        #endregion

        #region Class Constructor

        public WashingMachine()
        {
            power = false;
            water = false;
            soapLeft = 0;
            timeLeft = 0;
            mode = 0;
            doorLock = false;
            waterTemperature = 18;
            spin = 0;
        }

        #endregion

        #region Class Methods

        //the machine is turned off
        public void OffMode()
        {
            power = false;
            water = false;
            doorLock = false;
            waterTemperature = 18;
            spin = 0;
        }

        //the machine is turned on but not running
        public void IdleMode()
        {
            power = true;
            water = false;
            mode = 1;
            doorLock = false;
            waterTemperature = 18;
            spin = 0;
        }

        //a standard wash
        public void StandardWash()
        {
            doorLock = true;
            water = true;
            spin = 45;
            timeLeft = 40;
            soapLeft -= 10;
            waterTemperature = 80;
        }

        //whashing at lower temprature
        public void EcoMode()
        {
            doorLock = true;
            water = true;
            spin = 45;
            timeLeft = 40;
            soapLeft -= 10;
            waterTemperature = 40;
        }

        
        public void DryingMode()
        {
            doorLock = true;
            water = false;
            spin = 80;
            timeLeft = 20;
        }

        #endregion





    }
}
