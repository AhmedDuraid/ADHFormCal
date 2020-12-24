namespace ADHFormCalAPI.Models.Physics
{
    public class AverageSpeedModel
    {
        public string AVGSpeedFormula => "Average Speed(S)=Distance(D)/Time(T)";
        public char AVGSpeedSymbol => 'S';
        public string AVGSpeedUnit => "km/h";

        public string AVGDistanceFormula => "Distance(D)=Average Speed(S)*Time(T)";
        public char AVGDistanceSymbol => 'D';
        public string AVGDistanceUnit => "km";


        public char AVGTimeSymbol => 'T';
        public char AVGTimeUnit => 'h';
        public string AVGTimeFormula => "Time(T)=Distance(D)/Average Speed(S)";
    }
}
