using System;
using TP_MODUL6_103022400045;

class Program
{
    static void Main(string[] args)
    {
        SayaMusicTrack track1 = new SayaMusicTrack("Hati-Hati di Jalan");

        track1.playCount = 100;

        track1.IncreasePlayCount(20);

        track1.PrintTrackDetails();

        Console.ReadLine();
    }
}
