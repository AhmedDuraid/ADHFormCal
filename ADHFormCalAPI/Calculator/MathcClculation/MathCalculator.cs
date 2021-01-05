using ADHFormCalAPI.ErrorHandling;
using ADHFormCalAPI.Helpers;
using ADHFormCalAPI.Models;
using ADHFormCalAPI.Models.MathFormulas;
using System;
using System.Collections.Generic;

namespace ADHFormCalAPI.Calculator.MathcClculation
{
    public class MathCalculator : IMathCalculator
    {
        private readonly MathFormulaModel MathFormula;
        private readonly ICalculationValidation _calculationValidation;
        private readonly IResultCreation _resultCreation;

        public MathCalculator(ICalculationValidation calculationValidation, IResultCreation resultCreation)
        {
            _calculationValidation = calculationValidation;
            _resultCreation = resultCreation;
            MathFormula = new MathFormulaModel();
        }

        public CalculationResultModel Mean(List<double> values)
        {
            int totalNumbers = values.Count;
            double sumOfValues = 0;
            double average;

            _calculationValidation.ListHasNoValues(values);

            foreach (var item in values)
            {
                sumOfValues += item;
            }

            average = sumOfValues / totalNumbers;

            return _resultCreation.SetResult(average, MathFormula.Mean, "Mean");
        }
        public CalculationResultModel Probability(int targetOutcomes, int totalOutcomes)
        {
            _calculationValidation.DivideByZero(totalOutcomes, $"Total Out Comes Can not be 0");

            double probability = targetOutcomes / totalOutcomes;
            probability *= 100;

            return _resultCreation.SetResult(probability, MathFormula.Probability, "Probability", "%");
        }
        public CalculationResultModel Distance(List<int> pointOne, List<int> pointTwo)
        {
            TwoPointsChecks(pointOne, pointTwo);

            //[x1,y1], [x2,y2]
            int xValues = pointTwo[0] - pointOne[0];
            int yValues = pointTwo[1] - pointOne[1];
            double distance = Math.Sqrt(Math.Pow(xValues, 2) + Math.Pow(yValues, 2));

            return _resultCreation.SetResult(distance, MathFormula.Distance, "Distance");
        }
        public CalculationResultModel Slope(List<int> pointOne, List<int> pointTwo)
        {

            TwoPointsChecks(pointOne, pointTwo);

            //[x1,y1], [x2,y2]
            int xValue = pointTwo[0] - pointOne[0];
            int YValue = pointTwo[1] - pointOne[1];

            _calculationValidation.DivideByZero(xValue, "x2 - x1 = 0");

            int slope = YValue / xValue;

            return _resultCreation.SetResult(slope, MathFormula.Slope, "Slope");
        }
        public CalculationResultModel SlopeIntercept(List<int> point, int slope)
        {
            // y= slope*x+y
            _calculationValidation.ListHasNoValues(point);
            _calculationValidation.ListLimit(point, 2);

            int x = point[0];
            int y = point[1];
            int Slope = (slope * x) + y;

            return _resultCreation.SetResult(Slope, MathFormula.SlopeIntercept, "Slope Intercept");
        }
        public CalculationResultModel MidPoint(List<int> pointOne, List<int> pointTwo)
        {
            // (x₁+x₂) / 2, (y₁+y₂) / 2
            TwoPointsChecks(pointOne, pointTwo);

            int x1 = pointOne[0];
            int x2 = pointTwo[0];
            int y1 = pointOne[1];
            int y2 = pointTwo[1];
            List<int> MidPoint = new List<int>
            {
                (x1+x2)/2,
                (y1+y2)/2
            };

            return _resultCreation.SetResult(MidPoint, MathFormula.Midpoint, "Mid point");
        }
        private void TwoPointsChecks(List<int> pointOne, List<int> pointTwo)
        {
            _calculationValidation.ListHasNoValues(pointOne);
            _calculationValidation.ListHasNoValues(pointTwo);
            _calculationValidation.ListLimit(pointOne, 2);
            _calculationValidation.ListLimit(pointTwo, 2);
        }
    }
}
