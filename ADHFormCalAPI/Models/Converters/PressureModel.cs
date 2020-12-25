namespace ADHFormCalAPI.Models.Converters
{
    public class PressureModel
    {
        private double _pascals, _bar, _torrs;
        public double Pascals
        {
            get => _pascals;
            set => _pascals = value < 0 ? 0 : value;
        }
        public string PascalsSymbol => "pa";

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
        public string TorrsSymbol => "torr";


    }
}
