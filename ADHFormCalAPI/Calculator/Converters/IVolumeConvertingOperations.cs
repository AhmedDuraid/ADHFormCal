using ADHFormCalAPI.Models.Converters;

namespace ADHFormCalAPI.Calculator.Converters
{
    public interface IVolumeConvertingOperations
    {
        VolumeModel FromCentiliter(double centiliterValue);
        VolumeModel FromCubicMeter(double cubicMeterValue);
        VolumeModel FromLiter(double literValue);
        VolumeModel FromMilliliter(double milliliterValue);
        VolumeModel FromUKGallon(double uKGallonValue);
        VolumeModel FromUKTablespoon(double uKTablespoonValue);
        VolumeModel FromUKTeaspoon(double uKTeaspoonValue);
        VolumeModel FromUSGallon(double uSGallonValue);
        VolumeModel FromUSTablespoon(double uSTablespoonValue);
        VolumeModel FromUSTeaspoon(double uSTeaspoonValue);
    }
}