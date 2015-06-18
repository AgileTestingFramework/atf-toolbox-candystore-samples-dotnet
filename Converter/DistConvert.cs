/* Class for distance */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tempConverter
{
    class DistConvert
    {

        public static double MeterToFoot(double distance)
        {
            distance = Math.Round(distance, 3);
            double footDist = distance * 3.281;
            return Math.Round(footDist, 3);
        }

        public static double FootToMeter(double distance)
        {
            distance = Math.Round(distance, 3);
            double metrDist = distance * 0.304;
            return Math.Round(metrDist, 3);
        }

        public static double MeterToYard(double distance)
        {
            distance = Math.Round(distance, 3);
            double yardDist = distance * 0.914;
            return Math.Round(yardDist, 3);
        }

        public static double YardToMeter(double distance)
        {
            distance = Math.Round(distance, 3);
            double metrDist = distance * 1.094;
            return Math.Round(metrDist, 3);
        }

        public static double KilometToMile(double distance)
        {
            distance = Math.Round(distance, 3);
            double mileDist = distance * 1.609;
            return Math.Round(mileDist, 3);
        }

        public static double MileToKilomet(double distance)
        {
            distance = Math.Round(distance, 3);
            double kilomDist = distance * 0.621;
            return Math.Round(kilomDist, 3);
        }

    }
}
