namespace ADHFormCalAPI.Models.Converters
{
    public class WeightModel
    {
        // Metric 
        public double Tons { get; set; }
        public double Kilograms { get; set; }
        public double Grams { get; set; }
        public double Milligrams { get; set; }

        // Imperial
        public double Pounds { get; set; }
        public double Ounces { get; set; }

        private void SetWeights(double value, string unit)
        {
            switch (unit)
            {
                case "t":
                    {
                        Tons = value;
                        Kilograms = value / 0.001;
                        Grams = value / 0.000001;
                        Milligrams = value / 0.000000001;
                        Pounds = value * 2204.6;
                        Ounces = value * 32151;
                        break;
                    }
                case "kg":
                    {
                        Tons = value / 1000;
                        Kilograms = value;
                        Grams = value / 0.001;
                        Milligrams = value / 0.000001;
                        Pounds = value * 2.2046;
                        Ounces = value * 35.274;
                        break;
                    }
                case "g":
                    {
                        Tons = value / 1000000;
                        Kilograms = value / 1000;
                        Grams = value;
                        Milligrams = value / 0.001;
                        Pounds = value * 0.0022046;
                        Ounces = value * 0.035274;
                        break;
                    }
                case "mg":
                    {
                        Tons = value / 1000000000;
                        Kilograms = value / 1000000;
                        Grams = value / 1000;
                        Milligrams = value / 0.001;
                        Pounds = value * 0.0000022046;
                        Ounces = value * 0.000035274;
                        break;
                    }
                case "ib":
                    {
                        Tons = value / 2204.6;
                        Kilograms = value / 2.2046;
                        Grams = value / 0.0022046;
                        Milligrams = value / 0.0000022046;
                        Pounds = value;
                        Ounces = value * 16.000;
                        break;
                    }
                case "oz":
                    {
                        Tons = value / 35274;
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
