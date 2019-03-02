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
            //used to randomize what sound piece is going play
            Random randomNode = new Random();

            //the music player
            SoundPlayer player = new SoundPlayer();

            //the lists containing all the sound pieces
            List<string> Minuetten = new List<string>();
            List<string> Trioen = new List<string>();

            //puts all the sound pieces into the lists
            for (int i = 1; i < 177; i++)
            {
                Minuetten.Add("M" + i);
            }
            for (int i = 1; i < 97; i++)
            {
                Trioen.Add("T" + i);
            }

            //infinite loop that keeps playing a random sound
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
