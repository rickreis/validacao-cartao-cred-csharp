using System;

namespace ValidacaoCartao
{
    public class ValidacaoVisa : IValidacaoCartao
    {
        public bool Validar(string numero)
        {
            if (String.IsNullOrWhiteSpace(numero) && (numero.Length != 13 || numero.Length != 16))
            {
                return false;
            }

            if (numero.StartsWith("4") == false)
            {
                return false;
            }   

            return this.ValidacaoModuloDez(numero, fator: "2121212121212121212");
        }
    }
}
