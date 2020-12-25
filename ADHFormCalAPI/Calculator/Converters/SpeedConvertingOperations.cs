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
