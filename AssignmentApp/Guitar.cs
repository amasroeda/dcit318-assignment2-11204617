using System;

namespace AssignmentApp
{
    public class Guitar : IPlayable
    {
        public void PlayInstrument()
        {
            Console.WriteLine("Guitar is strumming chords");
        }
    }
}
