using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ValidacaoCartao.Tests
{
    [TestClass]
    public class ValidacaoAmex_Should
    {
        [TestMethod]
        public void Cartao_AMEX_numero_invalido()
        {
            //arrange
            string numero = "376421112222331";

            IValidacaoCartao validacao = new ValidacaoAmex();            

            //act
            bool valido = validacao.Validar(numero);

            //assert
            Assert.IsFalse(valido);
        }

        [TestMethod]
        public void Cartao_AMEX_numero_valido()
        {
            //arrange
            string numero = "376411112222331";

            IValidacaoCartao validacao = new ValidacaoAmex();

            //act
            bool valido = validacao.Validar(numero);

            //assert
            Assert.IsTrue(valido);
        }
    }
}
