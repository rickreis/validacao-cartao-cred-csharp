using System;
using System.Linq;

namespace ValidacaoCartao
{
    public class ValidacaoMasterCard : IValidacaoCartao
    {
        static string[] codigosValidos = new string[] { "51", "52", "53", "54", "55" };

        public bool Validar(string numero)
        {
            if (String.IsNullOrWhiteSpace(numero) && numero.Length != 16)
            {
                return false;
            }

            string codigoNumero = numero.Substring(0, 2);

            if (codigosValidos.Any(x=> x == codigoNumero) == false)
            {
                return false;
            }

            return this.ValidacaoModuloDez(numero, fator: "2121212121212121212");
        }
    }
}
