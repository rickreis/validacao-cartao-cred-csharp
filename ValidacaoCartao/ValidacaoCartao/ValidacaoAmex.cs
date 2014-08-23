using System;

namespace ValidacaoCartao
{
    public class ValidacaoAmex : IValidacaoCartao
    {
        public bool Validar(string numero)
        {
            if (String.IsNullOrWhiteSpace(numero))
            {
                return false;
            }

            if (((numero.Substring(0, 2) != "37" && numero.Substring(0, 2) != "34") || numero.Length != 15))
            {
                return false;
            }            

            return numero.ValidacaoModuloDez(fator: "1212121212121212121");            
        }
    }
}
