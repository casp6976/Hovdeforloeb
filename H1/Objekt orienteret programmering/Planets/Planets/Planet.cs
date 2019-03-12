using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planet
{
    class Planet
    {
        #region Private
        private string name;
        private double mass;
        private double diameter;
        private short density;
        private double gravity;
        private double rotationPeriod;
        private double lengthOfDay;
        private double distanceFromSun;
        private double orbitalPeriod;
        private double orbitalVelocity;
        private double meanTemperature;
        private byte numberOfMoons;
        private bool ringSystem;
        #endregion

        #region Public
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public double Mass
        {
            get
            {
                return mass;
            }
            set
            {
                mass = value;
            }
        }
        public double Diameter
        {
            get
            {
                return diameter;
            }
            set
            {
                diameter = value;
            }
        }
        public short Density
        {
            get
            {
                return density;
            }
            set
            {
                density = value;

            }
        }
        public double Gravity
        {
            get
            {
                return gravity;
            }
            set
            {
                gravity = value;
            }
        }
        public double RotationPeriod
        {
            get
            {
                return rotationPeriod;
            }
            set
            {
                rotationPeriod = value;
            }
        }
        public double LengthOfDay
        {
            get
            {
                return lengthOfDay;
            }
            set
            {
                lengthOfDay = value;
            }
        }
        public double DistanceFromSun
        {
            get
            {
                return distanceFromSun;
            }
            set
            {
                distanceFromSun = value;
            }
        }
        public double OrbitalPeriod
        {
            get
            {
                return orbitalPeriod;
            }
            set
            {
                orbitalPeriod = value;
            }
        }
        public double OrbitalVelocity
        {
            get
            {
                return orbitalVelocity;
            }
            set
            {
                orbitalVelocity = value;
            }
        }
        public double MeanTemperature
        {
            get
            {
                return meanTemperature;
            }
            set
            {
                meanTemperature = value;
            }
        }
        public byte NumberOfMoons
        {
            get
            {
                return numberOfMoons;
            }
            set
            {
                numberOfMoons = value;
            }
        }
        public bool RingSystem
        {
            get
            {
                return ringSystem;
            }
            set
            {
                ringSystem = value;
            }
        }
        #endregion


        public Planet(string name, double mass, double diameter, short density, double gravity, double rotationPeriod, double lengthOfDay, double distanceFromSun, double orbitalPeriod, double orbitalVelocity, double meanTemperature, byte numberOfMoons, bool ringSystem)
        {

            Name = name;
            Mass = mass;
            Diameter = diameter;
            Density = density;
            Gravity = gravity;
            RotationPeriod = rotationPeriod;
            LengthOfDay = lengthOfDay;
            DistanceFromSun = distanceFromSun;
            OrbitalPeriod = orbitalPeriod;
            OrbitalVelocity = orbitalVelocity;
            MeanTemperature = meanTemperature;
            NumberOfMoons = numberOfMoons;
            RingSystem = ringSystem;

        }

        /// <summary>
        /// Prints out the info of a spesefic planet
        /// </summary>
        /// <returns></returns>
        public string PrintData()
        {
            return
                $"Name:                     {Name}\n" +
                $"Mass:                     {Mass}\n" +
                $"Diameter:                 {Diameter}\n" +
                $"Density:                  {Density}\n" +
                $"Gravity:                  {Gravity}\n" +
                $"Rotation Period:          {RotationPeriod}\n" +
                $"Length of Day:            {LengthOfDay}\n" +
                $"Distance from the Sun:    {DistanceFromSun}\n" +
                $"Orbital Period:           {OrbitalPeriod}\n" +
                $"Orbital Velocity:         {OrbitalVelocity}\n" +
                $"Mean Temperature:         {MeanTemperature}\n" +
                $"Number of Moons:          {NumberOfMoons}\n" +
                $"Ring System?:             {ringSystem}\n\n" +
                $"----------------------------------------------";
        }

        



    }
}
