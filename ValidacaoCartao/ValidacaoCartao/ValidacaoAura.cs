using System;

namespace ValidacaoCartao
{
    public class ValidacaoAura : IValidacaoCartao
    {
        public bool Validar(string numero)
        {
            if (String.IsNullOrWhiteSpace(numero) && numero.Length != 19)
            {
                return false;
            }            

            return this.ValidacaoModuloDez(numero, fator: "1212121212121212121");
        }
    }
}
