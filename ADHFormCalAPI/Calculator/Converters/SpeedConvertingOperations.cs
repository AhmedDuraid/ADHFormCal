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
            double KilometersPerHour;
            double Knots;
            double MilesPerHour;

            //kmph
            if (model.KilometersPerHourSymbol == OperationUnit)
            {
                KilometersPerHour = Value;
                Knots = Value / 1.852;
                MilesPerHour = Value / 1.609;

                SetWorldWideValues(model, KilometersPerHour, Knots);
                SetUSValues(model, MilesPerHour);

                return model;
            }

            //kn
            if (model.KnotsSymbol == OperationUnit)
            {
                KilometersPerHour = Value * 1.852;
                Knots = Value;
                MilesPerHour = Value * 1.151;

                SetWorldWideValues(model, KilometersPerHour, Knots);
                SetUSValues(model, MilesPerHour);

                return model;
            }

            //mph
            if (model.MilesPerHourSymbol == OperationUnit)
            {
                KilometersPerHour = Value * 1.609;
                Knots = Value / 1.151;
                MilesPerHour = Value;

                SetWorldWideValues(model, KilometersPerHour, Knots);
                SetUSValues(model, MilesPerHour);
            }

            return null;
        }
        private void SetWorldWideValues(SpeedModel model, double kilometersPerHour, double knots)
        {
            model.KilometersPerHour = kilometersPerHour;
            model.Knots = knots;
        }
        private void SetUSValues(SpeedModel model, double milesPerHour)
        {
            model.MilesPerHour = milesPerHour;
        }
    }
}
