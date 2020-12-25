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
            double TempC;
            double TempF;
            double TempK;

            // C
            if (OperationUnit == model.SymbolC.ToString())
            {
                TempC = Value;
                TempF = (Value * FahrenheitCelsiusConst) + model.FreezingPointF;
                TempK = Value + KelvinConst;

                SetTempreatureValues(model, TempC, TempF, TempK);

                return model;
            }

            //F
            if (OperationUnit == model.SymbolC.ToString())
            {
                TempC = (Value - model.FreezingPointF) / FahrenheitCelsiusConst;
                TempF = Value;
                TempK = (Value - model.FreezingPointF) / KelvinConst;

                SetTempreatureValues(model, TempC, TempF, TempK);

                return model;
            }

            //K
            if (OperationUnit == model.SymbolC.ToString())
            {

                TempC = Value - KelvinConst;
                TempF = ((Value - KelvinConst) * model.FreezingPointF) + model.FreezingPointF;
                TempK = Value;

                SetTempreatureValues(model, TempC, TempF, TempK);

                return model;
            }
            return null;
        }

        private void SetTempreatureValues(TemperatureModel model, double c, double f, double k)
        {
            model.TemperatureC = c;
            model.TemperatureF = f;
            model.TemperatureK = k;
        }
    }
}
