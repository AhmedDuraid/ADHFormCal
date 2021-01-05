using ADHFormCalAPI.ErrorHandling;
using ADHFormCalAPI.Models.Converters;

namespace ADHFormCalAPI.Calculator.Converters
{
    public class WeightConvertingOperations : IWeightConvertingOperations
    {
        private readonly ICalculationValidation _calculationValidation;

        public WeightConvertingOperations(ICalculationValidation calculationValidation)
        {
            _calculationValidation = calculationValidation;
        }
        public WeightModel FromTonnes(double tonnesValue)
        {
            _calculationValidation.LessThanZero(tonnesValue);

            return new WeightModel
            {
                Tonnes = tonnesValue,
                Kilograms = tonnesValue / 0.001,
                Grams = tonnesValue / 0.000001,
                Milligrams = tonnesValue / 0.000000001,
                Pounds = tonnesValue * 2204.6,
                Ounces = tonnesValue * 35274
            };
        }
        public WeightModel FromKilograms(double kilogramsValue)
        {
            _calculationValidation.LessThanZero(kilogramsValue);

            return new WeightModel
            {
                Tonnes = kilogramsValue / 1000,
                Kilograms = kilogramsValue,
                Grams = kilogramsValue / 0.001,
                Milligrams = kilogramsValue / 0.000001,
                Pounds = kilogramsValue * 2.2046,
                Ounces = kilogramsValue * 35.274
            };
        }
        public WeightModel FromGrams(double gramsValue)
        {
            _calculationValidation.LessThanZero(gramsValue);

            return new WeightModel
            {
                Tonnes = gramsValue / 1000000,
                Kilograms = gramsValue / 1000,
                Grams = gramsValue,
                Milligrams = gramsValue / 0.001,
                Pounds = gramsValue * 0.0022046,
                Ounces = gramsValue * 0.035274
            };
        }
        public WeightModel FromMilligrams(double milligramsValue)
        {
            _calculationValidation.LessThanZero(milligramsValue);

            return new WeightModel
            {
                Tonnes = milligramsValue / 1000000000,
                Kilograms = milligramsValue / 1000000,
                Grams = milligramsValue / 1000,
                Milligrams = milligramsValue,
                Pounds = milligramsValue * 0.0000022046,
                Ounces = milligramsValue * 0.000035274
            };
        }
        public WeightModel FromPounds(double poundsValue)
        {
            _calculationValidation.LessThanZero(poundsValue);

            return new WeightModel
            {
                Tonnes = poundsValue / 2204.6,
                Kilograms = poundsValue / 2.2046,
                Grams = poundsValue / 0.0022046,
                Milligrams = poundsValue / 0.0000022046,
                Pounds = poundsValue,
                Ounces = poundsValue * 16.000
            };
        }
        public WeightModel FromOunces(double ouncesValue)
        {
            _calculationValidation.LessThanZero(ouncesValue);

            return new WeightModel
            {
                Tonnes = ouncesValue / 35274,
                Kilograms = ouncesValue / 35.274,
                Grams = ouncesValue / 0.035274,
                Milligrams = ouncesValue / 0.000035274,
                Pounds = ouncesValue * 0.062500,
                Ounces = ouncesValue
            };
        }
    }
}
