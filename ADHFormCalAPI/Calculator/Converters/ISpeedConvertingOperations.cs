using ADHFormCalAPI.Models.Converters;

namespace ADHFormCalAPI.Calculator.Converters
{
    public interface ISpeedConvertingOperations
    {
        SpeedModel FromKilometersPerHour(double KMvalue);
        SpeedModel FromKnots(double KnotsValue);
        SpeedModel FromMile(double mileValue);
    }
}