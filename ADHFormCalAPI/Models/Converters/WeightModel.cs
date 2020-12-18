namespace ADHFormCalAPI.Models.Converters
{
    public class WeightModel
    {
        private double _tonnes, _kilograms, _grams, _milligrams, _pounds, _ounces;
        public WeightModel(double value, string unit)
        {
            SetWeights(value, unit);
        }
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
                        Tonnes = value;
                        Kilograms = value / 0.001;
                        Grams = value / 0.000001;
                        Milligrams = value / 0.000000001;
                        Pounds = value * 2204.6;
                        Ounces = value * 35274;
                        break;
                    }
                case "kg":
                    {
                        Tonnes = value / 1000;
                        Kilograms = value;
                        Grams = value / 0.001;
                        Milligrams = value / 0.000001;
                        Pounds = value * 2.2046;
                        Ounces = value * 35.274;
                        break;
                    }
                case "g":
                    {
                        Tonnes = value / 1000000;
                        Kilograms = value / 1000;
                        Grams = value;
                        Milligrams = value / 0.001;
                        Pounds = value * 0.0022046;
                        Ounces = value * 0.035274;
                        break;
                    }
                case "mg":
                    {
                        Tonnes = value / 1000000000;
                        Kilograms = value / 1000000;
                        Grams = value / 1000;
                        Milligrams = value / 0.001;
                        Pounds = value * 0.0000022046;
                        Ounces = value * 0.000035274;
                        break;
                    }
                case "ib":
                    {
                        Tonnes = value / 2204.6;
                        Kilograms = value / 2.2046;
                        Grams = value / 0.0022046;
                        Milligrams = value / 0.0000022046;
                        Pounds = value;
                        Ounces = value * 16.000;
                        break;
                    }
                case "oz":
                    {
                        Tonnes = value / 35274;
                        Kilograms = value / 35.274;
                        Grams = value / 0.035274;
                        Milligrams = value / 0.000035274;
                        Pounds = value * 0.062500;
                        Ounces = value;
                        break;
                    }
            }
        }
    }
}
