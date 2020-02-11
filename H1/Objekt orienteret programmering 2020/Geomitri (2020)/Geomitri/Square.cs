using System;
using System.Collections.Generic;
using System.Text;

namespace Geomitri
{
    public class Square
    {
        #region Properties

        private int sideLength;

        public int SideLength
        {
            get
            {
                return sideLength;
            }
            set
            {
                this.sideLength = value;
            }   
        }

        #endregion

        #region Constructor

        public Square(int squareLength)
        {
            SideLength = squareLength;
        }

        public Square()
        {
            SideLength = 6;
        }

        #endregion

        #region Methods
        public int Perimeter()
        {
            int perimeter;

            perimeter = sideLength * 4;

            return perimeter;
        }
        public int Area()
        {
            int area;

            area = sideLength * sideLength;

            return area;
        }
        #endregion


    }
}
