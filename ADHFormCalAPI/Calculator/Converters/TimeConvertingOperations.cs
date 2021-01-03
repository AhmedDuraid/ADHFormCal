using ADHFormCalAPI.ErrorHandling;
using ADHFormCalAPI.Models.Converters;

namespace ADHFormCalAPI.Calculator.Converters
{
    public class TimeConvertingOperations : ITimeConvertingOperations
    {
        private readonly ICalculationValidation _calculationValidation;

        public TimeConvertingOperations(ICalculationValidation calculationValidation)
        {

            _calculationValidation = calculationValidation;
        }

        public TimeModel FromSecond(double secondValue)
        {
            _calculationValidation.LessThanZero(secondValue);

            return new TimeModel
            {
                Second = secondValue,
                Minute = secondValue / 60,
                Hour = secondValue / 3600,
                Day = secondValue / 86400,
                Week = secondValue / 604800,
                Month = secondValue / 2628000
            };
        }
        public TimeModel FromMinute(double minuteValue)
        {
            _calculationValidation.LessThanZero(minuteValue);

            return new TimeModel
            {
                Second = minuteValue * 60,
                Minute = minuteValue,
                Hour = minuteValue / 60,
                Day = minuteValue / 1440,
                Week = minuteValue / 10080,
                Month = minuteValue / 43800
            };
        }
        public TimeModel FromHour(double hourTime)
        {
            _calculationValidation.LessThanZero(hourTime);

            return new TimeModel
            {
                Second = hourTime * 3600,
                Minute = hourTime * 60,
                Hour = hourTime,
                Day = hourTime / 24,
                Week = hourTime / 168,
                Month = hourTime / 730
            };
        }
        public TimeModel FromDay(double dayValue)
        {
            _calculationValidation.LessThanZero(dayValue);

            return new TimeModel
            {
                Second = dayValue * 86400,
                Minute = dayValue * 1440,
                Hour = dayValue * 24,
                Day = dayValue,
                Week = dayValue / 7,
                Month = dayValue / 30.417
            };
        }
        public TimeModel FromWeek(double weekValue)
        {
            _calculationValidation.LessThanZero(weekValue);

            return new TimeModel
            {
                Second = weekValue * 604800,
                Minute = weekValue * 10080,
                Hour = weekValue * 168,
                Day = weekValue * 7,
                Week = weekValue,
                Month = weekValue / 4.345
            };
        }
        public TimeModel FromMonth(double monthValue)
        {
            _calculationValidation.LessThanZero(monthValue);

            return new TimeModel
            {
                Second = monthValue * 2628000,
                Minute = monthValue * 43800,
                Hour = monthValue * 730,
                Day = monthValue * 30.417,
                Week = monthValue * 4.345,
                Month = monthValue
            };
        }
    }
}
