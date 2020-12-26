using ADHFormCalAPI.Models.Converters;

namespace ADHFormCalAPI.Calculator.Converters
{
    public class WeightConvertingOperations
    {
        private readonly string _operationUnit;
        private readonly double _value;


        public WeightConvertingOperations(string operationUnit, double value)
        {
            _operationUnit = operationUnit;
            _value = value;
        }

        public WeightModel WeightConverting()
        {
            WeightModel model = new WeightModel();

            //t
            if (_operationUnit == model.TonnesSymbol.ToString())
            {
                model.Tonnes = _value;
                model.Kilograms = _value / 0.001;
                model.Grams = _value / 0.000001;
                model.Milligrams = _value / 0.000000001;
                model.Pounds = _value * 2204.6;
                model.Ounces = _value * 35274;

                return model;
            }

            //kg
            if (_operationUnit == model.KilogramsSymbol)
            {
                model.Tonnes = _value / 1000;
                model.Kilograms = _value;
                model.Grams = _value / 0.001;
                model.Milligrams = _value / 0.000001;
                model.Pounds = _value * 2.2046;
                model.Ounces = _value * 35.274;

                return model;
            }

            //g
            if (_operationUnit == model.GramsSymbol.ToString())
            {
                model.Tonnes = _value / 1000000;
                model.Kilograms = _value / 1000;
                model.Grams = _value;
                model.Milligrams = _value / 0.001;
                model.Pounds = _value * 0.0022046;
                model.Ounces = _value * 0.035274;

                return model;

            }

            //mg
            if (_operationUnit == model.KilogramsSymbol)
            {
                model.Tonnes = _value / 1000000000;
                model.Kilograms = _value / 1000000;
                model.Grams = _value / 1000;
                model.Milligrams = _value;
                model.Pounds = _value * 0.0000022046;
                model.Ounces = _value * 0.000035274;

                return model;
            }

            //ib
            if (_operationUnit == model.PoundsSymbol)
            {
                model.Tonnes = _value / 2204.6;
                model.Kilograms = _value / 2.2046;
                model.Grams = _value / 0.0022046;
                model.Milligrams = _value / 0.0000022046;
                model.Pounds = _value;
                model.Ounces = _value * 16.000;

                return model;
            }

            //oz
            if (_operationUnit == model.OuncesSymbol)
            {
                model.Tonnes = _value / 35274;
                model.Kilograms = _value / 35.274;
                model.Grams = _value / 0.035274;
                model.Milligrams = _value / 0.000035274;
                model.Pounds = _value * 0.062500;
                model.Ounces = _value;

                return model;
            }
            return null;
        }
    }
}
