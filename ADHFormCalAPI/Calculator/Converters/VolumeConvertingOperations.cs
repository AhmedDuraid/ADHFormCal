using ADHFormCalAPI.Models.Converters;

namespace ADHFormCalAPI.Calculator.Converters
{
    public class VolumeConvertingOperations
    {
        private string OperationUnit { get; set; }
        private double Value { get; set; }


        public VolumeConvertingOperations(string operationUnit, double value)
        {
            OperationUnit = operationUnit;
            Value = value;
        }

        public VolumeModel VolumeConverting()
        {
            VolumeModel model = new VolumeModel();

            //L
            if (OperationUnit == model.LiterSymbol.ToString())
            {
                model.Liter = Value;
                model.Centiliter = Value / 0.01;
                model.Milliliter = Value / 0.001;
                model.CubicMeter = Value / 1000;
                model.USGallon = Value * 0.26417;
                model.USTablespoon = Value * 67.628;
                model.USTeaspoon = Value * 202.88;
                model.UKGallon = Value * 0.21997;
                model.UKTablespoon = Value * 70.390;
                model.UKTeaspoon = Value * 281.56;

                return model;
            }

            //cl
            if (OperationUnit == model.CentiliterSymbol)
            {
                model.Liter = Value / 100;
                model.Centiliter = Value;
                model.Milliliter = Value / 0.10000;
                model.CubicMeter = Value / 100000;
                model.USGallon = Value * 0.0026417;
                model.USTablespoon = Value * 0.67628;
                model.USTeaspoon = Value * 2.0288;
                model.UKGallon = Value * 0.0021997;
                model.UKTablespoon = Value * 0.70390;
                model.UKTeaspoon = Value * 2.8156;

                return model;
            }

            //ml
            if (OperationUnit == model.MilliliterSymbol)
            {
                model.Liter = Value / 1000;
                model.Centiliter = Value / 10;
                model.Milliliter = Value;
                model.CubicMeter = Value / 1000000;
                model.USGallon = Value * 0.00022702;
                model.USTablespoon = Value * 0.067628;
                model.USTeaspoon = Value * 0.20288;
                model.UKGallon = Value * 0.00021997;
                model.UKTablespoon = Value * 0.070390;
                model.UKTeaspoon = Value * 0.28156;

                return model;
            }

            //m^3
            if (OperationUnit == model.CubicMeterSymbol)
            {
                model.Liter = Value / 0.001;
                model.Centiliter = Value / 0.00001;
                model.Milliliter = Value / 0.000001;
                model.CubicMeter = Value;
                model.USGallon = Value * 264.17;
                model.USTablespoon = Value * 67628;
                model.USTeaspoon = Value * 202880;
                model.UKGallon = Value * 219.97;
                model.UKTablespoon = Value * 70390;
                model.UKTeaspoon = Value * 281560;

                return model;
            }

            //US gal
            if (OperationUnit == model.USGallonSymbol)
            {
                model.Liter = Value / 0.26417;
                model.Centiliter = Value / 0.0026417;
                model.Milliliter = Value / 0.00026417;
                model.CubicMeter = Value / 264.17;
                model.USGallon = Value;
                model.USTablespoon = Value * 256.00;
                model.USTeaspoon = Value * 768.00;
                model.UKGallon = Value * 0.83267;
                model.UKTablespoon = Value * 266.46;
                model.UKTeaspoon = Value * 1065.8;

                return model;
            }

            //US tblsp
            if (OperationUnit == model.USTablespoonSymbol)
            {
                model.Liter = Value / 67.628;
                model.Centiliter = Value / 0.67628;
                model.Milliliter = Value / 0.067628;
                model.CubicMeter = Value / 67628;
                model.USGallon = Value * 0.0039062;
                model.USTablespoon = Value;
                model.USTeaspoon = Value * 3;
                model.UKGallon = Value * 0.0032526;
                model.UKTablespoon = Value * 1.0408;
                model.UKTeaspoon = Value * 4.1634;

                return model;
            }

            //US tsp
            if (OperationUnit == model.USTeaspoonSymbol)
            {
                model.Liter = Value / 202.88;
                model.Centiliter = Value / 2.0288;
                model.Milliliter = Value / 0.20288;
                model.CubicMeter = Value / 202880;
                model.USGallon = Value * 0.0013021;
                model.USTablespoon = Value * 0.33333;
                model.USTeaspoon = Value;
                model.UKGallon = Value * 0.0010842;
                model.UKTablespoon = Value * 0.34695;
                model.UKTeaspoon = Value * 1.3878;

                return model;
            }

            //UK gal
            if (OperationUnit == model.UKGallonSymbol)
            {
                model.Liter = Value / 0.21997;
                model.Centiliter = Value / 0.0021997;
                model.Milliliter = Value / 0.00021997;
                model.CubicMeter = Value / 219.97;
                model.USGallon = Value * 1.2009;
                model.USTablespoon = Value * 307.44;
                model.USTeaspoon = Value * 922.33;
                model.UKGallon = Value;
                model.UKTablespoon = Value * 320;
                model.UKTeaspoon = Value * 1280.0;

                return model;
            }

            // UK tblsp
            if (OperationUnit == model.UKTablespoonSymbol)
            {
                model.Liter = Value / 70.390;
                model.Centiliter = Value / 0.70390;
                model.Milliliter = Value / 0.070390;
                model.CubicMeter = Value / 70390;
                model.USGallon = Value * 0.0037530;
                model.USTablespoon = Value * 0.96076;
                model.USTeaspoon = Value * 2.8823;
                model.UKGallon = Value * 0.0031250;
                model.UKTablespoon = Value;
                model.UKTeaspoon = Value * 4;

                return model;
            }

            //UK tsp
            if (OperationUnit == model.UKTeaspoonSymbol)
            {
                model.Liter = Value / 281.56;
                model.Centiliter = Value / 2.8156;
                model.Milliliter = Value / 0.28156;
                model.CubicMeter = Value / 281560;
                model.USGallon = Value * 0.00093824;
                model.USTablespoon = Value * 0.24019;
                model.USTeaspoon = Value * 0.72057;
                model.UKGallon = Value * 0.00078125;
                model.UKTablespoon = Value * 0.25000;
                model.UKTeaspoon = Value;

                return model;
            }

            return null;
        }
    }
}
