using ADHFormCalAPI.Models.Converters;

namespace ADHFormCalAPI.Calculator.Converters
{
    public interface ILengthConvertingOperations
    {
        LengthModel FromCentimeters(double CentimetersValue);
        LengthModel FromFoot(double FootValue);
        LengthModel FromInche(double IncheValue);
        LengthModel FromKilometers(double KilometersValue);
        LengthModel FromMeters(double MetersValue);
        LengthModel FromMiles(double MilesValue);
        LengthModel FromMillimeter(double MillimeterValue);
        LengthModel FromYard(double YardValue);
    }
}