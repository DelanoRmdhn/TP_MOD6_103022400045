using System;

namespace TP_MODUL6_103022400045
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SayaMusicTrack track1 = new SayaMusicTrack("Who Knows");

                track1.IncreasePlayCount(5000);
                track1.PrintTrackDetails();

                track1.IncreasePlayCount(20000000);

                for (int i = 0; i < 10; i++)
                {
                    track1.IncreasePlayCount(int.MaxValue);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

            Console.ReadLine();
        }
    }
}
