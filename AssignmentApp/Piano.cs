using System;

namespace AssignmentApp
{
    public class Piano : IPlayable
    {
        public void PlayInstrument()
        {
            Console.WriteLine("Piano is playing a melody");
        }
    }
}
