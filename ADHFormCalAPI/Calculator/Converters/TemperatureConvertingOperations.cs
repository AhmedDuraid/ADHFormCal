using ADHFormCalAPI.Models.Converters;

namespace ADHFormCalAPI.Calculator.Converters
{
    public class TemperatureConvertingOperations
    {
        private string OperationUnit { get; set; }
        private double Value { get; set; }
        private double FahrenheitCelsiusConst => 1.8;
        private double KelvinConst => 273.15;

        public TemperatureConvertingOperations(string operationUnit, double value)
        {
            OperationUnit = operationUnit;
            Value = value;
        }

        public TemperatureModel TemperatureConverting()
        {
            TemperatureModel model = new TemperatureModel();

            // C
            if (OperationUnit == model.CSymbol.ToString())
            {
                model.TemperatureC = Value;
                model.TemperatureF = (Value * FahrenheitCelsiusConst) + model.FreezingPointF;
                model.TemperatureK = Value + KelvinConst;

                return model;
            }

            //F
            if (OperationUnit == model.CSymbol.ToString())
            {
                model.TemperatureC = (Value - model.FreezingPointF) / FahrenheitCelsiusConst;
                model.TemperatureF = Value;
                model.TemperatureK = (Value - model.FreezingPointF) / KelvinConst;

                return model;
            }

            //K
            if (OperationUnit == model.CSymbol.ToString())
            {

                model.TemperatureC = Value - KelvinConst;
                model.TemperatureF = ((Value - KelvinConst) * model.FreezingPointF) + model.FreezingPointF;
                model.TemperatureK = Value;

                return model;
            }
            return null;
        }
    }
}
