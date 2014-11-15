using System;

namespace ValidacaoCartao
{
    public static class ValidacaoExtensions
    {
        /// <summary>
        /// Aplicar a valicação Módulo 10, para a validação de cartão
        /// </summary>
        /// <returns>Retorna se o cartão é válido</returns>
        public static bool ValidacaoModuloDez(this IValidacaoCartao validacaoCartao, string numeroCartao, string fator)
        {
            if (String.IsNullOrWhiteSpace(numeroCartao))
            {
                return false;
            }

            int _numeroVez, _peso, _digitoVerificador;
            int _soma = 0;

            //Verifica se tem o número de digitos correto do cartão
            for (int i = 0; i < numeroCartao.Length - 1; i++)
            {
                _peso = Convert.ToInt32(fator.Substring(i, 1));

                _numeroVez = Convert.ToInt32(numeroCartao.Substring(i, 1));

                string resultTemp = (_numeroVez * _peso).ToString();

                if (resultTemp.Length == 1)
                {
                    _soma += Convert.ToInt32(resultTemp);
                }
                else
                {
                    for (int j = 0; j < resultTemp.Length; j++)
                    {
                        _soma += Convert.ToInt32(resultTemp.Substring(j, 1));
                    }
                }
            }

            //Verificando a soma e o resto para validar último digito. (resto = soma % 10)
            _digitoVerificador = _soma % 10;
            if (_digitoVerificador != 0)
            {
                _digitoVerificador = 10 - _digitoVerificador;
            }

            if (Convert.ToInt32(numeroCartao.Substring(numeroCartao.Length - 1, 1)) == _digitoVerificador)
            {
                return true;
            }

            return false;
        }
    }
}
