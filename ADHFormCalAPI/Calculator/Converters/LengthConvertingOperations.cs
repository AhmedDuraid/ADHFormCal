using ADHFormCalAPI.Models.Converters;

namespace ADHFormCalAPI.Calculator.Converters
{
    public class LengthConvertingOperations
    {
        private string OperationUnit { get; set; }
        private double Value { get; set; }

        public LengthConvertingOperations(string operationUnit, double value)
        {
            OperationUnit = operationUnit;
            Value = value;

        }

        public LengthModel LengthConverting()
        {
            LengthModel model = new LengthModel();

            //km
            if (model.KilometerSymbol == OperationUnit)
            {
                model.Kilometers = Value;
                model.Meters = Value / 0.001;
                model.Centimeters = Value / 0.00001;
                model.Millimeters = Value / 0.000001;
                model.Miles = Value * 0.62137;
                model.Foot = Value * 3280.8;
                model.Yards = Value * 1093.6;
                model.Inches = Value * 39370;

                return model;
            }

            // m
            if (model.MeterSymbol.ToString() == OperationUnit)
            {
                model.Kilometers = Value / 1000;
                model.Meters = Value;
                model.Centimeters = Value / 0.010;
                model.Millimeters = Value / 0.001;
                model.Miles = Value * 0.00062137;
                model.Foot = Value * 3.2808;
                model.Yards = Value * 1.0936;
                model.Inches = Value * 39.37;

                return model;
            }

            //cm
            if (model.CentimeterSymbol == OperationUnit)
            {
                model.Kilometers = Value / 100000;
                model.Meters = Value / 100;
                model.Centimeters = Value;
                model.Millimeters = Value / 0.1;
                model.Miles = Value * 0.0000062137;
                model.Foot = Value * 0.032808;
                model.Yards = Value * 0.010936;
                model.Inches = Value * 0.39370;

                return model;
            }

            //mm
            if (model.MillimeterSymbol == OperationUnit)
            {
                model.Kilometers = Value / 1000000;
                model.Meters = Value / 1000;
                model.Centimeters = Value / 10;
                model.Millimeters = Value;
                model.Miles = Value * 0.00000062137;
                model.Foot = Value * 0.0032808;
                model.Yards = Value * 0.0010936;
                model.Inches = Value * 0.039370;

                return model;
            }

            //mi
            if (model.MilesSymbol == OperationUnit)
            {
                model.Kilometers = Value / 0.62137;
                model.Meters = Value / 0.00062137;
                model.Centimeters = Value / 0.0000062137;
                model.Millimeters = Value / 0.00000062137;
                model.Miles = Value;
                model.Foot = Value * 5280.0;
                model.Yards = Value * 1760.0;
                model.Inches = Value * 6336;

                return model;
            }

            //ft
            if (model.FootSymbol == OperationUnit)
            {
                model.Kilometers = Value / 3280.8;
                model.Meters = Value / 3.2808;
                model.Centimeters = Value / 0.032808;
                model.Millimeters = Value / 0.0032808;
                model.Miles = Value * 0.00018939;
                model.Foot = Value;
                model.Yards = Value * 0.33333;
                model.Inches = Value * 12;

                return model;
            }

            //yi
            if (model.YardSymbol == OperationUnit)
            {
                model.Kilometers = Value / 1093.6;
                model.Meters = Value / 1.0936;
                model.Centimeters = Value / 0.010936;
                model.Millimeters = Value / 0.0010936;

                model.Miles = Value * 0.00056818;
                model.Foot = Value * 3;
                model.Yards = Value;
                model.Inches = Value * 36;

                return model;
            }

            //in
            if (model.IncheSymbol == OperationUnit)
            {
                model.Kilometers = Value / 39370;
                model.Meters = Value / 39.370;
                model.Centimeters = Value / 0.39370;
                model.Millimeters = Value / 0.039370;

                model.Miles = Value * 0.000015783;
                model.Foot = Value * 0.083333;
                model.Yards = Value * 0.027778;
                model.Inches = Value;

                return model;
            }
            return model;
        }
    }
}
