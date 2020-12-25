namespace ADHFormCalAPI.Models.Converters
{
    public class TemperatureModel
    {
        // Celsius 
        public double TemperatureC { get; set; }
        public double FreezingPointC => 0;
        public int BoilingPointC => 100;
        public int BodyTempC => 37;
        public char SymbolC => 'C';

        // Fahrenheit 
        public double TemperatureF { get; set; }
        public int FreezingPointF => 32;
        public int BoilingPointF => 212;
        public char SymbolF => 'F';
        public double BodyTempF => 98.6;

        // Kelvin 
        public double TemperatureK { get; set; }
        public char SymbolK => 'K';
    }
}
