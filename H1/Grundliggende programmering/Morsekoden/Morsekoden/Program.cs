using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morsekoden
{
    class Program
    {
        static void Main(string[] args)
        {
            //a while loop to keep the program running so the user dont have to restart the program for every sentence
            while (true)
            {
                Console.WriteLine("intast tekst");
                //the program saves the text in a string and convert it to a char array
                string tekst = Console.ReadLine();
                char[] chararray = tekst.ToCharArray();

                StringBuilder morse = new StringBuilder();

                //a  for loop that keep running till it have translated the entire sentence to morse code
                for (int i = 0; i < chararray.Length; i++)
                {
                    switch (chararray[i])
                    {
                        case 'a':
                            morse.Append(".-");
                            break;

                        case 'b':
                            morse.Append("-...");
                            break;

                        case 'c':
                            morse.Append("-.-.");
                            break;

                        case 'd':
                            morse.Append("-..");
                            break;

                        case 'e':
                            morse.Append(".");
                            break;

                        case 'f':
                            morse.Append("..-");
                            break;

                        case 'g':
                            morse.Append("--.");
                            break;

                        case 'h':
                            morse.Append("....");
                            break;

                        case 'i':
                            morse.Append("..");
                            break;

                        case 'j':
                            morse.Append(".---");
                            break;

                        case 'k':
                            morse.Append("-.-");
                            break;

                        case 'l':
                            morse.Append(".-..");
                            break;

                        case 'm':
                            morse.Append("--");
                            break;

                        case 'n':
                            morse.Append("-.");
                            break;

                        case 'o':
                            morse.Append("---");
                            break;

                        case 'p':
                            morse.Append(".--.");
                            break;

                        case 'q':
                            morse.Append("--.-");
                            break;

                        case 'r':
                            morse.Append(".-.");
                            break;

                        case 's':
                            morse.Append("...");
                            break;

                        case 't':
                            morse.Append("-");
                            break;

                        case 'u':
                            morse.Append("..-");
                            break;

                        case 'v':
                            morse.Append("...-");
                            break;

                        case 'w':
                            morse.Append(".--");
                            break;

                        case 'x':
                            morse.Append("-..-");
                            break;

                        case 'y':
                            morse.Append("-.--");
                            break;

                        case 'z':
                            morse.Append("--..");
                            break;

                        case 'æ':
                            morse.Append(".-.-");
                            break;

                        case 'ø':
                            morse.Append("---.");
                            break;

                        case 'å':
                            morse.Append(".--.-");
                            break;

                        default:
                            morse.Append(" ");
                            break;
                    }
                }

                Console.WriteLine(morse.ToString());

                Console.ReadKey();
                //just to make some space between the sentences the user writes. i could use a Console.Clear(); but decided against it
                Console.WriteLine("\n\n\n");
            }
        }
    }
}
