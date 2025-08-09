namespace AssignmentApp
{
    public class CD : MusicFormat
    {
        public double DurationMinutes { get; set; }

        public CD(double durationMinutes)
        {
            DurationMinutes = durationMinutes;
        }

        public override double GetStorageSpace()
        {
            return DurationMinutes * 15;
        }
    }
}
