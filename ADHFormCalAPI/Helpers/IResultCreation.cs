using ADHFormCalAPI.Models;
using System.Collections.Generic;

namespace ADHFormCalAPI.Helpers
{
    public interface IResultCreation
    {
        CalculationResultModel SetResult(double value, string formula, string WhatCalculate, string unit = null, string message = null);
        CalculationResultModel SetResult(List<int> value, string formula, string WhatCalculate, string unit = null, string message = null);
    }
}