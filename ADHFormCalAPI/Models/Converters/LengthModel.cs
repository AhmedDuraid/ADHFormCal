namespace ADHFormCalAPI.Models.Converters
{
    public class LengthModel
    {

        public double Kilometers { get; set; }
        public string KilometerSymbol => "km";
        public double Meters { get; set; }
        public char MeterSymbol => 'm';
        public double Centimeters { get; set; }
        public string CentimeterSymbol => "cm";
        public double Millimeters { get; set; }
        public string MillimeterSymbol => "mm";

        // Imperial 
        public double Miles { get; set; }
        public string MilesSymbol => "mi";
        public double Yards { get; set; }
        public string YardSymbol => "yd";
        public double Foot { get; set; }
        public string FootSymbol => "ft";
        public double Inches { get; set; }
        public string IncheSymbol => "in";
    }
}
