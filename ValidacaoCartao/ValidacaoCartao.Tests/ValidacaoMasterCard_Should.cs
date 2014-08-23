using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ValidacaoCartao.Tests
{
    [TestClass]
    public class ValidacaoMasterCard_Should
    {
        [TestMethod]
        public void Cartao_MASTER_CARD_numero_invalido()
        {
            //arrange
            string numero = "5120176333501186";

            IValidacaoCartao validacao = new ValidacaoMasterCard();            

            //act
            bool valido = validacao.Validar(numero);

            //assert
            Assert.IsFalse(valido);
        }

        [TestMethod]
        public void Cartao_MASTER_CARD_numero_valido()
        {
            //arrange
            string numero = "5120776333501186";

            IValidacaoCartao validacao = new ValidacaoMasterCard();

            //act
            bool valido = validacao.Validar(numero);

            //assert
            Assert.IsTrue(valido);
        }
    }
}
