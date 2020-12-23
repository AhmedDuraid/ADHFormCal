using ADHFormCalAPI.Models;
using ADHFormCalAPI.Models.Physics;

namespace ADHFormCalAPI.Calculator.Physics
{
    public class PhysicsCalculator
    {

        public CalculationResultModel OhmCalculation(char request, double voltage, double current, double resistance)
        {
            // you need to check if give you two values that = to 0 
            CalculationResultModel calculationResult = new CalculationResultModel
            {
                Formula = new OhmLawModel().OhmLawFormula
            };

            switch (request)
            {
                case 'V':
                    {
                        calculationResult.Value = current * resistance;

                        return (calculationResult);
                    }
                case 'I':
                    {
                        calculationResult.Value = voltage / resistance;

                        return (calculationResult);

                    }
                case 'R':
                    {
                        calculationResult.Value = voltage / current;

                        return (calculationResult);
                    }
            }

            return null;
        }
    }
}
