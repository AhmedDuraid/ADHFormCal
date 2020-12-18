namespace ADHFormCalAPI.Models.Converters
{
    public class TimeModel
    {
        private double _second, _minute, _hour, _day, _week, _month;
        public TimeModel(double value, char unit)
        {
            SetTime(value, unit);
        }
        public double Second
        {
            get => _second;
            set => _second = value < 0 ? 0 : value;
        }
        public double Minute
        {
            get => _minute;
            set => _minute = value < 0 ? 0 : value;
        }
        public double Hour
        {
            get => _hour;
            set => _hour = value < 0 ? 0 : value;
        }
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
                        Second = value;
                        Minute = value / 60;
                        Hour = value / 3600;
                        Day = value / 86400;
                        Week = value / 604800;
                        Month = value / 2628000;
                        break;
                    }
                case 'm':
                    {
                        Second = value * 60;
                        Minute = value;
                        Hour = value / 60;
                        Day = value / 1440;
                        Week = value / 10080;
                        Month = value / 43800;
                        break;
                    }
                case 'h':
                    {
                        Second = value * 3600;
                        Minute = value * 60;
                        Hour = value;
                        Day = value / 24;
                        Week = value / 168;
                        Month = value / 730;
                        break;
                    }
                case 'd':
                    {
                        Second = value * 86400;
                        Minute = value * 1440;
                        Hour = value * 24;
                        Day = value;
                        Week = value / 7;
                        Month = value / 30.417;
                        break;
                    }
                case 'w':
                    {
                        Second = value * 604800;
                        Minute = value * 10080;
                        Hour = value * 168;
                        Day = value * 7;
                        Week = value;
                        Month = value / 4.345;
                        break;
                    }
                case 'M':
                    {
                        Second = value * 2628000;
                        Minute = value * 43800;
                        Hour = value * 730;
                        Day = value * 30.417;
                        Week = value * 4.345;
                        Month = value;
                        break;
                    }

            }
        }
    }
}
