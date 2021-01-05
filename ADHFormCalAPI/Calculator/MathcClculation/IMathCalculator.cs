using ADHFormCalAPI.Models;
using System.Collections.Generic;

namespace ADHFormCalAPI.Calculator.MathcClculation
{
    public interface IMathCalculator
    {
        CalculationResultModel Distance(List<int> pointOne, List<int> pointTwo);
        CalculationResultModel Mean(List<double> values);
        CalculationResultModel MidPoint(List<int> pointOne, List<int> pointTwo);
        CalculationResultModel Probability(int targetOutcomes, int totalOutcomes);
        CalculationResultModel Slope(List<int> pointOne, List<int> pointTwo);
        CalculationResultModel SlopeIntercept(List<int> point, int slope);
    }
}