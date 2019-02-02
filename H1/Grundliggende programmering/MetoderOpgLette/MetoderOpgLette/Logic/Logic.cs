using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetoderOpgLette
{
    class Logic
    {
        #region Opg1
        //this method takes 2 intergers and put them together and returns that value
        public static int Addition(int firstNumber, int secondNumber)
        {
            int totalNumber = new int();

            totalNumber = firstNumber + secondNumber;

            return totalNumber;

        }
        //this method an interger with an another interger and returns the result
        public static float Dividing(int firstNumber, int secondNumber)
        {
            float totalNumber = new float();

            totalNumber = firstNumber / secondNumber;

            return totalNumber;
        }
        //finds out how mutch a number (int) goes up in an another number (int)
        public static int Modulus(int firstNumber, int secondNumber)
        {
            int totalNumber = new int();

            for (int i = 1; i <= secondNumber; i++)
            {
                if (i % firstNumber == 0)
                {
                    totalNumber++;
                }
            }

            return totalNumber;
        }
        //raises a number (int) with an another number (int)
        public static int Potentiation(int firstNumber, int secondNumber)
        {
            int totalNumber = new int();

            //had to convert it because it makes it into dobble instead of an int
            totalNumber = Convert.ToInt32(Math.Pow(firstNumber, secondNumber));

            return totalNumber;
        }
        #endregion

        #region Opg2

        public static double Opg2(double firstNumber, double secondNumber)
        {
            double totalNumber = new double();

            totalNumber = Math.Pow(firstNumber, 2) + Math.Pow(secondNumber, 2);

            return totalNumber;
        }

        public static string CheckNumberSize(double firstNumber, double secondNumber)
        {
            string returnString = "";

            if (firstNumber > secondNumber)
            {
                returnString = "a^2 is the largest";
            }
            else if (firstNumber < secondNumber)
            {
                returnString = "b^2 is the largest";
            }
            else if (firstNumber == secondNumber)
            {
                returnString = "they are both the same size";
            }

            return returnString;
        }

        #endregion
    }
}
