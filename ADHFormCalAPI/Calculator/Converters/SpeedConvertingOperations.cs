using ADHFormCalAPI.ErrorHandling;
using ADHFormCalAPI.Models.Converters;

namespace ADHFormCalAPI.Calculator.Converters
{
    public class SpeedConvertingOperations : ISpeedConvertingOperations
    {

        private readonly ICalculationValidation _calculationValidation;

        public SpeedConvertingOperations(ICalculationValidation calculationValidation)
        {
            _calculationValidation = calculationValidation;
        }

        public SpeedModel FromKilometersPerHour(double KMvalue)
        {
            _calculationValidation.LessThanZero(KMvalue);

            return new SpeedModel
            {
                KilometersPerHour = KMvalue,
                Knots = KMvalue / 1.852,
                MilesPerHour = KMvalue / 1.609
            };
        }
        public SpeedModel FromKnots(double KnotsValue)
        {
            _calculationValidation.LessThanZero(KnotsValue);

            return new SpeedModel
            {
                KilometersPerHour = KnotsValue * 1.852,
                Knots = KnotsValue,
                MilesPerHour = KnotsValue * 1.151
            };
        }
        public SpeedModel FromMile(double mileValue)
        {
            _calculationValidation.LessThanZero(mileValue);

            return new SpeedModel
            {
                KilometersPerHour = mileValue * 1.609,
                Knots = mileValue / 1.151,
                MilesPerHour = mileValue
            };
        }
    }
}
