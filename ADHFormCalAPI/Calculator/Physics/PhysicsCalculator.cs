using ADHFormCalAPI.Models;
using ADHFormCalAPI.Models.Physics;

namespace ADHFormCalAPI.Calculator.Physics
{
    public class PhysicsCalculator
    {
        public CalculationResultModel OhmCalculation(char request, double voltage, double current, double resistance)
        {
            // you need to check if user will give you two values that = to 0 

            OhmLawModel ohmLaw = new OhmLawModel();

            if (voltage < 0 || current < 0 || resistance < 0)
            {
                return Error("voltage, current and, resistance can not be less than 0");
            }

            // V
            if (request == ohmLaw.VoltageSymbol)
            {
                double Voltage = current * resistance;

                return SetValues(Voltage, ohmLaw.OhmLawFormula, "voltage");
            }

            // I
            if (request == ohmLaw.CurrentSymbol)
            {
                double Current = voltage / resistance;

                return SetValues(Current, ohmLaw.OhmLawFormula, "current");
            }

            // R
            if (request == ohmLaw.ResistanceSymbol)
            {
                double Resistance = voltage / current;

                return SetValues(Resistance, ohmLaw.OhmLawFormula, "resistance");
            }

            return null;
        }
        public CalculationResultModel HeatCalculation(char request, double energy, double mass, double heat, double aVATemperature)
        {
            SpecificHeatModel specificHeat = new SpecificHeatModel();

            string Formula = specificHeat.EnergyFormula;

            if (mass < 0)
            {
                return Error("Mass can't be less than 0");
            }

            //Q
            if (request == specificHeat.EnergySymbol)
            {
                double Energy = mass * heat * aVATemperature;

                return SetValues(Energy, Formula, "Energy", specificHeat.EnergyUnit.ToString());
            }

            // M
            if (request == specificHeat.MassSumbol)
            {
                double Mass = energy / (heat * aVATemperature);

                return SetValues(Mass, Formula, "Mass", specificHeat.MassUnit);
            }

            // c
            if (request == specificHeat.HeatCapacitySymbol)
            {
                double HeatCapacity = energy / (mass * aVATemperature);

                return SetValues(HeatCapacity, Formula, "Specific Heat", specificHeat.HeatCapacityUnit);
            }

            // T
            if (request == specificHeat.ChangeOfTemperatureSymbol)
            {
                double ChangeOfTemperature = energy / (mass * heat);

                return SetValues(ChangeOfTemperature, Formula, "AVG Temperature", specificHeat.TemperatureUnit.ToString());
            }

            return null;
        }
        public CalculationResultModel ChangeInTemperatureCalclation(double initialTemperature, double finalTemperature)
        {
            double ChangeInTemperature = finalTemperature - initialTemperature;

            return SetValues(ChangeInTemperature, "Initial Temperature - Final Temperature", "change In Temperature", "T");
        }
        public CalculationResultModel AverageSpeedCalclation(char request, double aVGSpeed, double aVGdistance, double aVGtime)
        {
            AverageSpeedModel speedModel = new AverageSpeedModel();

            if (aVGSpeed < 0 || aVGdistance < 0 || aVGtime < 0)
            {
                return Error("AVG Speed, AVG Distance, or AVGTime can't be less than 0");
            }

            // S
            if (request == speedModel.AVGSpeedSymbol)
            {
                double AverageSpeed = aVGdistance / aVGtime;

                return SetValues(AverageSpeed, speedModel.AVGSpeedFormula, "Average Speed", speedModel.AVGSpeedUnit);
            }

            // D
            if (request == speedModel.AVGDistanceSymbol)
            {
                double Distance = aVGSpeed * aVGtime;

                return SetValues(Distance, speedModel.AVGDistanceFormula, "Average Distance", speedModel.AVGDistanceUnit);
            }

            // T
            if (request == speedModel.AVGTimeSymbol)
            {
                double Time = aVGdistance / aVGSpeed;

                return SetValues(Time, speedModel.AVGTimeFormula, "Average Time", speedModel.AVGTimeUnit.ToString());
            }

            return Error($"request need to be {speedModel.AVGSpeedSymbol}, {speedModel.AVGDistanceSymbol}, or {speedModel.AVGTimeSymbol}");
        }
        public CalculationResultModel SpeedCalclation(char request, double speed, double distance, double time)
        {
            SpeedDistanceTimeModel speedModel = new SpeedDistanceTimeModel();

            if (speed < 0 || distance < 0 || time < 0)
            {
                return Error("Speed, Distance, or Time can't be less than 0 ");
            }

            // S
            if (request == speedModel.SpeedSymbol)
            {
                double Speed = distance / time;

                return SetValues(Speed, speedModel.SpeedFormula, "Speed", speedModel.SpeedUnit);
            }

            // D
            if (request == speedModel.DistanceSymbol)
            {
                double Distance = speed * time;

                return SetValues(Distance, speedModel.DistanceFormula, "Distance", speedModel.DistanceUnit.ToString());
            }

            // T
            if (request == speedModel.TimeSymbol)
            {
                double Time = distance / speed;

                return SetValues(Time, speedModel.TimeFormula, "Time", speedModel.TimeUnit.ToString());
            }

            return Error($"request need to be {speedModel.SpeedSymbol}, {speedModel.DistanceSymbol}, or {speedModel.TimeSymbol}");
        }
        public CalculationResultModel DensityCalclation(char request, double density, double mass, double volume)
        {
            DensityModel densityModel = new DensityModel();
            string ErrorMessage;

            if (density < 0 || mass < 0 || volume < 0)
            {
                ErrorMessage = "Density, Mass, or Volume can't be less than 0";
                return Error(ErrorMessage);
            }

            // p
            if (request == densityModel.DensitySymbol)
            {
                double Dencity = mass / volume;

                return SetValues(Dencity, densityModel.DensityFormula, "Dencity", densityModel.DensityUnit);
            }

            // m
            if (request == densityModel.MassSymbol)
            {
                double Mass = density * volume;

                return SetValues(Mass, densityModel.MassFormula, "Mass", densityModel.MassUnit);
            }

            // T
            if (request == densityModel.VolumeSymbol)
            {
                double Volume = mass / density;

                return SetValues(Volume, densityModel.VolumeFormula, "Volume", densityModel.VolumeUnit);
            }

            ErrorMessage = $"request need to be {densityModel.DensitySymbol}, {densityModel.MassSymbol}, or {densityModel.VolumeSymbol}";

            return Error(ErrorMessage);
        }

        private CalculationResultModel SetValues(double value, string formula, string WhatCalculate, string unit = null, string message = null)
        {
            CalculationResultModel calculationResult = new CalculationResultModel
            {

                Formula = formula,
                Value = value,
                Unit = unit,
                WhatCalculate = WhatCalculate,
                Message = message
            };

            return calculationResult;
        }
        private CalculationResultModel Error(string message)
        {
            CalculationResultModel calculationResult = new CalculationResultModel
            {
                Error = true,
                Message = message
            };

            return calculationResult;
        }
    }
}
