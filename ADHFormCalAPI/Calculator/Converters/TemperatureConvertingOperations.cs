using ADHFormCalAPI.Models.Converters;

namespace ADHFormCalAPI.Calculator.Converters
{
    public class TemperatureConvertingOperations
    {
        private readonly string _operationUnit;
        private readonly double _value;
        private readonly double _fahrenheitCelsiusConst;
        private readonly double _kelvinConst;

        public TemperatureConvertingOperations(string operationUnit, double value)
        {
            _operationUnit = operationUnit;
            _value = value;
            _fahrenheitCelsiusConst = 1.8;
            _kelvinConst = 273.15;
        }

        public TemperatureModel TemperatureConverting()
        {
            TemperatureModel model = new TemperatureModel();

            // c
            if (_operationUnit == model.CSymbol.ToString())
            {
                model.TemperatureC = _value;
                model.TemperatureF = (_value * _fahrenheitCelsiusConst) + model.FreezingPointF;
                model.TemperatureK = _value + _kelvinConst;

                return model;
            }

            //f
            if (_operationUnit == model.CSymbol.ToString())
            {
                model.TemperatureC = (_value - model.FreezingPointF) / _fahrenheitCelsiusConst;
                model.TemperatureF = _value;
                model.TemperatureK = (_value - model.FreezingPointF) / _kelvinConst;

                return model;
            }

            //k
            if (_operationUnit == model.CSymbol.ToString())
            {

                model.TemperatureC = _value - _kelvinConst;
                model.TemperatureF = ((_value - _kelvinConst) * model.FreezingPointF) + model.FreezingPointF;
                model.TemperatureK = _value;

                return model;
            }
            return null;
        }
    }
}
