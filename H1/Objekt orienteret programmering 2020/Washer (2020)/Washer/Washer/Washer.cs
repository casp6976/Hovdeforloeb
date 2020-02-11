using System;
using System.Collections.Generic;
using System.Text;

namespace Washer
{
    class Washer
    {
        #region Properties
        
        //if the machine is turned on/off
        private bool power;
        //if there is wather inside of the machine
        private bool water;
        //if the door is open/closed
        private bool isDoorOpen;
        //if the door is locked
        private bool doorLock;
        //the speed of the drum
        private byte drumSpeed;

        public bool Power
        {
            get { return power; }
            set { this.power = value; }
        }
        public bool Water
        {
            get { return water; }
            set { this.water = value; }
        }
        public bool IsDoorOpen
        {
            get { return isDoorOpen; }
            set { this.isDoorOpen = value; }
        }
        public bool DoorLock
        {
            get { return doorLock; }
            set { this.doorLock = value; }
        }
        public byte DrumSpeed
        {
            get { return drumSpeed; }
            set { this.drumSpeed = value; }
        }

        #endregion

        #region Constructor

        public Washer()
        {
            Power = false;
            Water = false;
            IsDoorOpen = false;
            DoorLock = false;
            DrumSpeed = 0;
        }

        #endregion
    }
}
