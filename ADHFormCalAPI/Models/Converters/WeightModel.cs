namespace ADHFormCalAPI.Models.Converters
{
    public class WeightModel
    {
        private double _tonnes, _kilograms, _grams, _milligrams, _pounds, _ounces;
        public WeightModel(double value, string unit)
        {
            SetWeights(value, unit);
        }
        // weight values can not less than 0
        // Metric 
        public double Tonnes
        {
            get => _tonnes;
            private set => _tonnes = value < 0 ? 0 : value;
        }
        public string TonnesUnit => "T";
        public double Kilograms
        {
            get => _kilograms;
            private set => _kilograms = value < 0 ? 0 : value;
        }
        public string KilogramsUnit => "kg";
        public double Grams
        {
            get => _grams;
            private set => _grams = value < 0 ? 0 : value;
        }
        public string GramsUnit => "g";
        public double Milligrams
        {
            get => _milligrams;
            private set => _milligrams = value < 0 ? 0 : value;
        }

        // Imperial
        public double Pounds
        {
            get => _pounds;
            private set => _pounds = value < 0 ? 0 : value;
        }
        public string PoundsUnit => "Ib";
        public double Ounces
        {
            get => _ounces;
            private set => _ounces = value < 0 ? 0 : value;
        }
        public string OuncesUnit => "oz";

        private void SetWeights(double value, string unit)
        {
            switch (unit)
            {
                case "t":
                    {
                        SetMetricValues(value, value / 0.001, value / 0.000001, value / 0.000000001);
                        SetImperialValues(value * 2204.6, value * 35274);
                        break;
                    }
                case "kg":
                    {
                        SetMetricValues(value / 1000, value, value / 0.001, value / 0.000001);
                        SetImperialValues(value * 2.2046, value * 35.274);
                        break;
                    }
                case "g":
                    {
                        SetMetricValues(value / 1000000, value / 1000, value, value / 0.001);
                        SetImperialValues(value * 0.0022046, value * 0.035274);
                        break;
                    }
                case "mg":
                    {
                        SetMetricValues(value / 1000000000, value / 1000000, value / 1000, value / 0.001);
                        SetImperialValues(value * 0.0000022046, value * 0.000035274);
                        break;
                    }
                case "ib":
                    {
                        SetMetricValues(value / 2204.6, value / 2.2046, value / 0.0022046, value / 0.0000022046);
                        SetImperialValues(value, value * 16.000);
                        break;
                    }
                case "oz":
                    {
                        SetMetricValues(value / 35274, value / 35.274, value / 0.035274, value / 0.000035274);
                        SetImperialValues(value * 0.062500, value);
                        break;
                    }
            }
        }

        private void SetMetricValues(double tonnes, double kilograms, double grams, double milligrams)
        {
            Tonnes = tonnes;
            Kilograms = kilograms;
            Grams = grams;
            Milligrams = milligrams;
        }
        private void SetImperialValues(double pounds, double ounces)
        {
            Pounds = pounds;
            Ounces = ounces;
        }
    }
}
