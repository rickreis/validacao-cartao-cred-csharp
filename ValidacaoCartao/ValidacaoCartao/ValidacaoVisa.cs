﻿using System;
namespace ValidacaoCartao
{
    public class ValidacaoVisa : IValidacaoCartao
    {
        public bool Validar(string numero)
        {
            if (String.IsNullOrWhiteSpace(numero))
            {
                return false;
            }

            if ((numero.Length != 13 || numero.Length != 16) && numero.Substring(0, 1) != "4")
                return false;            

            return numero.ValidacaoModuloDez(fator: "2121212121212121212");
        }
    }
}
