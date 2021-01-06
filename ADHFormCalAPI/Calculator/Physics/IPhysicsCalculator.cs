using ADHFormCalAPI.Models;

namespace ADHFormCalAPI.Calculator.Physics
{
    public interface IPhysicsCalculator
    {
        CalculationResultModel AverageSpeed_Distance(double aVGSpeed, double aVGtime);
        CalculationResultModel AverageSpeed_Speed(double aVGdistance, double aVGtime);
        CalculationResultModel AverageSpeed_Time(double aVGSpeed, double aVGdistance);
        CalculationResultModel ChangeInTemperature(double initialTemperature, double finalTemperature);
        CalculationResultModel Density(double mass, double volume);
        CalculationResultModel Density_Mass(double density, double volume);
        CalculationResultModel Density_Volume(double density, double mass);
        CalculationResultModel Heat_ChangeOfTemperature(double energy, double mass, double heat);
        CalculationResultModel Heat_Energy(double mass, double heat, double aVATemperature);
        CalculationResultModel Heat_HeatCapacity(double energy, double mass, double aVATemperature);
        CalculationResultModel Heat_Mass(double energy, double heat, double aVATemperature);
        CalculationResultModel Ohm_Current(double voltage, double resistance);
        CalculationResultModel Ohm_Resistance(double voltage, double current);
        CalculationResultModel Ohm_VoltageCalculation(double current, double resistance);
    }
}