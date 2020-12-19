namespace ADHFormCalAPI.Models.Converters
{
    public class TimeModel
    {
        private double _second, _minute, _hour, _day, _week, _month;
        public TimeModel(double value, char unit)
        {
            SetTime(value, unit);
        }

        // time values can be less than 0 
        public double Second
        {
            get => _second;
            set => _second = value < 0 ? 0 : value;
        }
        public string SecondUnit => "s";
        public double Minute
        {
            get => _minute;
            set => _minute = value < 0 ? 0 : value;
        }
        public string MinuteUnit => "m";

        public double Hour
        {
            get => _hour;
            set => _hour = value < 0 ? 0 : value;
        }
        public string HourUnit => "h";
        public double Day
        {
            get => _day;
            set => _day = value < 0 ? 0 : value;
        }
        public double Week
        {
            get => _week;
            set => _week = value < 0 ? 0 : value;
        }
        public double Month
        {
            get => _month;
            set => _month = value < 0 ? 0 : value;
        }

        private void SetTime(double value, char unit)
        {
            switch (unit)
            {
                case 's':
                    {
                        SetValues(value, value / 60, value / 3600, value / 86400,
                        value / 604800, value / 2628000);
                        break;
                    }
                case 'm':
                    {

                        SetValues(value * 60, value, value / 60, value / 1440,
                        value / 10080, value / 43800);
                        break;
                    }
                case 'h':
                    {
                        SetValues(value * 3600, value * 60, value, value / 24,
                        value / 168, value / 730);
                        break;
                    }
                case 'd':
                    {
                        SetValues(value * 86400, value * 1440, value * 24, value,
                        value / 7, value / 30.417);
                        break;
                    }
                case 'w':
                    {
                        SetValues(value * 604800, value * 10080, value * 168, value * 7,
                        value, value / 4.345);
                        break;
                    }
                case 'M':
                    {
                        SetValues(value * 2628000, value * 43800, value * 730, value * 30.417,
                        value * 4.345, value);
                        break;
                    }
            }
        }

        private void SetValues(double second, double minute, double hour, double day, double week, double month)
        {
            Second = second;
            Minute = minute;
            Hour = hour;
            Day = day;
            Week = week;
            Month = month;
        }
    }
}
