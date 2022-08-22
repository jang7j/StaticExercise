using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    internal static class TempConverter
    {
        public static double FahrenheitToCelsius(double degrees)
        {
            return (degrees - 32.0) * (5.0 / 9.0);
        }
        public static double CelsiusToFahrenheit(double degrees)
        {
            return (degrees * (9.0 / 5.0)) + 32;
        }

    }
}

