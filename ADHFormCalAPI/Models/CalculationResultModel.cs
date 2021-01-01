using System.Collections.Generic;

namespace ADHFormCalAPI.Models
{
    public class CalculationResultModel
    {
        private bool _error = false;

        public double Value { get; set; }
        public List<int> ListOfValues { get; set; }
        public string Formula { get; set; }
        public string Unit { get; set; }
        public string WhatCalculate { get; set; }
        public string Message { get; set; }
        public bool Error
        {
            get => _error;
            set => _error = value;
        }
    }
}
