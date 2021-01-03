namespace ADHFormCalAPI.Models.Converters
{
    public class SpeedModel
    {
        private double _kilometersPerHour, _milesPerHour, _knots;

        //worldwide
        public double KilometersPerHour { get; set; }
        public string KilometersPerHourSymbol => "kmph";
        public string KilometersPerHourUnit => "km/h";

        public double Knots { get; set; }
        public string KnotsSymbol => "kn";

        //US
        public double MilesPerHour { get; set; }
        public string MilesPerHourSymbol => "mph";
    }
}
