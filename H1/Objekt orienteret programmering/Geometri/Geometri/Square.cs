using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    public class Square
    {
        private int pSide;

        public int Side
        {
            get
            {
                return pSide;
            }
            set
            {
                pSide = value;
            }
        }

        /// <summary>
        /// constructor for squares
        /// </summary>
        /// <param name="squareSide"></param>
        public Square(int squareSide)
        {
            Side = squareSide;
        }

        /// <summary>
        /// returns target perimeter
        /// </summary>
        /// <returns></returns>
        public int Perimeter()
        {
            int perimeter = 0;

            perimeter = pSide * 4;

            return perimeter;
        }
            
        /// <summary>
        /// returns target area
        /// </summary>
        /// <returns></returns>
        public int Area()
        {
            int area = 0;

            area = pSide * pSide;

            return area;
        }
    }
}
