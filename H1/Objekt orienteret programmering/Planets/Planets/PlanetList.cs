using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planet
{
    class PlanetList
    {

        #region lists
        //the main list
        public List<Planet> planetsList = new List<Planet>();
        //list of planets with mean temperature below zero
        public List<Planet> lowTempList = new List<Planet>();
        //list of planets with a diameter between 10000 and 50000
        public List<Planet> listOfGirth = new List<Planet>();
        #endregion

        #region Planets
        //Creating planets
        Planet Mercury = new Planet("Mercury", 0.330d, 4879, 5427, 3.7d, 1407.6d, 4222.6d, 57.9d, 88.0d, 47.4d, 167, 0, false);
        Planet Venus = new Planet("Venus", 4.87d, 12104, 5234, 8.9d, -5832.5d, 2802, 108.2d, 224.7d, 35, 464, 0, false);
        Planet Earth = new Planet("Earth", 5.97d, 12756, 5514, 9.8d, 23.9d, 24, 149.6d, 365.2d, 29.8d, 15, 1, false);
        Planet Mars = new Planet("Mars", 0.642d, 6792, 3933, 3.7d, 24.6d, 24.7d, 227.9d, 687.0d, 24.1d, -65, 2, false);
        Planet Jupiter = new Planet("Jupiter", 1898, 142984, 1326, 23.1d, 9.9d, 9.9d, 778.6d, 4331, 13.1d, -110, 67, true);
        Planet Saturn = new Planet("Saturn", 568, 120536, 687, 9.0d, 10.7d, 10.7d, 1433.5d, 10747, 9.7d, -140, 62, true);
        Planet Uranus = new Planet("Uranus", 86.8d, 51118, 1271, 8.7d, -17.2d, 17.2d, 2872.5d, 30589, 6.8d, -195, 27, true);
        Planet Neptune = new Planet("Neptune", 102, 49528, 1638, 11.0d, 16.1d, 16.1d, 4495.1d, 59800, 5.4d, -200, 14, true);
        Planet Pluto = new Planet("Pluto", 0.0146d, 2370, 2095, 0.7d, -153.3d, 153.3d, 5906.4d, 90560, 4.7d, -225, 5, false);
        #endregion

        /// <summary>
        /// Adds planets to planetLists
        /// </summary>
        public PlanetList()
        {
            planetsList.Add(Mercury);
            planetsList.Add(Earth);
            planetsList.Add(Mars);
            planetsList.Add(Jupiter);
            planetsList.Add(Saturn);
            planetsList.Add(Uranus);
            planetsList.Add(Neptune);
            planetsList.Add(Pluto);
        }

        /// <summary>
        /// Printing out the planets from planetList
        /// </summary>
        /// <returns></returns>
        public string PrintSystem()
        {
            string returnString = "";

            foreach (Planet plan in planetsList)
            {
                returnString += $"Name:  {plan.Name}\n";
            }

            return returnString;
        }

        /// <summary>
        /// Inserting Venus into index number
        /// </summary>
        /// <param name="indexNr"></param>
        public void InsertVenus(byte indexNr)
        {
            planetsList.Insert(indexNr, Venus);
        }

        /// <summary>
        /// Removes Pluto From List
        /// </summary>
        public void RemovePluto()
        {
            planetsList.Remove(Pluto);
        }

        /// <summary>
        /// Inserting Pluto into index number
        /// </summary>
        /// <param name="indexNr"></param>
        public void InsertPluto(byte indexNr)
        {
            planetsList.Insert(indexNr, Pluto);
        }

        /// <summary>
        /// Adds Planets where Mean Temperature is below zero to lowTempList
        /// </summary>
        public void AddToLowTemp()
        {
            foreach (Planet p in planetsList)
            {
                if (p.MeanTemperature < 0)
                {
                    lowTempList.Add(p);
                }
            }
        }

        /// <summary>
        /// Printing out the planets from lowTempList
        /// </summary>
        /// <returns></returns>
        public string PrintLowTemp()
        {
            string returnString = "";

            foreach (Planet lowPlan in lowTempList)
            {
                returnString += $"Name:  {lowPlan.Name}\n";
            }

            return returnString;
        }

        /// <summary>
        /// Adds planets with a specific diameter to listOfGirth
        /// </summary>
        public void AddToGirth()
        {
            foreach (Planet p in planetsList)
            {
                if (p.Diameter > 10000 && p.Diameter < 50000)
                {
                    listOfGirth.Add(p);
                }
            }
        }

        /// <summary>
        /// Removes everything from all 3 lists
        /// </summary>
        public void MegaDump()
        {
            planetsList.Clear();
            lowTempList.Clear();
            listOfGirth.Clear();
        }
    }
}