using System;


namespace NARA.Cadena
{
    public class StringManipulator
    {
        // METODO #1:
        public string ReverseString(string input)
        {
            char[] caracteres = input.ToCharArray();

            Array.Reverse(caracteres);

            string inputInvertido = new string(caracteres);

            return inputInvertido;
        }

        // METODO #2:
        public string RemoveSpaces(string input)
        {
            string inputSinEspacios = input.Replace(" ", "");

            return inputSinEspacios;
        }
    }
}
