using ADHFormCalAPI.ErrorHandling;
using ADHFormCalAPI.Helpers;
using ADHFormCalAPI.Models;
using ADHFormCalAPI.Models.Physics;
using System.Collections.Generic;

namespace ADHFormCalAPI.Calculator.Physics
{
    public class PhysicsCalculator : IPhysicsCalculator
    {
        private readonly ICalculationValidation _calculationValidation;
        private readonly IResultCreation _resultCreation;
        private readonly OhmLawModel ohmLaw;
        private readonly SpecificHeatModel specificHeat;
        private readonly AverageSpeedModel speedModel;
        private readonly DensityModel densityModel;

        public PhysicsCalculator(ICalculationValidation calculationValidation, IResultCreation resultCreation)
        {
            _calculationValidation = calculationValidation;
            _resultCreation = resultCreation;
        }

        public CalculationResultModel Ohm_VoltageCalculation(double current, double resistance)
        {
            _calculationValidation.LessThanZero(current, resistance, "Current", "Resistance");

            double Voltage = current * resistance;

            return _resultCreation.SetResult(Voltage, ohmLaw.OhmLawFormula, "Voltage");
        }
        public CalculationResultModel Ohm_Current(double voltage, double resistance)
        {
            LessThanZeroAndDivideChecks(voltage, resistance, "Voltage", "Resistance", resistance, "Resistance can't be 0");

            double Current = voltage / resistance;

            return _resultCreation.SetResult(Current, ohmLaw.OhmLawFormula, "current");
        }
        public CalculationResultModel Ohm_Resistance(double voltage, double current)
        {
            LessThanZeroAndDivideChecks(voltage, current, "Voltage", "Current", current, "Current can't be 0");

            double Resistance = voltage / current;

            return _resultCreation.SetResult(Resistance, ohmLaw.OhmLawFormula, "resistance");
        }
        public CalculationResultModel Heat_Energy(double mass, double heat, double aVATemperature)
        {
            _calculationValidation.LessThanZero(
                new List<double> {
                    mass, heat, aVATemperature
                }, new List<string>
                {
                    "Mass", "Heat", "AVATemperature"
                });
            double Energy = mass * heat * aVATemperature;

            return _resultCreation.SetResult(Energy, specificHeat.EnergyFormula, "Energy", specificHeat.EnergyUnit.ToString());
        }
        public CalculationResultModel Heat_Mass(double energy, double heat, double aVATemperature)
        {
            _calculationValidation.LessThanZero(
                new List<double> {
                    energy, heat, aVATemperature
                },
                new List<string>
                {
                    "Energy", "Heat", "AVATemperature"
                });
            _calculationValidation.CanNotBeZero(heat, aVATemperature, "Heat", "AVG Temperature");

            double Mass = energy / (heat * aVATemperature);

            return _resultCreation.SetResult(Mass, specificHeat.EnergyFormula, "Mass", specificHeat.MassUnit);
        }
        public CalculationResultModel Heat_HeatCapacity(double energy, double mass, double aVATemperature)
        {
            _calculationValidation.LessThanZero(
                new List<double> {
                    energy, mass, aVATemperature
                },
                new List<string>
                {
                    "Energy", "Mass", "AVATemperature"
                });
            _calculationValidation.CanNotBeZero(mass, aVATemperature, "Heat", "AVG Temperature");

            double HeatCapacity = energy / (mass * aVATemperature);

            return _resultCreation.SetResult(HeatCapacity, specificHeat.EnergyFormula, "Specific Heat", specificHeat.HeatCapacityUnit);
        }
        public CalculationResultModel Heat_ChangeOfTemperature(double energy, double mass, double heat)
        {
            _calculationValidation.LessThanZero(
                new List<double> {
                    energy, mass, heat
                },
                new List<string>
                {
                    "Energy", "Mass", "Heat"
                });
            _calculationValidation.CanNotBeZero(mass, heat, "Mass", "Heat");

            double ChangeOfTemperature = energy / (mass * heat);

            return _resultCreation.SetResult(ChangeOfTemperature, specificHeat.EnergyFormula, "AVG Temperature", specificHeat.TemperatureUnit.ToString());
        }
        public CalculationResultModel ChangeInTemperature(double initialTemperature, double finalTemperature)
        {
            double ChangeInTemperature = finalTemperature - initialTemperature;

            return _resultCreation.SetResult(ChangeInTemperature, "Initial Temperature - Final Temperature", "change In Temperature", "T");
        }
        public CalculationResultModel AverageSpeed_Speed(double aVGdistance, double aVGtime)
        {
            LessThanZeroAndDivideChecks(aVGdistance, aVGtime, "aVGdistance", "aVGtime", aVGtime, "Time Can't be 0");

            double AverageSpeed = aVGdistance / aVGtime;

            return _resultCreation.SetResult(AverageSpeed, speedModel.AVGSpeedFormula, "Average Speed", speedModel.AVGSpeedUnit);
        }
        public CalculationResultModel AverageSpeed_Distance(double aVGSpeed, double aVGtime)
        {
            _calculationValidation.LessThanZero(aVGtime, aVGSpeed, "AVG Time", "AVG Speed");

            double Distance = aVGSpeed * aVGtime;

            return _resultCreation.SetResult(Distance, speedModel.AVGDistanceFormula, "Average Distance", speedModel.AVGDistanceUnit);
        }
        public CalculationResultModel AverageSpeed_Time(double aVGSpeed, double aVGdistance)
        {
            LessThanZeroAndDivideChecks(aVGdistance, aVGSpeed, "AVG Distance", "AVG Speed", aVGSpeed, "Speed Can't be 0");

            double Time = aVGdistance / aVGSpeed;

            return _resultCreation.SetResult(Time, speedModel.AVGTimeFormula, "Average Time", speedModel.AVGTimeUnit.ToString());
        }
        public CalculationResultModel Density(double mass, double volume)
        {
            LessThanZeroAndDivideChecks(mass, volume, "Mass", "Volume", volume, "Volume can Not Be Zero");

            double Dencity = mass / volume;

            return _resultCreation.SetResult(Dencity, densityModel.DensityFormula, "Dencity", densityModel.DensityUnit);
        }
        public CalculationResultModel Density_Mass(double density, double volume)
        {
            _calculationValidation.LessThanZero(density, volume, "Density", "Volume");

            double Mass = density * volume;

            return _resultCreation.SetResult(Mass, densityModel.MassFormula, "Mass", densityModel.MassUnit);
        }
        public CalculationResultModel Density_Volume(double density, double mass)
        {
            LessThanZeroAndDivideChecks(density, mass, "Density", "Mass", density, "Density can't be zero");
            double Volume = mass / density;

            return _resultCreation.SetResult(Volume, densityModel.VolumeFormula, "Volume", densityModel.VolumeUnit);
        }

        private void LessThanZeroAndDivideChecks(double valueOne, double valueTwo, string valueOneName, string valueTwoName,
            double divideValue, string divideMessage)
        {
            _calculationValidation.DivideByZero(divideValue, divideMessage);
            _calculationValidation.LessThanZero(valueOne, valueTwo, valueOneName, valueTwoName);
        }
    }
}
