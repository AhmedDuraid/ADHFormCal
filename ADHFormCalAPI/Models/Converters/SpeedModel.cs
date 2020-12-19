namespace ADHFormCalAPI.Models.Converters
{
    public class SpeedModel
    {
        public SpeedModel(double values, string unit)
        {
            SpeedConverting(values, unit);
        }

        //worldwide
        public double KilometersPerHour { get; set; }
        public double Knots { get; set; }

        //US
        public double MilesPerHour { get; set; }

        private void SpeedConverting(double value, string unit)
        {
            switch (unit)
            {
                case "km-h":
                    {
                        SetWorldWideValues(value, value / 1.852);
                        SetUSValues(value / 1.609);
                        break;
                    }
                case "m-p-h":
                    {
                        SetWorldWideValues(value * 1.609, value / 1.151);
                        SetUSValues(value);
                        break;
                    }
                case "knots":
                    {
                        SetWorldWideValues(value * 1.852, value);
                        SetUSValues(value * 1.151);
                        break;
                    }
            }
        }
        private void SetWorldWideValues(double kilometersPerHour, double knots)
        {
            KilometersPerHour = kilometersPerHour;
            Knots = knots;
        }
        private void SetUSValues(double milesPerHour)
        {
            MilesPerHour = milesPerHour;
        }
    }
}
