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
            double Pascal;
            double Bar;
            double Torr;
            // pa
            if (model.PascalsSymbol == OperationUnit)
            {
                Pascal = Value;
                Bar = Value / 100000;
                Torr = Value * 0.0075006;

                SetValues(model, Pascal, Bar, Torr);

                return model;
            }

            // bar
            if (model.BarSymbol == OperationUnit)
            {
                Pascal = Value / 0.000010000;
                Bar = Value;
                Torr = Value * 750.06;

                SetValues(model, Pascal, Bar, Torr);

                return model;
            }

            //torr
            if (model.TorrsSymbol == OperationUnit)
            {
                Pascal = Value / 0.0075006;
                Bar = Value / 750.06;
                Torr = Value;

                SetValues(model, Pascal, Bar, Torr);

                return model;
            }
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
