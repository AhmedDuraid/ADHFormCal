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
                        Kilometers = value;
                        Meters = value / 0.001;
                        Centimeters = value / 0.00001;
                        Millimeters = value / 0.000001;

                        Miles = value * 0.62137;
                        Foot = value * 3280.8;
                        Yards = value * 1093.6;
                        Inches = value * 39370;

                        break;
                    }
                case "m":
                    {
                        Kilometers = value / 1000;
                        Meters = value;
                        Centimeters = value / 0.010;
                        Millimeters = value / 0.001;

                        Miles = value * 0.00053996;
                        Foot = value * 3.2808;
                        Yards = value * 1.0936;
                        Inches = value * 39.37;

                        break;
                    }
                case "cm":
                    {
                        Kilometers = value / 100000;
                        Meters = value / 100;
                        Centimeters = value;
                        Millimeters = value / 0.1;

                        Miles = value * 0.0000062137;
                        Foot = value * 0.032808;
                        Yards = value * 0.010936;
                        Inches = value * 0.39370;
                        break;
                    }
                case "mm":
                    {
                        Kilometers = value / 1000000;
                        Meters = value / 1000;
                        Centimeters = value / 10;
                        Millimeters = value;

                        Miles = value * 0.00000062137;
                        Foot = value * 0.0032808;
                        Yards = value * 0.0010936;
                        Inches = value * 0.039370;

                        break;
                    }
                case "mi":
                    {
                        Kilometers = value / 0.62137;
                        Meters = value / 0.00062137;
                        Centimeters = value / 0.0000062137;
                        Millimeters = value / 0.00000062137;

                        Miles = value;
                        Foot = value * 5280.0;
                        Yards = value * 1760.0;
                        Inches = value * 63360;

                        break;
                    }
                case "yd":
                    {
                        Kilometers = value / 1093.6;
                        Meters = value / 1.0936;
                        Centimeters = value / 0.010936;
                        Millimeters = value / 0.0010936;

                        Miles = value * 0.00056818;
                        Foot = value * 3;
                        Yards = value;
                        Inches = value * 36;

                        break;
                    }
                case "ft":
                    {
                        Kilometers = value / 3280.8;
                        Meters = value / 3.2808;
                        Centimeters = value / 0.032808;
                        Millimeters = value / 0.0032808;

                        Miles = value * 0.00018939;
                        Foot = value;
                        Yards = value * 0.33333;
                        Inches = value * 12;

                        break;
                    }
                case "in":
                    {
                        Kilometers = value / 39370;
                        Meters = value / 39.370;
                        Centimeters = value / 0.39370;
                        Millimeters = value / 0.039370;

                        Miles = value * 0.000015783;
                        Foot = value * 0.083333;
                        Yards = value * 0.027778;
                        Inches = value;

                        break;
                    }
            }
        }

    }
}
