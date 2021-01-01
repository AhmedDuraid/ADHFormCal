namespace ADHFormCalAPI.Models.MathFormulas
{
    public class MathFormulaModel
    {
        public string Mean => "Average=Sum of values / Number of values";
        public string Probability => "Probability=Target outcomes / Total outcomes";
        public string Quadratic => " x = −b ± √b²-4ac/2a";
        public string Distance => "d=√(x₁ – x₂)² + (y₁ – y₂)²";
        public string Slope => "Slope = y₂ – y₁ /  x₂ – x₁";
        public string SlopeIntercept => "y = Slope * x + y";
        public string Midpoint => "(x₁+x₂) / 2, (y₁+y₂) / 2";
    }
}
