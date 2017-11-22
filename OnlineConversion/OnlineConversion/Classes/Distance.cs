using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineConversion.Classes
{
    public class Distance
    {
        //We need a method for the C to F conversion
        public static double ConvertMilesToKm(double m)
        {
            return m * 1.6093;
        }

        //We need a method for the F to C conversion
        public static double ConvertKmToMiles(double km)
        {
            return km / 1.6093;
        }
    }
}