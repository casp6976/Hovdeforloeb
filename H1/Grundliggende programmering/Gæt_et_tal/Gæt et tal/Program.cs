using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gæt_et_tal
{
    class Program
    {
        static void Main(string[] args)
        {
            // guess is the number the user has put in
            int guess = 0;
            // numberOfTries if the amount of times the user have tried to guess the number, it will increase every time the user tries to guess
            int numberOfTries = 0;

            //as long as this bool is true the program will not end itself
            bool loop = true;

            // computerNumber is the random number the user have to guess
            Random random = new Random();
            int computerNumber = random.Next(1, 11);
            Console.WriteLine("Gæt et tal fra 1 til 10");

            //this while loop will keep running till the user guess the correct number
            while (loop == true)
            {
                guess = int.Parse(Console.ReadLine());

                if (guess == computerNumber)
                {
                    Console.WriteLine("Rigtig, godt gået");
                    numberOfTries ++;
                    //the while loop will end because the guessed right
                    loop = false;
                }
                else if ((guess > computerNumber) && (guess < 11))
                {
                    Console.WriteLine("Forkert, prøv et lavere tal");
                    numberOfTries++;
                }
                else if (guess < computerNumber)
                {
                    Console.WriteLine("Forkert, prøv et højre tal");
                    numberOfTries ++;
                }
                else if (guess > 10)
                {
                    Console.WriteLine("Jeg sagte 'gæt et tal FRA ET TIL TI' einstein, hvor svært kan det vere!");
                    numberOfTries++;
                }
                
            }

            //responses to the user depending on how many times the user have tried to guess the number
            if (numberOfTries == 1)
            {
                Console.WriteLine("Du gættede enda rigtig på først forsøg, Nice!");
            }
            else if ((numberOfTries > 1) && (numberOfTries < 5))
            {
                Console.WriteLine("Du brugte ikke så mange forsøg");
            }
            else if ((numberOfTries > 4) && ( numberOfTries < 11)) 
            {
                Console.WriteLine("Du brugte en del forsøg. men hey, i det minste brugte du ikke over 10 forsøg");
            }
            else if (numberOfTries > 10)
            {
                Console.WriteLine("Du brugte mere end 10 forsøg på at gætte et tal der kunne vere alt mellem 1 og 10... \nDu er vist ikke den skarbeste kniv i skuffen");
            }
            Console.ReadKey();
        }
    }
}
