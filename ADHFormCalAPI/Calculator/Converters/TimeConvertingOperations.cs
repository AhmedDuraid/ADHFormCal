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
            double Second, Minute, Hour, Day, Week, Month;

            //s
            if (model.SecondSymbol.ToString() == OperationUnit)
            {
                Second = Value;
                Minute = Value / 60;
                Hour = Value / 3600;
                Day = Value / 86400;
                Week = Value / 604800;
                Month = Value / 2628000;

                SetHourRelatedValues(model, Second, Minute, Hour);
                SetDayRelatedValues(model, Day, Week, Month);

                return model;
            }

            //m
            if (model.MinuteSymbol.ToString() == OperationUnit)
            {
                Second = Value * 60;
                Minute = Value;
                Hour = Value / 60;
                Day = Value / 1440;
                Week = Value / 10080;
                Month = Value / 43800;

                SetHourRelatedValues(model, Second, Minute, Hour);
                SetDayRelatedValues(model, Day, Week, Month);

                return model;
            }

            //h
            if (model.HourSymbol.ToString() == OperationUnit)
            {
                Second = Value * 3600;
                Minute = Value * 60;
                Hour = Value;
                Day = Value / 24;
                Week = Value / 168;
                Month = Value / 730;

                SetHourRelatedValues(model, Second, Minute, Hour);
                SetDayRelatedValues(model, Day, Week, Month);

                return model;
            }

            //d
            if (model.DaySymbol.ToString() == OperationUnit)
            {
                Second = Value * 86400;
                Minute = Value * 1440;
                Hour = Value * 24;
                Day = Value;
                Week = Value / 7;
                Month = Value / 30.417;

                SetHourRelatedValues(model, Second, Minute, Hour);
                SetDayRelatedValues(model, Day, Week, Month);

                return model;
            }

            //w
            if (model.WeekSymbol.ToString() == OperationUnit)
            {
                Second = Value * 604800;
                Minute = Value * 10080;
                Hour = Value * 168;
                Day = Value * 7;
                Week = Value;
                Month = Value / 4.345;

                SetHourRelatedValues(model, Second, Minute, Hour);
                SetDayRelatedValues(model, Day, Week, Month);

                return model;
            }

            //M
            if (model.MonthSymbol.ToString() == OperationUnit)
            {
                Second = Value * 2628000;
                Minute = Value * 43800;
                Hour = Value * 730;
                Day = Value * 30.417;
                Week = Value * 4.345;
                Month = Value;

                SetHourRelatedValues(model, Second, Minute, Hour);
                SetDayRelatedValues(model, Day, Week, Month);

                return model;
            }
            return null;
        }

        private void SetHourRelatedValues(TimeModel model, double second, double minute, double hour)
        {
            model.Second = second;
            model.Minute = minute;
            model.Hour = hour;
        }
        private void SetDayRelatedValues(TimeModel model, double day, double week, double month)
        {
            model.Day = day;
            model.Week = week;
            model.Month = month;
        }
    }
}
