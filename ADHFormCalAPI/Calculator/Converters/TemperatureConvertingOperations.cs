using ADHFormCalAPI.Models.Converters;

namespace ADHFormCalAPI.Calculator.Converters
{
    public class TemperatureConvertingOperations : ITemperatureConvertingOperations
    {

        private readonly double _fahrenheitCelsiusConst;
        private readonly double _kelvinConst;
        private readonly double _freezingPointF;

        private readonly TemperatureModel temperatureModel;

        public TemperatureConvertingOperations()
        {
            _fahrenheitCelsiusConst = 1.8;
            _kelvinConst = 273.15;
            _freezingPointF = temperatureModel.FreezingPointF;
        }

        public TemperatureModel FromC(double CValue)
        {
            return new TemperatureModel
            {
                TemperatureC = CValue,
                TemperatureF = (CValue * _fahrenheitCelsiusConst) + _freezingPointF,
                TemperatureK = CValue + _kelvinConst
            };
        }
        public TemperatureModel FromF(double FValue)
        {
            return new TemperatureModel
            {
                TemperatureC = (FValue - _freezingPointF) / _fahrenheitCelsiusConst,
                TemperatureF = FValue,
                TemperatureK = (FValue - _freezingPointF) / _kelvinConst
            };
        }
        public TemperatureModel FromK(double KValue)
        {
            return new TemperatureModel
            {
                TemperatureC = KValue - _kelvinConst,
                TemperatureF = ((KValue - _kelvinConst) * _freezingPointF) + _freezingPointF,
                TemperatureK = KValue
            };
        }
    }
}
