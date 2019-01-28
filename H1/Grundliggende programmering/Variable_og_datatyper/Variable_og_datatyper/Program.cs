using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable_og_datatyper
{
    class Program
    {
        static void Main(string[] args)
        {
            //har opdelt opgaverne i regioner for at give migselv et bedre overblik

            #region Opgave A
            // TEST: læg en int med værdien 16, og en double med verdien 5.1 sammen

            int A1 = 16;
            double A2 = 5.1;

            Console.WriteLine(A1 + A2);
            Console.ReadKey();

            // RESULTAT: ingen error, fik retuneret tallet 21.1
            #endregion

            #region Opgave B
            //TEST: Skab en ny int med den samlede værdi af 'int A1' og 'double A2'

            //int B1 = A1 + A2;

            //RESULTAT: kan ikke compile da en int kun kan holde heltal. Udkomentere forsøget
            #endregion

            #region Opgave C
            //TEST: Skab en ny double med den samlede værdi af 'int A1' og 'double A2'

            double C1 = A1 + A2;

            //RESULTAT: ingen error da en double kan indholde kommatal
            #endregion
        }
    }
}
