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
            PressureModel model = new PressureModel();

            // pa
            if (model.PascalsSymbol == OperationUnit)
            {
                model.Pascals = Value;
                model.Bar = Value / 100000;
                model.Torrs = Value * 0.0075006;

                return model;
            }

            // bar
            if (model.BarSymbol == OperationUnit)
            {
                model.Pascals = Value / 0.000010000;
                model.Bar = Value;
                model.Torrs = Value * 750.06;

                return model;
            }

            //torr
            if (model.TorrsSymbol == OperationUnit)
            {
                model.Pascals = Value / 0.0075006;
                model.Bar = Value / 750.06;
                model.Torrs = Value;

                return model;
            }
            return null;
        }
    }
}
