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
                LengthMetricConverting(model, Value, Value / 0.001, Value / 0.00001, Value / 0.000001);
                LengthImperialConverting(model, Value * 0.62137, Value * 3280.8, Value * 1093.6, Value * 39370);

                return model;
            }

            // m
            if (model.MeterSymbol == OperationUnit)
            {
                LengthMetricConverting(model, Value / 1000, Value, Value / 0.010, Value / 0.001);
                LengthImperialConverting(model, Value * 0.00062137, Value * 3.2808, Value * 1.0936, Value * 39.37);

                return model;
            }

            //cm
            if (model.CentimeterSymbol == OperationUnit)
            {
                LengthMetricConverting(model, Value / 100000, Value / 100, Value, Value / 0.1);
                LengthImperialConverting(model, Value * 0.0000062137, Value * 0.032808, Value * 0.010936, Value * 0.39370);

                return model;
            }

            //mm
            if (model.MillimeterSymbol == OperationUnit)
            {
                LengthMetricConverting(model, Value / 1000000, Value / 1000, Value / 10, Value);
                LengthImperialConverting(model, Value * 0.00000062137, Value * 0.0032808, Value * 0.0010936, Value * 0.039370);

                return model;
            }

            //mi
            if (model.MilesSymbol == OperationUnit)
            {
                LengthMetricConverting(model, Value / 0.62137, Value / 0.00062137, Value / 0.0000062137, Value / 0.00000062137);
                LengthImperialConverting(model, Value, Value * 5280.0, Value * 1760.0, Value * 6336);

                return model;
            }

            //yi
            if (model.YardSymbol == OperationUnit)
            {
                LengthMetricConverting(model, Value / 1093.6, Value / 1.0936, Value / 0.010936, Value / 0.0010936);
                LengthImperialConverting(model, Value * 0.00056818, Value * 3, Value, Value * 36);

                return model;
            }

            //ft
            if (model.FootSymbol == OperationUnit)
            {
                LengthMetricConverting(model, Value / 3280.8, Value / 3.2808, Value / 0.032808, Value / 0.0032808);
                LengthImperialConverting(model, Value * 0.00018939, Value, Value * 0.33333, Value * 12);

                return model;
            }

            //in
            if (model.IncheSymbol == OperationUnit)
            {
                LengthMetricConverting(model, Value / 39370, Value / 39.370, Value / 0.39370, Value / 0.039370);
                LengthImperialConverting(model, Value * 0.000015783, Value * 0.083333, Value * 0.027778, Value);

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
