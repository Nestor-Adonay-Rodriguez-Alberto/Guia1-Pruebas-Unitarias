using System;


namespace NARA.Temperatura
{
    public class TemperatureConverter
    {

        // METODO #1:
        public double CelsiusToFahrenheit(double celsius)
        {
            // Formula: F=( C * 1.8 ) + 32

            double Fahrenheit = (celsius * 1.8) + 32;

            return Fahrenheit;
        }

        // METODO #2:
        public double FahrenheitToCelsius(double fahrenheit)
        {
            // Formula: C=( F - 32 ) / 1.8

            double Celsius = (fahrenheit - 32) / 1.8;

            return Celsius;
        }
    }
}
