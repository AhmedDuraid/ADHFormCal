namespace ADHFormCalAPI.Models.Converters
{
    public class VolumeModel
    {
        double _liter, _centiliter, _milliliter, _cubicMeter, _uSGallon,
            _uSTablespoon, _uSTeaspoon, _uKGallon, _uKTablespoon, _uKTeaspoon;

        //Metric
        public double Liter
        {
            get => _liter;
            set => _liter = value < 0 ? 0 : value;
        }
        public char LiterSymbol => 'l';
        public double Centiliter
        {
            get => _centiliter;
            set => _centiliter = value < 0 ? 0 : value;
        }
        public string CentiliterSymbol => "cl";
        public double Milliliter
        {
            get => _milliliter;
            set => _milliliter = value < 0 ? 0 : value;
        }
        public string MilliliterSymbol => "ml";
        public double CubicMeter
        {
            get => _cubicMeter;
            set => _cubicMeter = value < 0 ? 0 : value;
        }
        public string CubicMeterSymbol => "m^3";

        // US
        public double USGallon
        {
            get => _uSGallon;
            set => _uSGallon = value < 0 ? 0 : value;
        }
        public string USGallonSymbol => "us gal";
        public double USTablespoon
        {
            get => _uSTablespoon;
            set => _uSTablespoon = value < 0 ? 0 : value;
        }
        public string USTablespoonSymbol => "us tblsp";
        public double USTeaspoon
        {
            get => _uSTeaspoon;
            set => _uSTeaspoon = value < 0 ? 0 : value;
        }
        public string USTeaspoonSymbol => "us tsp";


        // UK
        public double UKGallon
        {
            get => _uKGallon;
            set => _uKGallon = value < 0 ? 0 : value;
        }
        public string UKGallonSymbol => "uk gal";
        public double UKTablespoon
        {
            get => _uKTablespoon;
            set => _uKTablespoon = value < 0 ? 0 : value;
        }
        public string UKTablespoonSymbol => "uk tblsp";
        public double UKTeaspoon
        {
            get => _uKTeaspoon;
            set => _uKTeaspoon = value < 0 ? 0 : value;
        }
        public string UKTeaspoonSymbol => "uk tsp";
    }
}
