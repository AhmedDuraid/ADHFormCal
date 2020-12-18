namespace ADHFormCalAPI.Models.Converters
{
    public class VolumeModel
    {
        //Metric
        public double Liters { get; set; }
        public double Centiliters { get; set; }
        public double Milliliters { get; set; }
        public double CubicMeters { get; set; }

        // US
        public double USGallons { get; set; }
        public double USTablespoons { get; set; }
        public double USTeaspoons { get; set; }

        // UK
        public double UKGallons { get; set; }
        public double UKTablespoons { get; set; }
        public double UKTeaspoons { get; set; }

    }
}
