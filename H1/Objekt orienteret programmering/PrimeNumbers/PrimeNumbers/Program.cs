using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //queue created
            Queue<int> primes = new Queue<int>();

            //primenumbers added to queue
            primes.Enqueue(2);
            primes.Enqueue(3);
            primes.Enqueue(5);
            primes.Enqueue(7);
            primes.Enqueue(11);

            //int used to store the sum of the primenumbers
            int total = 0;

            //while loop used to add all the primenumbers to the total int
            while (primes.Count > 0)
            {
                total += primes.Dequeue();
            }


            Console.WriteLine(total);
            Console.ReadLine();



        }
    }
}
