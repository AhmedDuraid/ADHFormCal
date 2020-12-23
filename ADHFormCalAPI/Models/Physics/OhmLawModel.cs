namespace ADHFormCalAPI.Models.Physics
{
    public class OhmLawModel
    {
        double _voltage, _current, _resistance;

        public string OhmLawFormula = "V=IR";
        public double Voltage
        {
            get => _voltage;
            set => _voltage = value < 0 ? 0 : value;
        }
        public char VoltageSymbol => 'V';

        public double Current
        {
            get => _current;
            set => _current = value < 0 ? 0 : value;
        }
        public char CurrentSymbol => 'I';

        public double Resistance
        {
            get => _resistance;
            set => _resistance = value < 0 ? 0 : value;
        }
        public char ResistanceSymbol => 'R';
    }
}
