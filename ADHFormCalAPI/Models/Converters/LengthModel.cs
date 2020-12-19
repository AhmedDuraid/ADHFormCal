namespace ADHFormCalAPI.Models.Converters
{
    public class LengthModel
    {
        private double _kilometers, _meters, _centimeters
            , _millimeters, _miles, _yards, _foot, _inches;

        public LengthModel(double value, string unit)
        {
            SetLength(value, unit);
        }
        // length values can be less than 0

        // Metric 
        public double Kilometers
        {
            get => _kilometers;
            private set => _kilometers = value < 0 ? 0 : value;
        }
        public string KilometerSymbol => "km";
        public double Meters
        {
            get => _meters;
            private set => _meters = value < 0 ? 0 : value;
        }
        public string MeterSymbol => "m";
        public double Centimeters
        {
            get => _centimeters;
            private set => _centimeters = value < 0 ? 0 : value;
        }
        public string CentimeterSymbol => "cm";
        public double Millimeters
        {
            get => _millimeters;
            private set => _millimeters = value < 0 ? 0 : value;
        }
        public string MillimeterSymbol { get => "mm"; }

        // Imperial 
        public double Miles
        {
            get => _miles;
            private set => _miles = value < 0 ? 0 : value;
        }
        public string MilesSymbol { get => "mi"; }
        public double Yards
        {
            get => _yards;
            private set => _yards = value < 0 ? 0 : value;
        }
        public string YardSymbol { get => "yd"; }
        public double Foot
        {
            get => _foot;
            private set => _foot = value < 0 ? 0 : value;
        }
        public string FootSymbol { get => "ft"; }
        public double Inches
        {
            get => _inches;
            private set => _inches = value < 0 ? 0 : value;
        }
        public string IncheSymbol { get => "in"; }
        private void SetLength(double value, string unit)
        {
            switch (unit)
            {
                case "km":
                    {

                        SetValues(value, value / 0.001, value / 0.00001,
                            value / 0.000001, value * 0.62137,
                           value * 3280.8, value * 1093.6,
                           value * 39370);
                        break;
                    }
                case "m":
                    {
                        SetValues(value / 1000, value,
                            value / 0.010, value / 0.001,
                            value * 0.00053996, value * 3.2808,
                            value * 1.0936, value * 39.37);
                        break;
                    }
                case "cm":
                    {
                        SetValues(value / 100000, value / 100,
                            value, value / 0.1,
                            value * 0.0000062137, value * 0.032808,
                            value * 0.010936, value * 0.39370);
                        break;
                    }
                case "mm":
                    {
                        SetValues(value / 1000000, value / 1000,
                            value / 10, value,
                            value * 0.00000062137, value * 0.0032808,
                            value * 0.0010936, value * 0.039370);
                        break;
                    }
                case "mi":
                    {
                        SetValues(value / 0.62137, value / 0.00062137,
                            value / 0.0000062137, value / 0.00000062137,
                            value, value * 5280.0,
                            value * 1760.0, value * 6336);
                        break;
                    }
                case "yd":
                    {
                        SetValues(value / 1093.6, value / 1.0936,
                            value / 0.010936, value / 0.0010936,
                            value * 0.00056818, value * 3,
                            value, value * 36);


                        break;
                    }
                case "ft":
                    {
                        SetValues(value / 3280.8, value / 3.2808,
                            value / 0.032808, value / 0.0032808,
                            value * 0.00018939, value,
                            value * 0.33333, value * 12);
                        break;
                    }
                case "in":
                    {
                        SetValues(value / 39370, value / 39.370,
                            value / 0.39370, value / 0.039370,
                            value * 0.000015783, value * 0.083333,
                            value * 0.027778, value);
                        break;
                    }
            }
        }

        private void SetValues(double kilometers, double metersc, double centimeters
           , double millimeters, double miles, double foot, double yards, double inches)
        {
            Kilometers = kilometers;
            Meters = metersc;
            Centimeters = centimeters;
            Millimeters = millimeters;

            Miles = miles;
            Foot = foot;
            Yards = yards;
            Inches = inches;
        }

    }
}
