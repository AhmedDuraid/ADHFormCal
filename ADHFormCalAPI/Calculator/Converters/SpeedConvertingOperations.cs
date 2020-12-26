using ADHFormCalAPI.Models.Converters;

namespace ADHFormCalAPI.Calculator.Converters
{
    public class SpeedConvertingOperations
    {
        private string OperationUnit { get; set; }
        private double Value { get; set; }

        public SpeedConvertingOperations(string operationUnit, double value)
        {
            OperationUnit = operationUnit;
            Value = value;
        }

        public SpeedModel SpeedConverting()
        {
            SpeedModel model = new SpeedModel();

            //kmph
            if (model.KilometersPerHourSymbol == OperationUnit)
            {
                model.KilometersPerHour = Value;
                model.Knots = Value / 1.852;
                model.MilesPerHour = Value / 1.609;

                return model;
            }

            //kn
            if (model.KnotsSymbol == OperationUnit)
            {
                model.KilometersPerHour = Value * 1.852;
                model.Knots = Value;
                model.MilesPerHour = Value * 1.151;

                return model;
            }

            //mph
            if (model.MilesPerHourSymbol == OperationUnit)
            {
                model.KilometersPerHour = Value * 1.609;
                model.Knots = Value / 1.151;
                model.MilesPerHour = Value;
            }

            return null;
        }
    }
}
