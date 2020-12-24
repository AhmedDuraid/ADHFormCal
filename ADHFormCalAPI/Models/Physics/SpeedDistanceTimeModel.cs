namespace ADHFormCalAPI.Models.Physics
{
    public class SpeedDistanceTimeModel
    {
        public string SpeedFormula => "Speed=Distance/Time";
        public char SpeedSymbol => 'S';
        public string SpeedUnit => "m/s";

        public string DistanceFormula => "Distance=Speed*Time";
        public char DistanceSymbol => 'D';
        public char DistanceUnit => 'm';

        public string TimeFormula => "Time= Distance/Speed";
        public char TimeSymbol => 'T';
        public char TimeUnit => 'm';
    }
}
