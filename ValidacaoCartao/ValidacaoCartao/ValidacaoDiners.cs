using System;
using System.Linq;

namespace ValidacaoCartao
{
    public class ValidacaoDinners : IValidacaoCartao
    {
        static string[] codigosValidos = new string[] { "300", "301", "302", "303", "304", "305", "36", "38" };

        public bool Validar(string numero)
        {
            if (String.IsNullOrWhiteSpace(numero) && numero.Length != 14)
            {
                return false;
            }

            string codigoNumero = numero.Substring(0, 3);

            if (codigosValidos.Any(x => x == codigoNumero) == false)
            {
                return false;    
            }

            return this.ValidacaoModuloDez(numero, fator: "2121212121212121212");            
        }
    }
}
