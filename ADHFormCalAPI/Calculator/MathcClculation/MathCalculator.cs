using ADHFormCalAPI.Models;
using ADHFormCalAPI.Models.Math;
using System;
using System.Collections.Generic;

namespace ADHFormCalAPI.Calculator.MathcClculation
{
    public class MathCalculator
    {
        private readonly MathFormulaModel MathFormula = new MathFormulaModel();
        public CalculationResultModel Mean(List<double> values)
        {
            int totalNumbers = values.Count;
            double sumOfValues = 0;
            double average;

            foreach (var item in values)
            {
                sumOfValues += item;
            }

            average = sumOfValues / totalNumbers;

            return SetResult(average, MathFormula.Mean, "Mean");
        }
        public CalculationResultModel Probability(int targetOutcomes, int totalOutcomes)
        {
            double probability = targetOutcomes / totalOutcomes;
            probability *= 100;

            return SetResult(probability, MathFormula.Probability, "Probability", "%");
        }
        public CalculationResultModel Distance(List<int> pointOne, List<int> pointTwo)
        {
            // note >>> check if the list has more than 2 values 

            //[x1,y1], [x2,y2]
            int xValues = pointTwo[0] - pointOne[0];
            int yValues = pointTwo[1] - pointOne[1];
            double d = Math.Sqrt(Math.Pow(xValues, 2) + Math.Pow(yValues, 2));

            return SetResult(d, MathFormula.Distance, "Distance");
        }
        public CalculationResultModel Slope(List<int> pointOne, List<int> pointTwo)
        {
            // note >>> check if the list has more than 2 values 

            //[x1,y1], [x2,y2]
            int xValue = pointTwo[0] - pointOne[0];
            int YValue = pointTwo[1] - pointOne[1];
            int slope = YValue / xValue;

            return SetResult(slope, MathFormula.Slope, "Slope");
        }

        private CalculationResultModel SetResult(double value, string formula, string WhatCalculate, string unit = null, string message = null)
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
