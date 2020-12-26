using ADHFormCalAPI.Models.Converters;

namespace ADHFormCalAPI.Calculator.Converters
{
    public class TimeConvertingOperations
    {
        private readonly string _operationUnit;
        private readonly double _value;


        public TimeConvertingOperations(string operationUnit, double value)
        {
            _operationUnit = operationUnit;
            _value = value;
        }

        public TimeModel TimeConverting()
        {
            TimeModel model = new TimeModel();

            //s
            if (model.SecondSymbol.ToString() == _operationUnit)
            {
                model.Second = _value;
                model.Minute = _value / 60;
                model.Hour = _value / 3600;
                model.Day = _value / 86400;
                model.Week = _value / 604800;
                model.Month = _value / 2628000;

                return model;
            }

            //m
            if (model.MinuteSymbol.ToString() == _operationUnit)
            {
                model.Second = _value * 60;
                model.Minute = _value;
                model.Hour = _value / 60;
                model.Day = _value / 1440;
                model.Week = _value / 10080;
                model.Month = _value / 43800;

                return model;
            }

            //h
            if (model.HourSymbol.ToString() == _operationUnit)
            {
                model.Second = _value * 3600;
                model.Minute = _value * 60;
                model.Hour = _value;
                model.Day = _value / 24;
                model.Week = _value / 168;
                model.Month = _value / 730;

                return model;
            }

            //d
            if (model.DaySymbol.ToString() == _operationUnit)
            {
                model.Second = _value * 86400;
                model.Minute = _value * 1440;
                model.Hour = _value * 24;
                model.Day = _value;
                model.Week = _value / 7;
                model.Month = _value / 30.417;

                return model;
            }

            //w
            if (model.WeekSymbol.ToString() == _operationUnit)
            {
                model.Second = _value * 604800;
                model.Minute = _value * 10080;
                model.Hour = _value * 168;
                model.Day = _value * 7;
                model.Week = _value;
                model.Month = _value / 4.345;

                return model;
            }

            //M
            if (model.MonthSymbol.ToString() == _operationUnit)
            {
                model.Second = _value * 2628000;
                model.Minute = _value * 43800;
                model.Hour = _value * 730;
                model.Day = _value * 30.417;
                model.Week = _value * 4.345;
                model.Month = _value;

                return model;
            }
            return null;
        }
    }
}
