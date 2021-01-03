using ADHFormCalAPI.ErrorHandling;
using ADHFormCalAPI.Models.Converters;

namespace ADHFormCalAPI.Calculator.Converters
{
    public class PressureConvertingOperations : IPressureConvertingOperations
    {
        private readonly ICalculationValidation _calculationValidation;
        public PressureConvertingOperations(ICalculationValidation calculationValidation)
        {
            _calculationValidation = calculationValidation;
        }

        public PressureModel FromPascals(double PascalsValue)
        {
            _calculationValidation.LessThanZero(PascalsValue);

            return new PressureModel
            {
                Pascals = PascalsValue,
                Bar = PascalsValue / 100000,
                Torrs = PascalsValue * 0.0075006
            };
        }
        public PressureModel FromBar(double BarValue)
        {
            _calculationValidation.LessThanZero(BarValue);

            return new PressureModel
            {
                Pascals = BarValue / 0.000010000,
                Bar = BarValue,
                Torrs = BarValue * 750.06,
            };
        }
        public PressureModel FromTorr(double TorrValue)
        {
            _calculationValidation.LessThanZero(TorrValue);
            return new PressureModel
            {
                Pascals = TorrValue / 0.0075006,
                Bar = TorrValue / 750.06,
                Torrs = TorrValue
            };
        }
    }
}
