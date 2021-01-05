using ADHFormCalAPI.Models.Converters;

namespace ADHFormCalAPI.Calculator.Converters
{
    public interface IWeightConvertingOperations
    {
        WeightModel FromGrams(double gramsValue);
        WeightModel FromKilograms(double kilogramsValue);
        WeightModel FromMilligrams(double milligramsValue);
        WeightModel FromOunces(double ouncesValue);
        WeightModel FromPounds(double poundsValue);
        WeightModel FromTonnes(double tonnesValue);
    }
}