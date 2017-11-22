using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineConversion.Classes
{
    public class Weight
    {
        public static double ConverKgToLb(double kg)
        {
            return (kg / 0.45359237);
        }

        public static double ConverLbToKg(double lb)
        {
            return (lb * 0.45359237);// 2.2046226);
        }
    }
}