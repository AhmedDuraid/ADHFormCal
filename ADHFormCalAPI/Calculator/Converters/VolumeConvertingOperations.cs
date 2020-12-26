using ADHFormCalAPI.Models.Converters;

namespace ADHFormCalAPI.Calculator.Converters
{
    public class VolumeConvertingOperations
    {
        private readonly string _operationUnit;
        private readonly double _value;


        public VolumeConvertingOperations(string operationUnit, double value)
        {
            _operationUnit = operationUnit;
            _value = value;
        }

        public VolumeModel VolumeConverting()
        {
            VolumeModel model = new VolumeModel();

            //L
            if (_operationUnit == model.LiterSymbol.ToString())
            {
                model.Liter = _value;
                model.Centiliter = _value / 0.01;
                model.Milliliter = _value / 0.001;
                model.CubicMeter = _value / 1000;
                model.USGallon = _value * 0.26417;
                model.USTablespoon = _value * 67.628;
                model.USTeaspoon = _value * 202.88;
                model.UKGallon = _value * 0.21997;
                model.UKTablespoon = _value * 70.390;
                model.UKTeaspoon = _value * 281.56;

                return model;
            }

            //cl
            if (_operationUnit == model.CentiliterSymbol)
            {
                model.Liter = _value / 100;
                model.Centiliter = _value;
                model.Milliliter = _value / 0.10000;
                model.CubicMeter = _value / 100000;
                model.USGallon = _value * 0.0026417;
                model.USTablespoon = _value * 0.67628;
                model.USTeaspoon = _value * 2.0288;
                model.UKGallon = _value * 0.0021997;
                model.UKTablespoon = _value * 0.70390;
                model.UKTeaspoon = _value * 2.8156;

                return model;
            }

            //ml
            if (_operationUnit == model.MilliliterSymbol)
            {
                model.Liter = _value / 1000;
                model.Centiliter = _value / 10;
                model.Milliliter = _value;
                model.CubicMeter = _value / 1000000;
                model.USGallon = _value * 0.00022702;
                model.USTablespoon = _value * 0.067628;
                model.USTeaspoon = _value * 0.20288;
                model.UKGallon = _value * 0.00021997;
                model.UKTablespoon = _value * 0.070390;
                model.UKTeaspoon = _value * 0.28156;

                return model;
            }

            //m^3
            if (_operationUnit == model.CubicMeterSymbol)
            {
                model.Liter = _value / 0.001;
                model.Centiliter = _value / 0.00001;
                model.Milliliter = _value / 0.000001;
                model.CubicMeter = _value;
                model.USGallon = _value * 264.17;
                model.USTablespoon = _value * 67628;
                model.USTeaspoon = _value * 202880;
                model.UKGallon = _value * 219.97;
                model.UKTablespoon = _value * 70390;
                model.UKTeaspoon = _value * 281560;

                return model;
            }

            //US gal
            if (_operationUnit == model.USGallonSymbol)
            {
                model.Liter = _value / 0.26417;
                model.Centiliter = _value / 0.0026417;
                model.Milliliter = _value / 0.00026417;
                model.CubicMeter = _value / 264.17;
                model.USGallon = _value;
                model.USTablespoon = _value * 256.00;
                model.USTeaspoon = _value * 768.00;
                model.UKGallon = _value * 0.83267;
                model.UKTablespoon = _value * 266.46;
                model.UKTeaspoon = _value * 1065.8;

                return model;
            }

            //US tblsp
            if (_operationUnit == model.USTablespoonSymbol)
            {
                model.Liter = _value / 67.628;
                model.Centiliter = _value / 0.67628;
                model.Milliliter = _value / 0.067628;
                model.CubicMeter = _value / 67628;
                model.USGallon = _value * 0.0039062;
                model.USTablespoon = _value;
                model.USTeaspoon = _value * 3;
                model.UKGallon = _value * 0.0032526;
                model.UKTablespoon = _value * 1.0408;
                model.UKTeaspoon = _value * 4.1634;

                return model;
            }

            //US tsp
            if (_operationUnit == model.USTeaspoonSymbol)
            {
                model.Liter = _value / 202.88;
                model.Centiliter = _value / 2.0288;
                model.Milliliter = _value / 0.20288;
                model.CubicMeter = _value / 202880;
                model.USGallon = _value * 0.0013021;
                model.USTablespoon = _value * 0.33333;
                model.USTeaspoon = _value;
                model.UKGallon = _value * 0.0010842;
                model.UKTablespoon = _value * 0.34695;
                model.UKTeaspoon = _value * 1.3878;

                return model;
            }

            //UK gal
            if (_operationUnit == model.UKGallonSymbol)
            {
                model.Liter = _value / 0.21997;
                model.Centiliter = _value / 0.0021997;
                model.Milliliter = _value / 0.00021997;
                model.CubicMeter = _value / 219.97;
                model.USGallon = _value * 1.2009;
                model.USTablespoon = _value * 307.44;
                model.USTeaspoon = _value * 922.33;
                model.UKGallon = _value;
                model.UKTablespoon = _value * 320;
                model.UKTeaspoon = _value * 1280.0;

                return model;
            }

            // UK tblsp
            if (_operationUnit == model.UKTablespoonSymbol)
            {
                model.Liter = _value / 70.390;
                model.Centiliter = _value / 0.70390;
                model.Milliliter = _value / 0.070390;
                model.CubicMeter = _value / 70390;
                model.USGallon = _value * 0.0037530;
                model.USTablespoon = _value * 0.96076;
                model.USTeaspoon = _value * 2.8823;
                model.UKGallon = _value * 0.0031250;
                model.UKTablespoon = _value;
                model.UKTeaspoon = _value * 4;

                return model;
            }

            //UK tsp
            if (_operationUnit == model.UKTeaspoonSymbol)
            {
                model.Liter = _value / 281.56;
                model.Centiliter = _value / 2.8156;
                model.Milliliter = _value / 0.28156;
                model.CubicMeter = _value / 281560;
                model.USGallon = _value * 0.00093824;
                model.USTablespoon = _value * 0.24019;
                model.USTeaspoon = _value * 0.72057;
                model.UKGallon = _value * 0.00078125;
                model.UKTablespoon = _value * 0.25000;
                model.UKTeaspoon = _value;

                return model;
            }

            return null;
        }
    }
}
