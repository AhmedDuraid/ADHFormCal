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
