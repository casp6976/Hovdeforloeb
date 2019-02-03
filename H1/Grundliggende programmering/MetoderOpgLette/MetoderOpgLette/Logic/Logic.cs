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
        //finds the length of a triangle by inputting the 2 first sides
        public static double Opg2(double firstNumber, double secondNumber)
        {
            double totalNumber = new double();

            totalNumber = Math.Pow(firstNumber, 2) + Math.Pow(secondNumber, 2);

            return totalNumber;
        }

        //finds out what of the 2 side the user has input is the longest
        public static string CheckNumberSize(double firstNumber, double secondNumber)
        {
            string returnString = "";

            if (firstNumber > secondNumber)
            {
                returnString = "a is the largest";
            }
            else if (firstNumber < secondNumber)
            {
                returnString = "b is the largest";
            }
            else if (firstNumber == secondNumber)
            {
                returnString = "they are both the same size";
            }

            return returnString;
        }

        #endregion

        #region Opg3
        //takes a string and a byte and returns an diffrent output depending of the value of the byte
        public static string Opg3(string name, byte age)
        {
            string output = "";

            if(age < 3)
            {
                output = name + ", du må gå med ble.";
            }
            else if(age > 2 && age < 16)
            {
                output = name + ", du må ingenting";
            }
            else if(age > 15 && age < 18)
            {
                output = name + ", du må drikke";
            }
            else if(age > 17)
            {
                output = name + ", du må stemme og køre bil";
            }

            return output;
        }

        #endregion

    }
}
