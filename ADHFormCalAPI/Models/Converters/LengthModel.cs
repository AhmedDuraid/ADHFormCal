namespace ADHFormCalAPI.Models.Converters
{
    public class LengthModel
    {
        private double _kilometers, _meters, _centimeters
            , _millimeters, _miles, _yards, _foot, _inches;

        // length values can be less than 0

        // Metric 
        public double Kilometers
        {
            get => _kilometers;
            set => _kilometers = value < 0 ? 0 : value;
        }
        public string KilometerSymbol => "km";
        public double Meters
        {
            get => _meters;
            set => _meters = value < 0 ? 0 : value;
        }
        public char MeterSymbol => 'm';
        public double Centimeters
        {
            get => _centimeters;
            set => _centimeters = value < 0 ? 0 : value;
        }
        public string CentimeterSymbol => "cm";
        public double Millimeters
        {
            get => _millimeters;
            set => _millimeters = value < 0 ? 0 : value;
        }
        public string MillimeterSymbol => "mm";

        // Imperial 
        public double Miles
        {
            get => _miles;
            set => _miles = value < 0 ? 0 : value;
        }
        public string MilesSymbol => "mi";
        public double Yards
        {
            get => _yards;
            set => _yards = value < 0 ? 0 : value;
        }
        public string YardSymbol => "yd";
        public double Foot
        {
            get => _foot;
            set => _foot = value < 0 ? 0 : value;
        }
        public string FootSymbol => "ft";
        public double Inches
        {
            get => _inches;
            set => _inches = value < 0 ? 0 : value;
        }
        public string IncheSymbol => "in";

    }
}
