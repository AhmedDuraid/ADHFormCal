using ADHFormCalAPI.Models;
using ADHFormCalAPI.Models.Physics;

namespace ADHFormCalAPI.Calculator.Physics
{
    public class PhysicsCalculator
    {
        CalculationResultModel calculationResult;
        public CalculationResultModel OhmCalculation(char request, double voltage, double current, double resistance)
        {
            // you need to check if user will give you two values that = to 0 

            OhmLawModel ohmLaw = new OhmLawModel();
            calculationResult = new CalculationResultModel
            {
                Formula = ohmLaw.OhmLawFormula
            };

            if (voltage < 0 || current < 0 || resistance < 0)
            {
                calculationResult.Error = true;
                calculationResult.Message = "voltage, current and, resistance can not be less than 0";

                return calculationResult;
            }

            // V
            if (request == ohmLaw.VoltageSymbol)
            {
                calculationResult.Value = current * resistance;
                calculationResult.WhatCalculate = "voltage";

                return calculationResult;
            }

            // I
            if (request == ohmLaw.VoltageSymbol)
            {
                calculationResult.Value = voltage / resistance;
                calculationResult.WhatCalculate = "current";

                return calculationResult;
            }

            // R
            if (request == ohmLaw.VoltageSymbol)
            {
                calculationResult.Value = voltage / current;
                calculationResult.WhatCalculate = "resistance";

                return calculationResult;
            }

            return null;
        }

        public CalculationResultModel HeatCalculation(char request, double energy, double mass, double heat, double aVATemperature)
        {
            SpecificHeatModel specificHeat = new SpecificHeatModel();

            calculationResult = new CalculationResultModel
            {
                Formula = specificHeat.EnergyFormula
            };

            if (mass < 0)
            {
                calculationResult.Error = true;
                calculationResult.Message = "Mass can't be less than 0";

                return calculationResult;
            }

            //Q
            if (request == specificHeat.EnergySymbol)
            {
                calculationResult.Value = mass * heat * aVATemperature;
                calculationResult.WhatCalculate = "Energy";
                calculationResult.Unit = specificHeat.EnergyUnit.ToString();

                return calculationResult;
            }

            // M
            if (request == specificHeat.MassSumbol)
            {
                calculationResult.Value = energy / (heat * aVATemperature);
                calculationResult.WhatCalculate = "Mass";
                calculationResult.Unit = specificHeat.MassUnit;

                return calculationResult;
            }

            // c
            if (request == specificHeat.HeatCapacitySymbol)
            {
                calculationResult.Value = energy / (mass * aVATemperature);
                calculationResult.WhatCalculate = "Specific Heat";
                calculationResult.Unit = specificHeat.HeatCapacityUnit.ToString();

                return calculationResult;
            }

            // T
            if (request == specificHeat.ChangeOfTemperatureSymbol)
            {
                calculationResult.Value = energy / (mass * heat);
                calculationResult.WhatCalculate = "AVG Temperature";
                calculationResult.Unit = specificHeat.TemperatureUnit.ToString();

                return calculationResult;
            }

            return null;
        }

        public CalculationResultModel ChangeInTemperatureCalclation(double initialTemp, double finalTemp)
        {
            calculationResult = new CalculationResultModel
            {
                Value = finalTemp - initialTemp,
                Formula = "Initial Temperature - Final Temperature",
                Unit = "T",
                WhatCalculate = "change In Temperature"
            };
            return calculationResult;
        }
    }
}
