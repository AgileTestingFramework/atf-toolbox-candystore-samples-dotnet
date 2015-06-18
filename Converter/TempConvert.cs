/* Class for temperature */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tempConverter
{
    class TempConvert
    {
        public static double CelsToFaren(double temperature)
        {
            temperature = Math.Round(temperature, 3);
            double farenhateTemp = (temperature * 9 / 5) + 32;
            return Math.Round(farenhateTemp, 3);
        }

        public static double FarenToCels(double temperature)
        {
            temperature = Math.Round(temperature, 3);
            double celsieTemp = (temperature - 32) * 5 / 9;
            return Math.Round(celsieTemp, 3);
        }

        public static double FarenToKelv(double temperature)
        {
            temperature = Math.Round(temperature, 3);
            double kelvinTemp = (temperature + 459.67)*5/9;
            return Math.Round(kelvinTemp, 3);
        }

        public static double KelvinToFaren(double temperature)
        {
            temperature = Math.Round(temperature, 3);
            double farenhateTemp = temperature * 9/5 - 459.67;
            return Math.Round(farenhateTemp, 3);
        }

        public static double CelsToKelvin(double temperature)
        {
            temperature = Math.Round(temperature, 3);
            double kelvinTemp = temperature + 273.15;
            return Math.Round(kelvinTemp, 3);
        }

        public static double KelvinToCels(double temperature)
        {
            temperature = Math.Round(temperature, 3);
            double celsieTemp = temperature - 273.15;
            return Math.Round(celsieTemp, 3);
        }

    }
}
