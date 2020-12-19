namespace ADHFormCalAPI.Models.Converters
{
    public class SpeedModel
    {
        private double _kilometersPerHour, _milesPerHour, _knots;
        public SpeedModel(double values, string unit)
        {
            SpeedConverting(values, unit);
        }

        //worldwide
        public double KilometersPerHour
        {
            get => _kilometersPerHour;
            set => _kilometersPerHour = value < 0 ? 0 : value;
        }
        public string KilometersPerHourSymbol => "km/h";
        public double Knots
        {
            get => _knots;
            set => _knots = value < 0 ? 0 : value;
        }
        public string KnotsSymbol => "kn";

        //US
        public double MilesPerHour
        {
            get => _milesPerHour;
            set => _milesPerHour = value < 0 ? 0 : value;
        }
        public string MilesPerHourSymbol => "mph";
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
