namespace ADHFormCalAPI.Models.Converters
{
    public class TemperatureModel
    {
        private readonly double KelvinConst = 273.15;
        private readonly int _FreezingPointF = 32;
        private readonly double FahrenheitCelsiusConst = 1.8;

        public TemperatureModel(double temperature, char unit)
        {
            SetTemperature(temperature, unit);
        }

        // Celsius 
        public double TemperatureC { get; set; }
        public double FreezingPointC => 0;
        public int BoilingPointC => 100;
        public int BodyTempC => 37;
        public char SymbolC => 'C';

        // Fahrenheit 
        public double TemperatureF { get; set; }
        public int FreezingPointF => _FreezingPointF;
        public int BoilingPointF => 212;
        public char SymbolF => 'F';
        public double BodyTempF => 98.6;

        // Kelvin 
        public double TemperatureK { get; set; }
        public char SymbolK => 'K';

        private void SetTemperature(double temperature, char unit)
        {
            switch (unit)
            {
                case 'C':
                    {
                        SetValues(temperature, (temperature * FahrenheitCelsiusConst) + _FreezingPointF,
                            temperature + KelvinConst);
                        break;
                    }

                case 'F':
                    {
                        SetValues((temperature - _FreezingPointF) / FahrenheitCelsiusConst,
                            temperature, TemperatureC + KelvinConst);
                        break;

                    }
                case 'K':
                    {
                        SetValues(temperature - KelvinConst, (TemperatureC * FahrenheitCelsiusConst) + _FreezingPointF,
                            temperature);
                        break;
                    }
            }
        }

        private void SetValues(double temperatureC, double temperatureF, double temperatureK)
        {
            TemperatureC = temperatureC;
            TemperatureF = temperatureF;
            TemperatureK = temperatureK;
        }
    }
}
