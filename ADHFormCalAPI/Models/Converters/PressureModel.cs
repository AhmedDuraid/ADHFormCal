namespace ADHFormCalAPI.Models.Converters
{
    public class PressureModel
    {
        public double Pascals { get; set; }
        public string PascalsSymbol => "pa";

        public double Bar { get; set; }
        public string BarSymbol => "bar";

        public double Torrs { get; set; }
        public string TorrsSymbol => "torr";


    }
}
