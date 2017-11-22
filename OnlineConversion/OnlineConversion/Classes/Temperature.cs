using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineConversion
{
    // This class will be for the different Temperature converstions to and from C and F
    public class Temperature
    {
        //We need a method for the C to F conversion
        public static double ConvertCelsiusToFahrenheit(double c)
        {
            return ((9.0 / 5.0) * c) + 32;
        }

        //We need a method for the F to C conversion
        public static double ConvertFahrenheitToCelsius(double f)
        {
            return (5.0 / 9.0) * (f - 32);
        }

    }
}