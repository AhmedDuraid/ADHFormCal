namespace ADHFormCalAPI.Models.Physics
{
    public class SpecificHeatModel
    {
        public string EnergyFormula = "Q=mCT";
        public char EnergySymbol => 'Q';
        public char EnergyUnit => 'J';
        public char MassSumbol => 'm';
        public string MassUnit => "kg";
        public char HeatCapacitySymbol => 'c';
        public string HeatCapacityUnit => "J/(kg.k)";
        public char ChangeOfTemperatureSymbol => 'T';
        public char TemperatureUnit => 'C';

    }
}
