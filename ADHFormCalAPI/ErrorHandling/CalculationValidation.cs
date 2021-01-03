namespace ADHFormCalAPI.ErrorHandling
{
    public class CalculationValidation : ICalculationValidation
    {
        public void LessThanZero(double value)
        {
            if (value < 0)
            {
                throw new System.ArgumentException("Value can be less than 0");
            }
        }
    }
}
