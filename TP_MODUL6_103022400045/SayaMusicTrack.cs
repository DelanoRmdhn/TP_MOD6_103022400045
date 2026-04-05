using System;
using System.Collections.Generic;
using System.Text;

namespace TP_MODUL6_103022400045
{
    public class SayaMusicTrack
    {
        public int id;
        public int playCount;
        public string title;

        public SayaMusicTrack(string title)
        {
            this.title = title;
            this.playCount = 0;

            Random rand = new Random();
            this.id = rand.Next(10000, 100000);
        }

        public void IncreasePlayCount(int count)
        {
            if (count > 0)
            {
                playCount += count;
            }
            else
            {
                Console.WriteLine("Jumlah play harus lebih dari 0!");
            }
        }

        public void PrintTrackDetails()
        {
            Console.WriteLine("ID Track   : " + id);
            Console.WriteLine("Title      : " + title);
            Console.WriteLine("Play Count : " + playCount);
            Console.WriteLine("-------------------------");
        }
    }

}
