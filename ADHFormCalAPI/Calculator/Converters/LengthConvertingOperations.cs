using ADHFormCalAPI.ErrorHandling;
using ADHFormCalAPI.Models.Converters;

namespace ADHFormCalAPI.Calculator.Converters
{
    public class LengthConvertingOperations : ILengthConvertingOperations
    {
        private readonly ICalculationValidation _validation;
        public LengthConvertingOperations(ICalculationValidation validation)
        {
            _validation = validation;
        }

        public LengthModel FromKilometers(double KilometersValue)
        {
            _validation.LessThanZero(KilometersValue);

            return new()
            {
                Kilometers = KilometersValue,
                Meters = KilometersValue / 0.001,
                Centimeters = KilometersValue / 0.00001,
                Millimeters = KilometersValue / 0.000001,
                Miles = KilometersValue * 0.62137,
                Foot = KilometersValue * 3280.8,
                Yards = KilometersValue * 1093.6,
                Inches = KilometersValue * 39370,
            };
        }
        public LengthModel FromMeters(double MetersValue)
        {
            _validation.LessThanZero(MetersValue);
            return new LengthModel
            {
                Kilometers = MetersValue / 1000,
                Meters = MetersValue,
                Centimeters = MetersValue / 0.010,
                Millimeters = MetersValue / 0.001,
                Miles = MetersValue * 0.00062137,
                Foot = MetersValue * 3.2808,
                Yards = MetersValue * 1.0936,
                Inches = MetersValue * 39.37
            };
        }
        public LengthModel FromCentimeters(double CentimetersValue)
        {
            _validation.LessThanZero(CentimetersValue);
            return new()
            {
                Kilometers = CentimetersValue / 100000,
                Meters = CentimetersValue / 100,
                Centimeters = CentimetersValue,
                Millimeters = CentimetersValue / 0.1,
                Miles = CentimetersValue * 0.0000062137,
                Foot = CentimetersValue * 0.032808,
                Yards = CentimetersValue * 0.010936,
                Inches = CentimetersValue * 0.39370
            };
        }
        public LengthModel FromMillimeter(double MillimeterValue)
        {
            _validation.LessThanZero(MillimeterValue);

            return new()
            {
                Kilometers = MillimeterValue / 1000000,
                Meters = MillimeterValue / 1000,
                Centimeters = MillimeterValue / 10,
                Millimeters = MillimeterValue,
                Miles = MillimeterValue * 0.00000062137,
                Foot = MillimeterValue * 0.0032808,
                Yards = MillimeterValue * 0.0010936,
                Inches = MillimeterValue * 0.039370
            };
        }
        public LengthModel FromMiles(double MilesValue)
        {
            _validation.LessThanZero(MilesValue);

            return new()
            {
                Kilometers = MilesValue / 0.62137,
                Meters = MilesValue / 0.00062137,
                Centimeters = MilesValue / 0.0000062137,
                Millimeters = MilesValue / 0.00000062137,
                Miles = MilesValue,
                Foot = MilesValue * 5280.0,
                Yards = MilesValue * 1760.0,
                Inches = MilesValue * 6336
            };
        }
        public LengthModel FromFoot(double FootValue)
        {
            _validation.LessThanZero(FootValue);

            return new()
            {
                Kilometers = FootValue / 3280.8,
                Meters = FootValue / 3.2808,
                Centimeters = FootValue / 0.032808,
                Millimeters = FootValue / 0.0032808,
                Miles = FootValue * 0.00018939,
                Foot = FootValue,
                Yards = FootValue * 0.33333,
                Inches = FootValue * 12
            };
        }
        public LengthModel FromYard(double YardValue)
        {
            _validation.LessThanZero(YardValue);
            return new()
            {
                Kilometers = YardValue / 1093.6,
                Meters = YardValue / 1.0936,
                Centimeters = YardValue / 0.010936,
                Millimeters = YardValue / 0.0010936,
                Miles = YardValue * 0.00056818,
                Foot = YardValue * 3,
                Yards = YardValue,
                Inches = YardValue * 36
            };
        }
        public LengthModel FromInche(double IncheValue)
        {
            _validation.LessThanZero(IncheValue);
            return new()
            {
                Kilometers = IncheValue / 39370,
                Meters = IncheValue / 39.370,
                Centimeters = IncheValue / 0.39370,
                Millimeters = IncheValue / 0.039370,
                Miles = IncheValue * 0.000015783,
                Foot = IncheValue * 0.083333,
                Yards = IncheValue * 0.027778,
                Inches = IncheValue
            };
        }
    }
}
