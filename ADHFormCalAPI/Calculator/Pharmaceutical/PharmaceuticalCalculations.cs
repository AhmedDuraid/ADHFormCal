using ADHFormCalAPI.ErrorHandling;
using ADHFormCalAPI.Helpers;
using ADHFormCalAPI.Models;
using ADHFormCalAPI.Models.Pharmaceutical;
using System;

namespace ADHFormCalAPI.Calculator.Pharmaceutical
{
    public class PharmaceuticalCalculations : IPharmaceuticalCalculations
    {
        private readonly PharmaceuticalCalculationModel calculationModel;
        private readonly ICalculationValidation _calculationValidation;
        private readonly IResultCreation _resultCreation;

        public PharmaceuticalCalculations(ICalculationValidation calculationValidation, IResultCreation resultCreation)
        {
            _calculationValidation = calculationValidation;
            _resultCreation = resultCreation;
            calculationModel = new PharmaceuticalCalculationModel();
        }

        public CalculationResultModel Weight(double vloume, double density)
        {
            _calculationValidation.LessThanZero(vloume, density, "Volume ", "Density");

            double Weight = vloume * density;

            return _resultCreation.SetResult(Weight, calculationModel.WeightFormula, "Weight", calculationModel.WeightUnit.ToString());
        }
        public CalculationResultModel Volume(double weight, double density)
        {
            _calculationValidation.LessThanZero(weight, density, "Weight ", "Density");
            _calculationValidation.DivideByZero(density, "Density can not be 0");

            double Vloume = weight / density;

            return _resultCreation.SetResult(Vloume, calculationModel.VolumeFormula, "Volume", calculationModel.VolumeUnit);
        }
        public CalculationResultModel Density(double weight, double volume)
        {
            _calculationValidation.LessThanZero(weight, volume, "Weight ", "volume");
            _calculationValidation.DivideByZero(volume, "Volume can not be 0");

            double Density = weight / volume;

            return _resultCreation.SetResult(Density, calculationModel.DensityFormula, "Density");
        }
        public CalculationResultModel ValueInProof(double alcoholStrengt)
        {
            _calculationValidation.CanNotBeZero(alcoholStrengt, "Alcohol Strengt");

            double Proof = (alcoholStrengt * 1.753) - 100;

            return _resultCreation.SetResult(Proof, calculationModel.ValueInProofUnit, "Value In Proof");
        }
        public CalculationResultModel AgebasedChildDose(int childAge, double adultDose)
        {
            _calculationValidation.LessThanZero(childAge, adultDose, "Child Age", "Adult Dose");
            _calculationValidation.CanNotBeZero(adultDose, "Adult Dose");

            double ChildDose = (childAge / (childAge + 12)) * adultDose;

            return _resultCreation.SetResult(ChildDose, calculationModel.ChildDoseAgeBasedFormula, "Child Dose, Age Based");
        }
        public CalculationResultModel WeightBasedChildDose(double childBSA, double adultDose)
        {
            _calculationValidation.LessThanZero(childBSA, adultDose, "Child BSA", "Adult Dose");
            _calculationValidation.CanNotBeZero(adultDose, "Adult Dose");

            double ChildDose = (childBSA / 1.73) * adultDose;

            return _resultCreation.SetResult(ChildDose, calculationModel.ChildDoseWeightBasedFormula, "Child Dose, Weight Based");
        }
        public CalculationResultModel BSA(double height, double weight)
        {
            _calculationValidation.LessThanZero(height, weight, "Height", "Weight");
            _calculationValidation.CanNotBeZero(height, weight, "Height", "Weight");

            double BSA = Math.Sqrt((height * weight) / 3600);

            return _resultCreation.SetResult(BSA, calculationModel.SerfaceAreaFormula, "Body Serface Area (BSA)");
        }
    }
}
