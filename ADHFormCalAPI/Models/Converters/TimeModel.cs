namespace ADHFormCalAPI.Models.Converters
{
    public class TimeModel
    {
        private double _second, _minute, _hour, _day, _week, _month;

        // time values can be less than 0 
        public double Second { get; set; }
        public char SecondSymbol => 's';
        public double Minute { get; set; }
        public char MinuteSymbol => 'm';
        public double Hour { get; set; }
        public char HourSymbol => 'h';
        public double Day { get; set; }
        public char DaySymbol => 'd';
        public double Week { get; set; }
        public char WeekSymbol => 'w';
        public double Month { get; set; }
        public char MonthSymbol => 'm';
    }
}
