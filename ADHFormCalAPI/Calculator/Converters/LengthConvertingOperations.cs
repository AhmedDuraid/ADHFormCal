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

            double Kilometers, Meters, Centimeters, Millimeters, Miles, Foot, Yards, Inches;

            //km
            if (model.KilometerSymbol == OperationUnit)
            {
                Kilometers = Value;
                Meters = Value / 0.001;
                Centimeters = Value / 0.00001;
                Millimeters = Value / 0.000001;

                Miles = Value * 0.62137;
                Foot = Value * 3280.8;
                Yards = Value * 1093.6;
                Inches = Value * 39370;

                LengthMetricConverting(model, Kilometers, Meters, Centimeters, Millimeters);
                LengthImperialConverting(model, Miles, Foot, Yards, Inches);

                return model;
            }

            // m
            if (model.MeterSymbol == OperationUnit)
            {
                Kilometers = Value / 1000;
                Meters = Value;
                Centimeters = Value / 0.010;
                Millimeters = Value / 0.001;

                Miles = Value * 0.00062137;
                Foot = Value * 3.2808;
                Yards = Value * 1.0936;
                Inches = Value * 39.37;

                LengthMetricConverting(model, Kilometers, Meters, Centimeters, Millimeters);
                LengthImperialConverting(model, Miles, Foot, Yards, Inches);

                return model;
            }

            //cm
            if (model.CentimeterSymbol == OperationUnit)
            {
                Kilometers = Value / 100000;
                Meters = Value / 100;
                Centimeters = Value;
                Millimeters = Value / 0.1;

                Miles = Value * 0.0000062137;
                Foot = Value * 0.032808;
                Yards = Value * 0.010936;
                Inches = Value * 0.39370;

                LengthMetricConverting(model, Kilometers, Meters, Centimeters, Millimeters);
                LengthImperialConverting(model, Miles, Foot, Yards, Inches);

                return model;
            }

            //mm
            if (model.MillimeterSymbol == OperationUnit)
            {
                Kilometers = Value / 1000000;
                Meters = Value / 1000;
                Centimeters = Value / 10;
                Millimeters = Value;

                Miles = Value * 0.00000062137;
                Foot = Value * 0.0032808;
                Yards = Value * 0.0010936;
                Inches = Value * 0.039370;

                LengthMetricConverting(model, Kilometers, Meters, Centimeters, Millimeters);
                LengthImperialConverting(model, Miles, Foot, Yards, Inches);

                return model;
            }

            //mi
            if (model.MilesSymbol == OperationUnit)
            {
                Kilometers = Value / 0.62137;
                Meters = Value / 0.00062137;
                Centimeters = Value / 0.0000062137;
                Millimeters = Value / 0.00000062137;

                Miles = Value;
                Foot = Value * 5280.0;
                Yards = Value * 1760.0;
                Inches = Value * 6336;

                LengthMetricConverting(model, Kilometers, Meters, Centimeters, Millimeters);
                LengthImperialConverting(model, Miles, Foot, Yards, Inches);

                return model;
            }
            //ft
            if (model.FootSymbol == OperationUnit)
            {
                Kilometers = Value / 3280.8;
                Meters = Value / 3.2808;
                Centimeters = Value / 0.032808;
                Millimeters = Value / 0.0032808;

                Miles = Value * 0.00018939;
                Foot = Value;
                Yards = Value * 0.33333;
                Inches = Value * 12;

                LengthMetricConverting(model, Kilometers, Meters, Centimeters, Millimeters);
                LengthImperialConverting(model, Miles, Foot, Yards, Inches);

                return model;
            }

            //yi
            if (model.YardSymbol == OperationUnit)
            {
                Kilometers = Value / 1093.6;
                Meters = Value / 1.0936;
                Centimeters = Value / 0.010936;
                Millimeters = Value / 0.0010936;

                Miles = Value * 0.00056818;
                Foot = Value * 3;
                Yards = Value;
                Inches = Value * 36;

                LengthMetricConverting(model, Kilometers, Meters, Centimeters, Millimeters);
                LengthImperialConverting(model, Miles, Foot, Yards, Inches);

                return model;
            }

            //in
            if (model.IncheSymbol == OperationUnit)
            {
                Kilometers = Value / 39370;
                Meters = Value / 39.370;
                Centimeters = Value / 0.39370;
                Millimeters = Value / 0.039370;

                Miles = Value * 0.000015783;
                Foot = Value * 0.083333;
                Yards = Value * 0.027778;
                Inches = Value;

                LengthMetricConverting(model, Kilometers, Meters, Centimeters, Millimeters);
                LengthImperialConverting(model, Miles, Foot, Yards, Inches);

                return model;
            }
            return model;
        }


        private void LengthMetricConverting(LengthModel model, double kilometers, double metersc, double centimeters, double millimeters)
        {
            model.Kilometers = kilometers;
            model.Meters = metersc;
            model.Centimeters = centimeters;
            model.Millimeters = millimeters;
        }
        private void LengthImperialConverting(LengthModel model, double miles, double foot, double yards, double inches)
        {
            model.Miles = miles;
            model.Foot = foot;
            model.Yards = yards;
            model.Inches = inches;
        }
    }
}
