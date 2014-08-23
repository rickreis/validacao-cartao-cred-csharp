using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ValidacaoCartao.Tests
{
    [TestClass]
    public class ValidacaoHipercard_Should
    {
        [TestMethod]
        public void Cartao_HIPERCARD_numero_invalido()
        {
            //arrange
            string numero = "3841285607632390121";

            IValidacaoCartao validacao = new ValidacaoHipercard();            

            //act
            bool valido = validacao.Validar(numero);

            //assert
            Assert.IsFalse(valido);
        }

        [TestMethod]
        public void Cartao_HIPERCARD_numero_valido()
        {
            //arrange
            string numero = "3840285607632390124";

            IValidacaoCartao validacao = new ValidacaoHipercard();

            //act
            bool valido = validacao.Validar(numero);

            //assert
            Assert.IsTrue(valido);
        }
    }
}
