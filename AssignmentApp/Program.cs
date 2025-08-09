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
        }
    }
}
