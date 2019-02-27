using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Mozart
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            Random randomNode = new Random();
            SoundPlayer player = new SoundPlayer();
            List<string> Minuetten = new List<string>();
            List<string> Trioen = new List<string>();
            for (int i = 1; i < 177; i++)
            {
                Minuetten.Add("M" + i);
            }
            for (int i = 1; i < 97; i++)
            {
                Trioen.Add("T" + i);
            }

            while (true)
            {
                player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + $"{Minuetten[randomNode.Next(0, Minuetten.Count)]}.wav";
                player.PlaySync();
                player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + $"{Trioen[randomNode.Next(0, Trioen.Count)]}.wav";
                player.PlaySync();
            }




        }
    }
}
