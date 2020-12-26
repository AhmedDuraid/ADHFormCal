namespace ADHFormCalAPI.Models.Converters
{
    public class WeightModel
    {
        private double _tonnes, _kilograms, _grams, _milligrams, _pounds, _ounces;

        // weight values can not less than 0
        // Metric 
        public double Tonnes
        {
            get => _tonnes;
            set => _tonnes = value < 0 ? 0 : value;
        }
        public char TonnesSymbol => 't';
        public double Kilograms
        {
            get => _kilograms;
            set => _kilograms = value < 0 ? 0 : value;
        }
        public string KilogramsSymbol => "kg";
        public double Grams
        {
            get => _grams;
            set => _grams = value < 0 ? 0 : value;
        }
        public char GramsSymbol => 'g';
        public double Milligrams
        {
            get => _milligrams;
            set => _milligrams = value < 0 ? 0 : value;
        }
        public string MilligramSymbol => "mg";

        // Imperial
        public double Pounds
        {
            get => _pounds;
            set => _pounds = value < 0 ? 0 : value;
        }
        public string PoundsSymbol => "ib";
        public double Ounces
        {
            get => _ounces;
            set => _ounces = value < 0 ? 0 : value;
        }
        public string OuncesSymbol => "oz";

    }
}
