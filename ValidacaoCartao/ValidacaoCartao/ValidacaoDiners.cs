using System;

namespace ValidacaoCartao
{
    public class ValidacaoDinners : IValidacaoCartao
    {
        public bool Validar(string numero)
        {
            if (String.IsNullOrWhiteSpace(numero))
            {
                return false;
            }

            if ((numero.Substring(0, 3) == "300"
              || numero.Substring(0, 3) == "301"
              || numero.Substring(0, 3) == "302"
              || numero.Substring(0, 3) == "303"
              || numero.Substring(0, 3) == "304"
              || numero.Substring(0, 3) == "305"
              || numero.Substring(0, 2) == "36"
              || numero.Substring(0, 2) == "38")
              || numero.Length != 14)
            {                
                return numero.ValidacaoModuloDez(fator: "2121212121212121212");
            }

            return false;
        }
    }
}
