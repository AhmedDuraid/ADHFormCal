using ADHFormCalAPI.Models;
using System.Collections.Generic;

namespace ADHFormCalAPI.Helpers
{
    public class ResultCreation : IResultCreation
    {
        public CalculationResultModel SetResult(double value, string formula, string WhatCalculate, string unit = null, string message = null)
        {
            CalculationResultModel calculationResult = new()
            {
                Formula = formula,
                Value = value,
                Unit = unit,
                WhatCalculate = WhatCalculate,
                Message = message
            };

            return calculationResult;
        }
        public CalculationResultModel SetResult(List<int> value, string formula, string WhatCalculate, string unit = null, string message = null)
        {
            CalculationResultModel calculationResult = new()
            {
                Formula = formula,
                ListOfValues = value,
                Unit = unit,
                WhatCalculate = WhatCalculate,
                Message = message
            };

            return calculationResult;
        }
    }
}
