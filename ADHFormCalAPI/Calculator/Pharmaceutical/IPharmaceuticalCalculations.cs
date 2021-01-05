using ADHFormCalAPI.Models;

namespace ADHFormCalAPI.Calculator.Pharmaceutical
{
    public interface IPharmaceuticalCalculations
    {
        CalculationResultModel AgebasedChildDose(int childAge, double adultDose);
        CalculationResultModel BSA(double height, double weight);
        CalculationResultModel Density(double weight, double volume);
        CalculationResultModel ValueInProof(double alcoholStrengt);
        CalculationResultModel Volume(double weight, double density);
        CalculationResultModel Weight(double vloume, double density);
        CalculationResultModel WeightBasedChildDose(double childBSA, double adultDose);
    }
}