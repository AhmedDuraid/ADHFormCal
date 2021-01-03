using ADHFormCalAPI.Models.Converters;

namespace ADHFormCalAPI.Calculator.Converters
{
    public interface IPressureConvertingOperations
    {
        PressureModel FromBar(double BarValue);
        PressureModel FromPascals(double PascalsValue);
        PressureModel FromTorr(double TorrValue);
    }
}