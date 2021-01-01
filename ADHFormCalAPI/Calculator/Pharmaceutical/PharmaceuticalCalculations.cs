using ADHFormCalAPI.Models;
using ADHFormCalAPI.Models.Pharmaceutical;
using System;

namespace ADHFormCalAPI.Calculator.Pharmaceutical
{
    public class PharmaceuticalCalculations
    {
        private readonly PharmaceuticalCalculationModel calculationModel = new PharmaceuticalCalculationModel();

        CalculationResultModel ResultModel;
        public CalculationResultModel Weight(double vloume, double density)
        {
            double Weight = vloume * density;

            ResultModel = new CalculationResultModel
            {
                Value = Weight,
                Formula = calculationModel.WeightFormula,
                Unit = calculationModel.WeightUnit.ToString(),
                WhatCalculate = "Weight",
                ListOfValues = null
            };
            return ResultModel;
        }
        public CalculationResultModel Volume(double weight, double density)
        {
            double Vloume = weight / density;

            ResultModel = new CalculationResultModel
            {
                Value = Vloume,
                Formula = calculationModel.VolumeFormula,
                Unit = calculationModel.VolumeUnit,
                WhatCalculate = "Volume",
                ListOfValues = null
            };

            return ResultModel;
        }
        public CalculationResultModel Density(double weight, double volume)
        {
            double Density = weight / volume;
            ResultModel = new CalculationResultModel
            {
                Value = Density,
                Formula = calculationModel.DensityFormula,
                WhatCalculate = "Density",
                ListOfValues = null
            };

            return ResultModel;
        }
        public CalculationResultModel ValueInProof(double alcoholStrengt)
        {
            double Proof = (alcoholStrengt * 1.753) - 100;
            ResultModel = new CalculationResultModel
            {
                Value = Proof,
                Unit = calculationModel.ValueInProofUnit,
                WhatCalculate = "Value In Proof",
                ListOfValues = null
            };
            return ResultModel;
        }
        public CalculationResultModel AgebasedChildDose(int childAge, double adultDose)
        {
            double ChildDose = (childAge / (childAge + 12)) * adultDose;
            ResultModel = new CalculationResultModel
            {
                Value = ChildDose,
                WhatCalculate = "Child Dose, Age Based",
                Formula = calculationModel.ChildDoseAgeBasedFormula,
                ListOfValues = null
            };
            return ResultModel;
        }
        public CalculationResultModel WeightBasedChildDose(double childBSA, double adultDose)
        {
            double ChildDose = (childBSA / 1.73) * adultDose;

            ResultModel = new CalculationResultModel
            {
                Value = ChildDose,
                Formula = calculationModel.ChildDoseWeightBasedFormula,
                WhatCalculate = "Child Dose, Weight Based"
            };

            return ResultModel;
        }
        public CalculationResultModel BSA(double height, double weight)
        {
            double BSA = Math.Sqrt((height * weight) / 3600);

            ResultModel = new CalculationResultModel
            {
                Value = BSA,
                Formula = calculationModel.SerfaceAreaFormula,
                WhatCalculate = "Body Serface Area"
            };
            return ResultModel;
        }
    }
}
