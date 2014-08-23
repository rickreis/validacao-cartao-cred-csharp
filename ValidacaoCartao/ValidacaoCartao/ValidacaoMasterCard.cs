using System;

namespace ValidacaoCartao
{
    public class ValidacaoMasterCard : IValidacaoCartao
    {
        public bool Validar(string numero)
        {
            if (String.IsNullOrWhiteSpace(numero))
            {
                return false;
            }

            if (numero.Length != 16
                && (numero.Substring(0, 2) != "51"
                || numero.Substring(0, 2) != "52"
                || numero.Substring(0, 2) != "53"
                || numero.Substring(0, 2) != "54"
                || numero.Substring(0, 2) != "55"))
            {
                return false;
            }

            return numero.ValidacaoModuloDez(fator: "2121212121212121212");
        }
    }
}
