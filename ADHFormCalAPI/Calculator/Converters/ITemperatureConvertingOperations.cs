using ADHFormCalAPI.Models.Converters;

namespace ADHFormCalAPI.Calculator.Converters
{
    public interface ITemperatureConvertingOperations
    {
        TemperatureModel FromC(double CValue);
        TemperatureModel FromF(double FValue);
        TemperatureModel FromK(double KValue);
    }
}