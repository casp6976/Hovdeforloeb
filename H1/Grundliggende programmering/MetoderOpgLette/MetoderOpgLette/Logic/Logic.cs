using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetoderOpgLette
{
    class Logic
    {
        public static int Addition(int firstNumber,int secondNumber, int totalNumber)
        {

            totalNumber = firstNumber + secondNumber;

            return totalNumber;
            
        }

        public static float Dividing(int firstNumber, int secondNumber, float totalNumber)
        {
            totalNumber = firstNumber / secondNumber;

            return totalNumber;
        }
        
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
    }
}
