namespace ADHFormCalAPI.Models.Converters
{
    public class TemperatureModel
    {
        private readonly double _kelvinConst = 273.15;
        private readonly int _freezingPointF = 32;
        private readonly double _fahrenheitCelsiusConst = 1.8;

        public TemperatureModel(double temperature, char unit)
        {
            TemperatureConverting(temperature, unit);
        }

        // Celsius 
        public double TemperatureC { get; set; }
        public double FreezingPointC => 0;
        public int BoilingPointC => 100;
        public int BodyTempC => 37;
        public char SymbolC => 'C';

        // Fahrenheit 
        public double TemperatureF { get; set; }
        public int FreezingPointF => _freezingPointF;
        public int BoilingPointF => 212;
        public char SymbolF => 'F';
        public double BodyTempF => 98.6;

        // Kelvin 
        public double TemperatureK { get; set; }
        public char SymbolK => 'K';

        private void TemperatureConverting(double temperature, char unit)
        {
            switch (unit)
            {
                case 'c':
                    {
                        SetTemperatureCValue(temperature);
                        SetTemperatureFValue((temperature * _fahrenheitCelsiusConst) + _freezingPointF);
                        SetTemperatureKValue(temperature + _kelvinConst);
                        break;
                    }

                case 'f':
                    {
                        SetTemperatureCValue((temperature - _freezingPointF) / _fahrenheitCelsiusConst);
                        SetTemperatureFValue(temperature);
                        SetTemperatureKValue((temperature - _freezingPointF) / _kelvinConst);
                        break;
                    }
                case 'k':
                    {
                        SetTemperatureCValue(temperature - _kelvinConst);
                        SetTemperatureFValue(((temperature - _kelvinConst) * _freezingPointF) + _freezingPointF);
                        SetTemperatureKValue(temperature);
                        break;
                    }
            }
        }

        private void SetTemperatureCValue(double temperatureC)
        {
            TemperatureC = temperatureC;
        }
        private void SetTemperatureFValue(double temperatureF)
        {
            TemperatureF = temperatureF;
        }
        private void SetTemperatureKValue(double temperatureK)
        {
            TemperatureK = temperatureK;
        }
    }
}
