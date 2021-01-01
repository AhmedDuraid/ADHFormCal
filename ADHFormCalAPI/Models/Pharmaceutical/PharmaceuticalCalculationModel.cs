namespace ADHFormCalAPI.Models.Pharmaceutical
{
    public class PharmaceuticalCalculationModel
    {
        public string WeightFormula => "Weight = Volume * Density";
        public char WeightUnit => 'g';

        public string VolumeFormula => "Volume = Weight / Density";
        public string VolumeUnit => "ml";

        public string DensityFormula => "Density = Weight / Volume";

        public string ValueInProofFormula => "Value in Proof = % Alcohol Strenght *1.753 - 100";
        public string ValueInProofUnit => "O.P";

        public string ChildDoseAgeBasedFormula => "Child Dose = Age(years)/Age+12 * Adult Dose";
        public string ChildDoseWeightBasedFormula => "Child Dose = Child serface area/1.73* adult dose";
        public string SerfaceAreaFormula => "BSA^2 =ht(cm)*wt(kg)/36000";
    }
}
