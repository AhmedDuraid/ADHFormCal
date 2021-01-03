using ADHFormCalAPI.Models.Converters;

namespace ADHFormCalAPI.Calculator.Converters
{
    public interface ITimeConvertingOperations
    {
        TimeModel FromDay(double dayValue);
        TimeModel FromHour(double hourTime);
        TimeModel FromMinute(double minuteValue);
        TimeModel FromMonth(double monthValue);
        TimeModel FromSecond(double secondValue);
        TimeModel FromWeek(double weekValue);
    }
}