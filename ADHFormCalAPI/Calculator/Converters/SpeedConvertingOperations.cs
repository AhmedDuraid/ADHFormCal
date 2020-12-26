using ADHFormCalAPI.Models.Converters;

namespace ADHFormCalAPI.Calculator.Converters
{
    public class SpeedConvertingOperations
    {
        private readonly string _operationUnit;
        private readonly double _value;

        public SpeedConvertingOperations(string operationUnit, double value)
        {
            _operationUnit = operationUnit;
            _value = value;
        }

        public SpeedModel SpeedConverting()
        {
            SpeedModel model = new SpeedModel();

            //kmph
            if (model.KilometersPerHourSymbol == _operationUnit)
            {
                model.KilometersPerHour = _value;
                model.Knots = _value / 1.852;
                model.MilesPerHour = _value / 1.609;

                return model;
            }

            //kn
            if (model.KnotsSymbol == _operationUnit)
            {
                model.KilometersPerHour = _value * 1.852;
                model.Knots = _value;
                model.MilesPerHour = _value * 1.151;

                return model;
            }

            //mph
            if (model.MilesPerHourSymbol == _operationUnit)
            {
                model.KilometersPerHour = _value * 1.609;
                model.Knots = _value / 1.151;
                model.MilesPerHour = _value;
            }

            return null;
        }
    }
}
