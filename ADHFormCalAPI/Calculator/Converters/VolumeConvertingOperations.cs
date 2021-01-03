using ADHFormCalAPI.ErrorHandling;
using ADHFormCalAPI.Models.Converters;

namespace ADHFormCalAPI.Calculator.Converters
{
    public class VolumeConvertingOperations : IVolumeConvertingOperations
    {
        private readonly ICalculationValidation _calculationValidation;

        public VolumeConvertingOperations(ICalculationValidation calculationValidation)
        {
            _calculationValidation = calculationValidation;
        }
        public VolumeModel FromLiter(double literValue)
        {
            _calculationValidation.LessThanZero(literValue);

            return new VolumeModel
            {
                Liter = literValue,
                Centiliter = literValue / 0.01,
                Milliliter = literValue / 0.001,
                CubicMeter = literValue / 1000,
                USGallon = literValue * 0.26417,
                USTablespoon = literValue * 67.628,
                USTeaspoon = literValue * 202.88,
                UKGallon = literValue * 0.21997,
                UKTablespoon = literValue * 70.390,
                UKTeaspoon = literValue * 281.56
            };
        }
        public VolumeModel FromCentiliter(double centiliterValue)
        {
            _calculationValidation.LessThanZero(centiliterValue);

            return new VolumeModel
            {
                Liter = centiliterValue / 100,
                Centiliter = centiliterValue,
                Milliliter = centiliterValue / 0.10000,
                CubicMeter = centiliterValue / 100000,
                USGallon = centiliterValue * 0.0026417,
                USTablespoon = centiliterValue * 0.67628,
                USTeaspoon = centiliterValue * 2.0288,
                UKGallon = centiliterValue * 0.0021997,
                UKTablespoon = centiliterValue * 0.70390,
                UKTeaspoon = centiliterValue * 2.8156
            };
        }
        public VolumeModel FromMilliliter(double milliliterValue)
        {
            _calculationValidation.LessThanZero(milliliterValue);

            return new VolumeModel
            {
                Liter = milliliterValue / 1000,
                Centiliter = milliliterValue / 10,
                Milliliter = milliliterValue,
                CubicMeter = milliliterValue / 1000000,
                USGallon = milliliterValue * 0.00022702,
                USTablespoon = milliliterValue * 0.067628,
                USTeaspoon = milliliterValue * 0.20288,
                UKGallon = milliliterValue * 0.00021997,
                UKTablespoon = milliliterValue * 0.070390,
                UKTeaspoon = milliliterValue * 0.28156
            };
        }
        public VolumeModel FromCubicMeter(double cubicMeterValue)
        {
            _calculationValidation.LessThanZero(cubicMeterValue);

            return new VolumeModel
            {
                Liter = cubicMeterValue / 0.001,
                Centiliter = cubicMeterValue / 0.00001,
                Milliliter = cubicMeterValue / 0.000001,
                CubicMeter = cubicMeterValue,
                USGallon = cubicMeterValue * 264.17,
                USTablespoon = cubicMeterValue * 67628,
                USTeaspoon = cubicMeterValue * 202880,
                UKGallon = cubicMeterValue * 219.97,
                UKTablespoon = cubicMeterValue * 70390,
                UKTeaspoon = cubicMeterValue * 281560
            };
        }
        public VolumeModel FromUSGallon(double uSGallonValue)
        {
            _calculationValidation.LessThanZero(uSGallonValue);

            return new VolumeModel
            {
                Liter = uSGallonValue / 0.26417,
                Centiliter = uSGallonValue / 0.0026417,
                Milliliter = uSGallonValue / 0.00026417,
                CubicMeter = uSGallonValue / 264.17,
                USGallon = uSGallonValue,
                USTablespoon = uSGallonValue * 256.00,
                USTeaspoon = uSGallonValue * 768.00,
                UKGallon = uSGallonValue * 0.83267,
                UKTablespoon = uSGallonValue * 266.46,
                UKTeaspoon = uSGallonValue * 1065.8
            };
        }
        public VolumeModel FromUSTablespoon(double uSTablespoonValue)
        {
            _calculationValidation.LessThanZero(uSTablespoonValue);

            return new VolumeModel
            {
                Liter = uSTablespoonValue / 67.628,
                Centiliter = uSTablespoonValue / 0.67628,
                Milliliter = uSTablespoonValue / 0.067628,
                CubicMeter = uSTablespoonValue / 67628,
                USGallon = uSTablespoonValue * 0.0039062,
                USTablespoon = uSTablespoonValue,
                USTeaspoon = uSTablespoonValue * 3,
                UKGallon = uSTablespoonValue * 0.0032526,
                UKTablespoon = uSTablespoonValue * 1.0408,
                UKTeaspoon = uSTablespoonValue * 4.1634
            };
        }
        public VolumeModel FromUSTeaspoon(double uSTeaspoonValue)
        {
            _calculationValidation.LessThanZero(uSTeaspoonValue);

            return new VolumeModel
            {
                Liter = uSTeaspoonValue / 202.88,
                Centiliter = uSTeaspoonValue / 2.0288,
                Milliliter = uSTeaspoonValue / 0.20288,
                CubicMeter = uSTeaspoonValue / 202880,
                USGallon = uSTeaspoonValue * 0.0013021,
                USTablespoon = uSTeaspoonValue * 0.33333,
                USTeaspoon = uSTeaspoonValue,
                UKGallon = uSTeaspoonValue * 0.0010842,
                UKTablespoon = uSTeaspoonValue * 0.34695,
                UKTeaspoon = uSTeaspoonValue * 1.3878
            };
        }
        public VolumeModel FromUKGallon(double uKGallonValue)
        {
            _calculationValidation.LessThanZero(uKGallonValue);

            return new VolumeModel
            {
                Liter = uKGallonValue / 0.21997,
                Centiliter = uKGallonValue / 0.0021997,
                Milliliter = uKGallonValue / 0.00021997,
                CubicMeter = uKGallonValue / 219.97,
                USGallon = uKGallonValue * 1.2009,
                USTablespoon = uKGallonValue * 307.44,
                USTeaspoon = uKGallonValue * 922.33,
                UKGallon = uKGallonValue,
                UKTablespoon = uKGallonValue * 320,
                UKTeaspoon = uKGallonValue * 1280.0
            };
        }
        public VolumeModel FromUKTablespoon(double uKTablespoonValue)
        {
            _calculationValidation.LessThanZero(uKTablespoonValue);

            return new VolumeModel
            {
                Liter = uKTablespoonValue / 70.390,
                Centiliter = uKTablespoonValue / 0.70390,
                Milliliter = uKTablespoonValue / 0.070390,
                CubicMeter = uKTablespoonValue / 70390,
                USGallon = uKTablespoonValue * 0.0037530,
                USTablespoon = uKTablespoonValue * 0.96076,
                USTeaspoon = uKTablespoonValue * 2.8823,
                UKGallon = uKTablespoonValue * 0.0031250,
                UKTablespoon = uKTablespoonValue,
                UKTeaspoon = uKTablespoonValue * 4
            };
        }
        public VolumeModel FromUKTeaspoon(double uKTeaspoonValue)
        {
            _calculationValidation.LessThanZero(uKTeaspoonValue);

            return new VolumeModel
            {
                Liter = uKTeaspoonValue / 281.56,
                Centiliter = uKTeaspoonValue / 2.8156,
                Milliliter = uKTeaspoonValue / 0.28156,
                CubicMeter = uKTeaspoonValue / 281560,
                USGallon = uKTeaspoonValue * 0.00093824,
                USTablespoon = uKTeaspoonValue * 0.24019,
                USTeaspoon = uKTeaspoonValue * 0.72057,
                UKGallon = uKTeaspoonValue * 0.00078125,
                UKTablespoon = uKTeaspoonValue * 0.25000,
                UKTeaspoon = uKTeaspoonValue
            };
        }
    }
}
