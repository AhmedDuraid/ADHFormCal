using ADHFormCalAPI.Models.Converters;

namespace ADHFormCalAPI.Calculator.Converters
{
    public class PressureConvertingOperations
    {
        private readonly string _operationUnit;
        private readonly double _value;

        public PressureConvertingOperations(string operationUnit, double value)
        {
            _operationUnit = operationUnit;
            _value = value;
        }

        public PressureModel PressureConverting()
        {
            PressureModel model = new PressureModel();

            // pa
            if (model.PascalsSymbol == _operationUnit)
            {
                model.Pascals = _value;
                model.Bar = _value / 100000;
                model.Torrs = _value * 0.0075006;

                return model;
            }

            // bar
            if (model.BarSymbol == _operationUnit)
            {
                model.Pascals = _value / 0.000010000;
                model.Bar = _value;
                model.Torrs = _value * 750.06;

                return model;
            }

            //torr
            if (model.TorrsSymbol == _operationUnit)
            {
                model.Pascals = _value / 0.0075006;
                model.Bar = _value / 750.06;
                model.Torrs = _value;

                return model;
            }
            return null;
        }
    }
}
