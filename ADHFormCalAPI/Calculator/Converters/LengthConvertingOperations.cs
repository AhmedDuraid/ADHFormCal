using ADHFormCalAPI.Models.Converters;

namespace ADHFormCalAPI.Calculator.Converters
{
    public class LengthConvertingOperations
    {
        private readonly string _operationUnit;
        private readonly double _value;

        public LengthConvertingOperations(string operationUnit, double value)
        {
            _operationUnit = operationUnit;
            _value = value;

        }

        public LengthModel LengthConverting()
        {
            LengthModel model = new LengthModel();

            //km
            if (model.KilometerSymbol == _operationUnit)
            {
                model.Kilometers = _value;
                model.Meters = _value / 0.001;
                model.Centimeters = _value / 0.00001;
                model.Millimeters = _value / 0.000001;
                model.Miles = _value * 0.62137;
                model.Foot = _value * 3280.8;
                model.Yards = _value * 1093.6;
                model.Inches = _value * 39370;

                return model;
            }

            // m
            if (model.MeterSymbol.ToString() == _operationUnit)
            {
                model.Kilometers = _value / 1000;
                model.Meters = _value;
                model.Centimeters = _value / 0.010;
                model.Millimeters = _value / 0.001;
                model.Miles = _value * 0.00062137;
                model.Foot = _value * 3.2808;
                model.Yards = _value * 1.0936;
                model.Inches = _value * 39.37;

                return model;
            }

            //cm
            if (model.CentimeterSymbol == _operationUnit)
            {
                model.Kilometers = _value / 100000;
                model.Meters = _value / 100;
                model.Centimeters = _value;
                model.Millimeters = _value / 0.1;
                model.Miles = _value * 0.0000062137;
                model.Foot = _value * 0.032808;
                model.Yards = _value * 0.010936;
                model.Inches = _value * 0.39370;

                return model;
            }

            //mm
            if (model.MillimeterSymbol == _operationUnit)
            {
                model.Kilometers = _value / 1000000;
                model.Meters = _value / 1000;
                model.Centimeters = _value / 10;
                model.Millimeters = _value;
                model.Miles = _value * 0.00000062137;
                model.Foot = _value * 0.0032808;
                model.Yards = _value * 0.0010936;
                model.Inches = _value * 0.039370;

                return model;
            }

            //mi
            if (model.MilesSymbol == _operationUnit)
            {
                model.Kilometers = _value / 0.62137;
                model.Meters = _value / 0.00062137;
                model.Centimeters = _value / 0.0000062137;
                model.Millimeters = _value / 0.00000062137;
                model.Miles = _value;
                model.Foot = _value * 5280.0;
                model.Yards = _value * 1760.0;
                model.Inches = _value * 6336;

                return model;
            }

            //ft
            if (model.FootSymbol == _operationUnit)
            {
                model.Kilometers = _value / 3280.8;
                model.Meters = _value / 3.2808;
                model.Centimeters = _value / 0.032808;
                model.Millimeters = _value / 0.0032808;
                model.Miles = _value * 0.00018939;
                model.Foot = _value;
                model.Yards = _value * 0.33333;
                model.Inches = _value * 12;

                return model;
            }

            //yi
            if (model.YardSymbol == _operationUnit)
            {
                model.Kilometers = _value / 1093.6;
                model.Meters = _value / 1.0936;
                model.Centimeters = _value / 0.010936;
                model.Millimeters = _value / 0.0010936;

                model.Miles = _value * 0.00056818;
                model.Foot = _value * 3;
                model.Yards = _value;
                model.Inches = _value * 36;

                return model;
            }

            //in
            if (model.IncheSymbol == _operationUnit)
            {
                model.Kilometers = _value / 39370;
                model.Meters = _value / 39.370;
                model.Centimeters = _value / 0.39370;
                model.Millimeters = _value / 0.039370;

                model.Miles = _value * 0.000015783;
                model.Foot = _value * 0.083333;
                model.Yards = _value * 0.027778;
                model.Inches = _value;

                return model;
            }
            return model;
        }
    }
}
