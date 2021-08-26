using System;

namespace SpinningDiscs
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Declare and initialize a CD and a DVD object.
            DVD dvd = new DVD("Shrek", 4700, "Movie", "DVD-R");
            CD cd = new CD("We Cool?", 400, "Music", "CD-RW");

            // TODO: Call each CD and DVD method to verify that they work as expected.
            dvd.SpinDisc();
            cd.SpinDisc();

            dvd.ReadData();
            cd.ReadData();


            cd.PlayAudio();
        }
    }
}
