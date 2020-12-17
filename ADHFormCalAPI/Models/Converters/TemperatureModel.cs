namespace ADHFormCalAPI.Models.Converters
{
    public class TemperatureModel
    {
        private readonly double KelvinConst = 273.15;
        private readonly int _FreezingPointF = 32;
        private readonly double FahrenheitCelsiusConst = 1.8;

        public TemperatureModel(double temperature, char symbol)
        {
            SetTemperature(temperature, symbol);
        }

        // Celsius 
        public double TemperatureC { get; set; }
        public double FreezingPointC { get; } = 0;
        public int BoilingPointC { get; } = 100;
        public int BodyTempC { get; } = 37;
        public string SymbolC { get; } = "C";

        // Fahrenheit 
        public double TemperatureF { get; set; }
        public double FreezingPointF { get => _FreezingPointF; }
        public int BoilingPointF { get; } = 212;
        public string SymbolF { get; } = "F";
        public double BodyTempF { get; } = 98.6;

        // Kelvin 
        public double TemperatureK { get; set; }
        public string SymbolK { get; } = "K";

        private void SetTemperature(double temperature, char symbol)
        {
            switch (symbol)
            {
                case 'C':
                    {

                        TemperatureC = temperature;
                        TemperatureF = (temperature * FahrenheitCelsiusConst) + _FreezingPointF;
                        TemperatureK = temperature + KelvinConst;

                        break;
                    }

                case 'F':
                    {
                        TemperatureF = temperature;
                        TemperatureC = (temperature - _FreezingPointF) / FahrenheitCelsiusConst;
                        TemperatureK = TemperatureC + KelvinConst;

                        break;

                    }
                case 'K':
                    {
                        TemperatureK = temperature;
                        TemperatureC = temperature - KelvinConst;
                        TemperatureF = (TemperatureC * FahrenheitCelsiusConst) + _FreezingPointF;

                        break;
                    }
            }
        }
    }
}
