namespace ADHFormCalAPI.Models.Converters
{
    public class PressureModel
    {
        public PressureModel(double value, string unit)
        {
            PressureConverting(value, unit);
        }
        public double Pascals { get; set; }
        public double Bar { get; set; }
        public double Torrs { get; set; }


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
