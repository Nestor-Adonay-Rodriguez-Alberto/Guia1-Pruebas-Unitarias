using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NARA.Cadena.UnitTestxUnit
{
    public class StringManipulatorTest
    {
        [Fact]
        public void ReverseStringTest()
        {
            // Arange:
            StringManipulator stringManipulator = new StringManipulator();
            string input = "Hola Mundo";
            string Esperado = "odnuM aloH";

            // Act:
            string inputInvertido = stringManipulator.ReverseString(input);

            // Assert:
            Assert.Equal(Esperado, inputInvertido);
        }


        [Fact]
        public void RemoveSpaces()
        {
            // Arange:
            StringManipulator stringManipulator = new StringManipulator();
            string input = "Hola Mundo Como Estan ?";
            string Esperado = "HolaMundoComoEstan?";

            // Act:
            string inputSinEspacios = stringManipulator.RemoveSpaces(input);

            // Assert:
            Assert.Equal(Esperado, inputSinEspacios);

        }
    }
}
