using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ValidacaoCartao.Tests
{
    [TestClass]
    public class ValidacaoVisa_Should
    {
        [TestMethod]
        public void Cartao_VISA_numero_invalido()
        {
            //arrange
            string numero = "4073010000000002";

            IValidacaoCartao validacao = new ValidacaoVisa();            

            //act
            bool valido = validacao.Validar(numero);

            //assert
            Assert.IsFalse(valido);
        }

        [TestMethod]
        public void Cartao_VISA_numero_valido()
        {
            //arrange
            string numero = "4073020000000002";

            IValidacaoCartao validacao = new ValidacaoVisa();

            //act
            bool valido = validacao.Validar(numero);

            //assert
            Assert.IsTrue(valido);
        }
    }
}
