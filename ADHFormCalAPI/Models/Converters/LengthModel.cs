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
            private set
            {
                if (value < 0)
                {
                    _kilometers = 0;
                }
                else
                {
                    _kilometers = value;
                }
            }
        }
        public string KilometerSymbol { get => "km"; }
        public double Meters
        {
            get => _meters;
            private set
            {
                if (value < 0)
                {
                    _meters = 0;
                }
                else
                {
                    _meters = value;
                }
            }
        }
        public string MeterSymbol { get => "m"; }
        public double Centimeters
        {
            get => _centimeters;
            private set
            {
                if (value < 0)
                {
                    _centimeters = 0;
                }
                else
                {
                    _centimeters = value;
                }
            }
        }
        public string CentimeterSymbol { get => "cm"; }
        public double Millimeters
        {
            get => _millimeters;
            private set
            {
                if (value < 0)
                {
                    _millimeters = 0;
                }
                else
                {
                    _millimeters = value;
                }
            }
        }
        public string MillimeterSymbol { get => "mm"; }

        // Imperial 
        public double Miles
        {
            get => _miles;
            private set
            {
                if (value < 0)
                {
                    _miles = 0;
                }
                else
                {
                    _miles = value;
                }
            }
        }
        public string MilesSymbol { get => "mi"; }
        public double Yards
        {
            get => _yards;
            private set
            {
                if (value < 0)
                {
                    _yards = 0;
                }
                else
                {
                    _yards = value;
                }
            }
        }
        public string YardSymbol { get => "yd"; }
        public double Foot
        {
            get => _foot;
            private set
            {
                if (value < 0)
                {
                    _foot = 0;
                }
                else
                {
                    _foot = value;
                }
            }
        }
        public string FootSymbol { get => "ft"; }
        public double Inches
        {
            get => _inches;
            private set
            {
                if (value < 0)
                {
                    _inches = 0;
                }
                else
                {
                    _inches = value;
                }
            }
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
