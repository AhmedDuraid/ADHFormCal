namespace ADHFormCalAPI.Models.Converters
{
    public class TimeModel
    {
        private double _second, _minute, _hour, _day, _week, _month;

        // time values can be less than 0 
        public double Second
        {
            get => _second;
            set => _second = value < 0 ? 0 : value;
        }
        public char SecondSymbol => 's';
        public double Minute
        {
            get => _minute;
            set => _minute = value < 0 ? 0 : value;
        }
        public char MinuteSymbol => 'm';

        public double Hour
        {
            get => _hour;
            set => _hour = value < 0 ? 0 : value;
        }
        public char HourSymbol => 'h';
        public double Day
        {
            get => _day;
            set => _day = value < 0 ? 0 : value;
        }

        public char DaySymbol => 'd';
        public double Week
        {
            get => _week;
            set => _week = value < 0 ? 0 : value;
        }
        public char WeekSymbol => 'w';
        public double Month
        {
            get => _month;
            set => _month = value < 0 ? 0 : value;
        }
        public char MonthSymbol => 'm';
    }
}
