namespace ADHFormCalAPI.Models.Converters
{
    public class VolumeModel
    {
        double _liter, _centiliter, _milliliter, _cubicMeter, _uSGallon,
            _uSTablespoon, _uSTeaspoon, _uKGallon, _uKTablespoon, _uKTeaspoon;

        public VolumeModel(double value, string unit)
        {
            ValumeConverting(value, unit);
        }
        //Metric
        public double Liter
        {
            get => _liter;
            set => _liter = value < 0 ? 0 : value;
        }
        public double Centiliter
        {
            get => _centiliter;
            set => _centiliter = value < 0 ? 0 : value;
        }
        public double Milliliter
        {
            get => _milliliter;
            set => _milliliter = value < 0 ? 0 : value;
        }
        public double CubicMeter
        {
            get => _cubicMeter;
            set => _cubicMeter = value < 0 ? 0 : value;
        }

        // US
        public double USGallon
        {
            get => _uSGallon;
            set => _uSGallon = value < 0 ? 0 : value;
        }
        public double USTablespoon
        {
            get => _uSTablespoon;
            set => _uSTablespoon = value < 0 ? 0 : value;
        }
        public double USTeaspoon
        {
            get => _uSTeaspoon;
            set => _uSTeaspoon = value < 0 ? 0 : value;
        }

        // UK
        public double UKGallon
        {
            get => _uKGallon;
            set => _uKGallon = value < 0 ? 0 : value;
        }
        public double UKTablespoon
        {
            get => _uKTablespoon;
            set => _uKTablespoon = value < 0 ? 0 : value;
        }
        public double UKTeaspoon
        {
            get => _uKTeaspoon;
            set => _uKTeaspoon = value < 0 ? 0 : value;
        }

        private void ValumeConverting(double value, string unit)
        {
            switch (unit)
            {
                case "l":
                    {
                        SetMetricValues(value, value / 0.01, value / 0.001, value / 1000);
                        SetUSValues(value * 0.26417, value * 67.628, value * 202.88);
                        SetUKValues(value * 0.21997, value * 70.390, value * 281.56);
                        break;
                    }
                case "cl":
                    {
                        SetMetricValues(value / 100, value, value / 0.10000, value / 100000);
                        SetUSValues(value * 0.0026417, value * 0.67628, value * 2.0288);
                        SetUKValues(value * 0.0021997, value * 0.70390, value * 2.8156);
                        break;
                    }
                case "ml":
                    {
                        SetMetricValues(value / 1000, value / 10, value, value / 1000000);
                        SetUSValues(value * 0.00022702, value * 0.067628, value * 0.20288);
                        SetUKValues(value * 0.00021997, value * 0.070390, value * 0.28156);
                        break;
                    }
                case "m3":
                    {
                        SetMetricValues(value / 0.001, value / 0.00001, value / 0.000001, value);
                        SetUSValues(value * 264.17, value * 67628, value * 202880);
                        SetUKValues(value * 219.97, value * 70390, value * 281560);
                        break;
                    }
                case "us-gal-lqd":
                    {
                        SetMetricValues(value / 0.26417, value / 0.0026417, value / 0.00026417, value / 264.17);
                        SetUSValues(value, value * 256.00, value * 768.00);
                        SetUKValues(value * 0.83267, value * 266.46, value * 1065.8);
                        break;
                    }
                case "us-tblsp":
                    {
                        SetMetricValues(value / 67.628, value / 0.67628, value / 0.067628, value / 67628);
                        SetUSValues(value * 0.0039062, value, value * 3);
                        SetUKValues(value * 0.0032526, value * 1.0408, value * 4.1634);
                        break;
                    }
                case "us-tsp":
                    {
                        SetMetricValues(value / 202.88, value / 2.0288, value / 0.20288, value / 202880);
                        SetUSValues(value * 0.0013021, value * 0.33333, value);
                        SetUKValues(value * 0.0010842, value * 0.34695, value * 1.3878);
                        break;
                    }
                case "uk-gal":
                    {
                        SetMetricValues(value / 0.21997, value / 0.0021997, value / 0.00021997, value / 219.97);
                        SetUSValues(value * 1.2009, value * 307.44, value * 922.33);
                        SetUKValues(value, value * 320, value * 1280.0);
                        break;
                    }
                case "uk-tabsp":
                    {
                        SetMetricValues(value / 70.390, value / 0.70390, value / 0.070390, value / 70390);
                        SetUSValues(value * 0.0037530, value * 0.96076, value * 2.8823);
                        SetUKValues(value * 0.0031250, value, value * 4);
                        break;
                    }
                case "uk-tsp":
                    {
                        SetMetricValues(value / 281.56, value / 2.8156, value / 0.28156, value / 281560);
                        SetUSValues(value * 0.00093824, value * 0.24019, value * 0.72057);
                        SetUKValues(value * 0.00078125, value * 0.25000, value);
                        break;
                    }
            }
        }

        private void SetMetricValues(double liter, double centiliter, double milliliter, double cubicMeter)
        {
            Liter = liter;
            Centiliter = centiliter;
            Milliliter = milliliter;
            CubicMeter = cubicMeter;
        }
        private void SetUSValues(double uSGallons, double uSTablespoon, double uSTeaspoon)
        {
            USGallon = uSGallons;
            USTablespoon = uSTablespoon;
            USTeaspoon = uSTeaspoon;
        }
        private void SetUKValues(double uKGallon, double uKTablespoon, double uKTeaspoon)
        {
            UKGallon = uKGallon;
            UKTablespoon = uKTablespoon;
            UKTeaspoon = uKTeaspoon;
        }

    }
}
