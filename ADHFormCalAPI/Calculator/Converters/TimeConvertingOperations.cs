using ADHFormCalAPI.Models.Converters;

namespace ADHFormCalAPI.Calculator.Converters
{
    public class TimeConvertingOperations
    {
        private string OperationUnit { get; set; }
        private double Value { get; set; }


        public TimeConvertingOperations(string operationUnit, double value)
        {
            OperationUnit = operationUnit;
            Value = value;
        }

        public TimeModel TimeConverting()
        {
            TimeModel model = new TimeModel();

            //s
            if (model.SecondSymbol.ToString() == OperationUnit)
            {
                model.Second = Value;
                model.Minute = Value / 60;
                model.Hour = Value / 3600;
                model.Day = Value / 86400;
                model.Week = Value / 604800;
                model.Month = Value / 2628000;

                return model;
            }

            //m
            if (model.MinuteSymbol.ToString() == OperationUnit)
            {
                model.Second = Value * 60;
                model.Minute = Value;
                model.Hour = Value / 60;
                model.Day = Value / 1440;
                model.Week = Value / 10080;
                model.Month = Value / 43800;

                return model;
            }

            //h
            if (model.HourSymbol.ToString() == OperationUnit)
            {
                model.Second = Value * 3600;
                model.Minute = Value * 60;
                model.Hour = Value;
                model.Day = Value / 24;
                model.Week = Value / 168;
                model.Month = Value / 730;

                return model;
            }

            //d
            if (model.DaySymbol.ToString() == OperationUnit)
            {
                model.Second = Value * 86400;
                model.Minute = Value * 1440;
                model.Hour = Value * 24;
                model.Day = Value;
                model.Week = Value / 7;
                model.Month = Value / 30.417;

                return model;
            }

            //w
            if (model.WeekSymbol.ToString() == OperationUnit)
            {
                model.Second = Value * 604800;
                model.Minute = Value * 10080;
                model.Hour = Value * 168;
                model.Day = Value * 7;
                model.Week = Value;
                model.Month = Value / 4.345;

                return model;
            }

            //M
            if (model.MonthSymbol.ToString() == OperationUnit)
            {
                model.Second = Value * 2628000;
                model.Minute = Value * 43800;
                model.Hour = Value * 730;
                model.Day = Value * 30.417;
                model.Week = Value * 4.345;
                model.Month = Value;

                return model;
            }
            return null;
        }
    }
}
