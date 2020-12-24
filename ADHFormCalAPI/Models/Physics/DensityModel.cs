namespace ADHFormCalAPI.Models.Physics
{
    public class DensityModel
    {
        public string DensityFormula => "Density(p) = Mass(m)/Volume(V)";
        public char DensitySymbol => 'p';
        public string DensityUnit => "kg/L";

        public string MassFormula => " Mass(m)= Density(p)*Volume(V)";
        public char MassSymbol => 'm';
        public string MassUnit => "kg";

        public string VolumeFormula => "Volume(V)= Mass(m)/Density(p)";
        public char VolumeSymbol => 'V';
        public string VolumeUnit => "L";
    }
}
