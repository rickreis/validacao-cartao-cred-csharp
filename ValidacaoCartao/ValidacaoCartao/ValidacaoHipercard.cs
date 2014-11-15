using System;

namespace ValidacaoCartao
{
    public class ValidacaoHipercard : IValidacaoCartao
    {   
        public bool Validar(string numero)
        {
            if (String.IsNullOrWhiteSpace(numero) && numero.Length != 19)
            {
                return false;
            }

            if (numero.Substring(0, 3) != "384")
            {
                return false;
            }

            int digitoVerificador;

            string numeroCartaoFull = numero.Substring(6, 13);

            //Validação do primeiro digito verificador                        
            numero = numeroCartaoFull.Substring(0, 8);
            digitoVerificador = ObterDigitoVerificador(fator: "98765432", numero: numero, iteracao: 7);

            if (Convert.ToInt32(numeroCartaoFull.Substring(8, 1)) != digitoVerificador)
            {
                return false;
            }

            //Validação do segundo digito verificador                
            numero = numeroCartaoFull.Substring(0, 9);
            digitoVerificador = ObterDigitoVerificador(fator: "298765432", numero: numero, iteracao: 8);

            if (Convert.ToInt32(numeroCartaoFull.Substring(9, 1)) != digitoVerificador)
            {
                return false;
            }

            //Validação do terceiro digito verificador               
            numero = numeroCartaoFull.Substring(0, 8) + numeroCartaoFull.Substring(10, 2);
            digitoVerificador = ObterDigitoVerificador(fator: "3298765432", numero: numero, iteracao: 9);

            if (Convert.ToInt32(numeroCartaoFull.Substring(12, 1)) != digitoVerificador)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Retorna o digito verificador
        /// </summary>
        /// <param name="fator">Fator</param>
        /// <param name="numero">Número cartão</param>
        /// <param name="iteracao">Iteracao</param>
        /// <returns>Digito Verificador</returns>
        private int ObterDigitoVerificador(string fator, string numero, int iteracao)
        {   
            int soma = 0;
            int numeroDaVez, peso;

            for (int i = 0; i <= iteracao; i++)
            {
                numeroDaVez = Convert.ToInt32(numero.Substring(i, 1));
                peso = Convert.ToInt32(fator.Substring(i, 1));
                soma += (numeroDaVez * peso);
            }

            int digitoVerificador = soma % 11;

            if (digitoVerificador == 1)
            {
                digitoVerificador = 0;
            }
            else if (digitoVerificador != 0)
            {
                digitoVerificador = 11 - digitoVerificador;
            }

            return digitoVerificador;
        }
    }
}
