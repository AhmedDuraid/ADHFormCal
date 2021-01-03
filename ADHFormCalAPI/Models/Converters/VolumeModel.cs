namespace ADHFormCalAPI.Models.Converters
{
    public class VolumeModel
    {
        double _liter, _centiliter, _milliliter, _cubicMeter, _uSGallon,
            _uSTablespoon, _uSTeaspoon, _uKGallon, _uKTablespoon, _uKTeaspoon;

        //Metric
        public double Liter { get; set; }
        public char LiterSymbol => 'l';
        public double Centiliter { get; set; }
        public string CentiliterSymbol => "cl";
        public double Milliliter { get; set; }
        public string MilliliterSymbol => "ml";
        public double CubicMeter { get; set; }
        public string CubicMeterSymbol => "m^3";

        // US
        public double USGallon { get; set; }
        public string USGallonSymbol => "us gal";
        public double USTablespoon { get; set; }
        public string USTablespoonSymbol => "us tblsp";
        public double USTeaspoon { get; set; }
        public string USTeaspoonSymbol => "us tsp";


        // UK
        public double UKGallon { get; set; }
        public string UKGallonSymbol => "uk gal";
        public double UKTablespoon { get; set; }
        public string UKTablespoonSymbol => "uk tblsp";
        public double UKTeaspoon { get; set; }
        public string UKTeaspoonSymbol => "uk tsp";
    }
}
