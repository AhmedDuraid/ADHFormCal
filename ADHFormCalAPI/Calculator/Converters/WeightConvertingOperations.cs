using ADHFormCalAPI.Models.Converters;

namespace ADHFormCalAPI.Calculator.Converters
{
    public class WeightConvertingOperations
    {
        private string OperationUnit { get; set; }
        private double Value { get; set; }


        public WeightConvertingOperations(string operationUnit, double value)
        {
            OperationUnit = operationUnit;
            Value = value;
        }

        public WeightModel WeightConverting()
        {
            WeightModel model = new WeightModel();

            //t
            if (OperationUnit == model.TonnesSymbol.ToString())
            {
                model.Tonnes = Value;
                model.Kilograms = Value / 0.001;
                model.Grams = Value / 0.000001;
                model.Milligrams = Value / 0.000000001;
                model.Pounds = Value * 2204.6;
                model.Ounces = Value * 35274;

                return model;
            }

            //kg
            if (OperationUnit == model.KilogramsSymbol)
            {
                model.Tonnes = Value / 1000;
                model.Kilograms = Value;
                model.Grams = Value / 0.001;
                model.Milligrams = Value / 0.000001;
                model.Pounds = Value * 2.2046;
                model.Ounces = Value * 35.274;

                return model;
            }

            //g
            if (OperationUnit == model.GramsSymbol.ToString())
            {
                model.Tonnes = Value / 1000000;
                model.Kilograms = Value / 1000;
                model.Grams = Value;
                model.Milligrams = Value / 0.001;
                model.Pounds = Value * 0.0022046;
                model.Ounces = Value * 0.035274;

                return model;

            }

            //mg
            if (OperationUnit == model.KilogramsSymbol)
            {
                model.Tonnes = Value / 1000000000;
                model.Kilograms = Value / 1000000;
                model.Grams = Value / 1000;
                model.Milligrams = Value;
                model.Pounds = Value * 0.0000022046;
                model.Ounces = Value * 0.000035274;

                return model;
            }

            //ib
            if (OperationUnit == model.PoundsSymbol)
            {
                model.Tonnes = Value / 2204.6;
                model.Kilograms = Value / 2.2046;
                model.Grams = Value / 0.0022046;
                model.Milligrams = Value / 0.0000022046;
                model.Pounds = Value;
                model.Ounces = Value * 16.000;

                return model;
            }

            //oz
            if (OperationUnit == model.OuncesSymbol)
            {
                model.Tonnes = Value / 35274;
                model.Kilograms = Value / 35.274;
                model.Grams = Value / 0.035274;
                model.Milligrams = Value / 0.000035274;
                model.Pounds = Value * 0.062500;
                model.Ounces = Value;

                return model;
            }
            return null;
        }
    }
}
