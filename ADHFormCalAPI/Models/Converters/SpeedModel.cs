namespace ADHFormCalAPI.Models.Converters
{
    public class SpeedModel
    {
        private double _kilometersPerHour, _milesPerHour, _knots;

        //worldwide
        public double KilometersPerHour
        {
            get => _kilometersPerHour;
            set => _kilometersPerHour = value < 0 ? 0 : value;
        }
        public string KilometersPerHourSymbol => "kmph";
        public string KilometersPerHourUnit => "km/h";

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
    }
}
