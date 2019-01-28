using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_og_bubblesort
{
    class Program
    {
        static void Main(string[] args)
        {
            //the program starts out by making an array 100 index spaces
            int[] number = new int[100];

            //the program then fills the array with random number ranging 0-499
            Random random = new Random();
            for (int i = 0; i < number.Length; i++)
            {
                int randomNumber = random.Next(0, 500);
                number[i] = randomNumber;

                //the numbers gets printed to screen 
                Console.WriteLine(number[i]);
            }
            Console.ReadKey();
            Console.Clear();

            //the program then sort the numbers from lowest to highest
            for(int i = 0; i < number.Length; i++)
            {
                for (int j = 0; j < (number.Length -1); j++)
                {
                    //if the number is lager than the next number, they switch places
                    if (number[j] > number[j+1])
                    {
                        int temp = number[j + 1];
                        number[j + 1] = number[j];
                        number[j] = temp;
                    }
                }
            }

            //the sorted numbers gets printed out to screen
            for(int i = 0; i < number.Length; i++)
            {
                Console.WriteLine(number[i]);
            }
            Console.ReadKey();
            Console.Clear();

            //the numbers switch place so they go from highest to lowest now
            Array.Reverse(number);

            //the reversted numbers gets printed out to screen
            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine(number[i]);
            }
            Console.ReadKey();
        }
    }
}
