using System;

namespace AssignmentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Task 1: Inheritance & Method Overriding (Songs) ---");

            Song genericSong = new Song();
            PopSong pop = new PopSong();
            RockSong rock = new RockSong();

            genericSong.Play();
            pop.Play();
            rock.Play();

            // Task 2
            Console.WriteLine("\n--- Task 2: Abstract Classes & Methods (Music Formats) ---");

            VinylRecord vinyl = new VinylRecord(40);
            CD cd = new CD(60);

            Console.WriteLine($"Vinyl storage needed: {vinyl.GetStorageSpace()} MB");
            Console.WriteLine($"CD storage needed: {cd.GetStorageSpace()} MB");  

            // Task 3
            Console.WriteLine("\n--- Task 3: Interfaces (Instruments) ---");

            IPlayable guitar = new Guitar();
            IPlayable piano = new Piano();

            guitar.PlayInstrument(); 
            piano.PlayInstrument();   
        }
    }
}
