using System;
using System.Linq;

namespace ValidacaoCartao
{
    public class ValidacaoAmex : IValidacaoCartao
    {
        static string[] codigosValidos = new string[] { "34", "37" };

        public bool Validar(string numero)
        {
            if (String.IsNullOrWhiteSpace(numero) && numero.Length != 15)
            {
                return false;
            }

            string codigoNumero = numero.Substring(0, 2);

            if (codigosValidos.Any(x => x == codigoNumero) == false)
            {
                return false;
            }

            return this.ValidacaoModuloDez(numero, fator: "1212121212121212121");
        }
    }
}
