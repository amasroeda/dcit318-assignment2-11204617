namespace AssignmentApp
{
    public class VinylRecord : MusicFormat
    {
        public double DurationMinutes { get; set; }

        public VinylRecord(double durationMinutes)
        {
            DurationMinutes = durationMinutes;
        }

        public override double GetStorageSpace()
        {
            return DurationMinutes * 10;
        }
    }
}
