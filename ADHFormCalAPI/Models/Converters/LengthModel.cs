namespace ADHFormCalAPI.Models.Converters
{
    public class LengthModel
    {
        private double _kilometers, _meters, _centimeters
            , _millimeters, _miles, _yards, _foot, _inches;

        public LengthModel(double value, string unit)
        {
            LengthConverting(value, unit);
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
        public string MillimeterSymbol => "mm";

        // Imperial 
        public double Miles
        {
            get => _miles;
            private set => _miles = value < 0 ? 0 : value;
        }
        public string MilesSymbol => "mi";
        public double Yards
        {
            get => _yards;
            private set => _yards = value < 0 ? 0 : value;
        }
        public string YardSymbol => "yd";
        public double Foot
        {
            get => _foot;
            private set => _foot = value < 0 ? 0 : value;
        }
        public string FootSymbol => "ft";
        public double Inches
        {
            get => _inches;
            private set => _inches = value < 0 ? 0 : value;
        }
        public string IncheSymbol => "in";
        private void LengthConverting(double value, string unit)
        {
            switch (unit)
            {
                case "km":
                    {

                        SetMetricValues(value, value / 0.001, value / 0.00001, value / 0.000001);
                        SetImperialValues(value * 0.62137, value * 3280.8, value * 1093.6, value * 39370);
                        break;
                    }
                case "m":
                    {
                        SetMetricValues(value / 1000, value, value / 0.010, value / 0.001);
                        SetImperialValues(value * 0.00053996, value * 3.2808, value * 1.0936, value * 39.37);
                        break;
                    }
                case "cm":
                    {
                        SetMetricValues(value / 100000, value / 100, value, value / 0.1);
                        SetImperialValues(value * 0.0000062137, value * 0.032808,
                            value * 0.010936, value * 0.39370);
                        break;
                    }
                case "mm":
                    {
                        SetMetricValues(value / 1000000, value / 1000, value / 10, value);
                        SetImperialValues(value * 0.00000062137, value * 0.0032808, value * 0.0010936, value * 0.039370);
                        break;
                    }
                case "mi":
                    {
                        SetMetricValues(value / 0.62137, value / 0.00062137, value / 0.0000062137, value / 0.00000062137);
                        SetImperialValues(value, value * 5280.0, value * 1760.0, value * 6336);
                        break;
                    }
                case "yd":
                    {
                        SetMetricValues(value / 1093.6, value / 1.0936, value / 0.010936, value / 0.0010936);
                        SetImperialValues(value * 0.00056818, value * 3, value, value * 36);
                        break;
                    }
                case "ft":
                    {
                        SetMetricValues(value / 3280.8, value / 3.2808, value / 0.032808, value / 0.0032808);
                        SetImperialValues(value * 0.00018939, value, value * 0.33333, value * 12);
                        break;
                    }
                case "in":
                    {
                        SetMetricValues(value / 39370, value / 39.370, value / 0.39370, value / 0.039370);
                        SetImperialValues(value * 0.000015783, value * 0.083333, value * 0.027778, value);
                        break;
                    }
            }
        }
        private void SetMetricValues(double kilometers, double metersc, double centimeters, double millimeters)
        {
            Kilometers = kilometers;
            Meters = metersc;
            Centimeters = centimeters;
            Millimeters = millimeters;
        }
        private void SetImperialValues(double miles, double foot, double yards, double inches)
        {
            Miles = miles;
            Foot = foot;
            Yards = yards;
            Inches = inches;
        }
    }
}
