namespace ADHFormCalAPI.Models.Converters
{
    public class PressureModel
    {
        public PressureModel(double value, string unit)
        {
            PressureConverting(value, unit);
        }
        private double _pascals, _bar, _torrs;
        public double Pascals
        {
            get => _pascals;
            set => _pascals = value < 0 ? 0 : value;
        }
        public string PascalsSymbol => "Pa";
        public double Bar
        {
            get => _bar;
            set => _bar = value < 0 ? 0 : value;
        }
        public string BarSymbol => "bar";
        public double Torrs
        {
            get => _torrs;
            set => _torrs = value < 0 ? 0 : value;
        }
        public string TorrsSymbol => "Torr";

        private void PressureConverting(double value, string unit)
        {
            switch (unit)
            {
                case "pa":
                    {
                        SetValues(value, value / 100000, value * 0.0075006);
                        break;
                    }
                case "bar":
                    {
                        SetValues(value / 0.000010000, value, value * 750.06);
                        break;
                    }
                case "torr":
                    {
                        SetValues(value / 0.0075006, value / 750.06, value);
                        break;
                    }
            }

        }
        private void SetValues(double pascals, double bar, double torrs)
        {
            Pascals = pascals;
            Bar = bar;
            Torrs = torrs;
        }
    }
}
