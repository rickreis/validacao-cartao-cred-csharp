using System;

namespace ValidacaoCartao
{
    public class ValidacaoAura : IValidacaoCartao
    {
        public bool Validar(string numero)
        {
            if (String.IsNullOrWhiteSpace(numero))
            {
                return false;
            }

            if (numero.Length != 19)
            {
                return false;
            }

            return numero.ValidacaoModuloDez(fator: "1212121212121212121");
        }
    }
}
