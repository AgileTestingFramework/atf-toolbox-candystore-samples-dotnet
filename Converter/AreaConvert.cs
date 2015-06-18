/* Class for area */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tempConverter
{
    class AreaConvert
    {
        public static double SantimToInch(double area)
        {
            area = Math.Round(area, 3);
            double inchArea = area * 6.452;
            return Math.Round(inchArea, 3);
        }

        public static double InchToSantim(double area)
        {
            area = Math.Round(area, 3);
            double santimArea = area * 0.155;
            return Math.Round(santimArea, 3);
        }

        public static double KilomToMile(double area)
        {
            area = Math.Round(area, 3);
            double mileArea = area * 2.59;
            return Math.Round(mileArea, 3);
        }

        public static double MileToKilom(double area)
        {
            area = Math.Round(area, 3);
            double kilomArea = area * 0.3861;
            return Math.Round(kilomArea, 3);
        }

        public static double GektToAcr(double area)
        {
            area = Math.Round(area, 3);
            double acrArea = area * 0.4047;
            return Math.Round(acrArea, 3);
        }

        public static double AcrToGekt(double area)
        {
            area = Math.Round(area, 3);
            double gektArea = area * 2.471;
            return Math.Round(gektArea, 3);
        }

    }
}
