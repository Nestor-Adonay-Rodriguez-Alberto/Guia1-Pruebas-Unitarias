using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NARA.Temperatura.UnitTestMSTest
{
    [TestClass]
    public class TemperatureConverterTests
    {

        // TEST #1:
        [TestMethod]
        public void CelsiusToFahrenheitTest()
        {
            // Arange:
            TemperatureConverter converter = new TemperatureConverter();
            double Celsius = 20;
            double Esperado = 68;

            // Act:
            double Fahrenheit = converter.CelsiusToFahrenheit(Celsius);

            // Assert:
            Assert.AreEqual(Esperado, Fahrenheit);
        }


        // TEST #2:
        [TestMethod]
        public void FahrenheitToCelsiusTest()
        {
            // Arange:
            TemperatureConverter converter = new TemperatureConverter();
            double Fahrenheit = 68;
            double Esperado = 20;

            // Act:
            double Celsius = converter.FahrenheitToCelsius(Fahrenheit);

            // Assert:
            Assert.AreEqual(Esperado, Celsius);
        }

    }
}
