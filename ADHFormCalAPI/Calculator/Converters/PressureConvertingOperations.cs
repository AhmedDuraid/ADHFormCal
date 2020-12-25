using ADHFormCalAPI.Models.Converters;

namespace ADHFormCalAPI.Calculator.Converters
{
    public class PressureConvertingOperations
    {
        private string OperationUnit { get; set; }
        private double Value { get; set; }

        public PressureConvertingOperations(string operationUnit, double value)
        {
            OperationUnit = operationUnit;
            Value = value;

        }

        public PressureModel PressureConverting()
        {
            return null;
        }

        private void SetValues(PressureModel model, double pascals, double bar, double torrs)
        {
            model.Pascals = pascals;
            model.Bar = bar;
            model.Torrs = torrs;
        }
    }
}
