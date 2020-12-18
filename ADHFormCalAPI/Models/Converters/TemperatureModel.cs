namespace ADHFormCalAPI.Models.Converters
{
    public class TemperatureModel
    {
        private readonly double KelvinConst = 273.15;
        private readonly int _FreezingPointF = 32;
        private readonly double FahrenheitCelsiusConst = 1.8;

        private double _TemperatureC, _TemperatureF, _TemperatureK;

        public TemperatureModel(double temperature, char symbol)
        {
            SetTemperature(temperature, symbol);
        }

        // Celsius 
        public double TemperatureC { get => _TemperatureC; }
        public double FreezingPointC { get => 0; }
        public int BoilingPointC { get => 100; }
        public int BodyTempC { get => 37; }
        public char SymbolC { get => 'C'; }

        // Fahrenheit 
        public double TemperatureF { get => _TemperatureF; }
        public int FreezingPointF { get => _FreezingPointF; }
        public int BoilingPointF { get => 212; }
        public char SymbolF { get => 'F'; }
        public double BodyTempF { get => 98.6; }

        // Kelvin 
        public double TemperatureK { get => _TemperatureK; }
        public char SymbolK { get => 'K'; }

        private void SetTemperature(double temperature, char symbol)
        {
            switch (symbol)
            {
                case 'C':
                    {

                        _TemperatureC = temperature;
                        _TemperatureF = (temperature * FahrenheitCelsiusConst) + _FreezingPointF;
                        _TemperatureK = temperature + KelvinConst;

                        break;
                    }

                case 'F':
                    {
                        _TemperatureF = temperature;
                        _TemperatureC = (temperature - _FreezingPointF) / FahrenheitCelsiusConst;
                        _TemperatureK = TemperatureC + KelvinConst;

                        break;

                    }
                case 'K':
                    {
                        _TemperatureK = temperature;
                        _TemperatureC = temperature - KelvinConst;
                        _TemperatureF = (TemperatureC * FahrenheitCelsiusConst) + _FreezingPointF;

                        break;
                    }
            }
        }
    }
}
