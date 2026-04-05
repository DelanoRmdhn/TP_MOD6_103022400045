using System;
using System.Diagnostics;

namespace TP_MODUL6_103022400045
{
    public class SayaMusicTrack
    {
        public int id;
        public int playCount;
        public string title;

        private static Random rand = new Random();

        public SayaMusicTrack(string title)
        {
            Debug.Assert(title != null, "Judul tidak boleh null");
            Debug.Assert(title.Length <= 100, "Judul maksimal 100 karakter");

            this.title = title;
            this.playCount = 0;
            this.id = rand.Next(10000, 100000);
        }

        public void IncreasePlayCount(int count)
        {
            Debug.Assert(count <= 10000000, "Maksimal penambahan 10.000.000");

            try
            {
                checked
                {
                    playCount += count;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Terjadi overflow pada play count!");
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
