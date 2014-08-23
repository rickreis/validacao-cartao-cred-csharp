using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ValidacaoCartao.Tests
{
    [TestClass]
    public class ValidacaoAura_Should
    {
        [TestMethod]
        public void Cartao_AURA_1_numero_invalido()
        {
            //arrange
            string numero = "5078611870000127985";

            IValidacaoCartao validacao = new ValidacaoAura();            

            //act
            bool valido = validacao.Validar(numero);

            //assert
            Assert.IsFalse(valido);
        }

        [TestMethod]
        public void Cartao_AURA_1_numero_valido()
        {
            //arrange
            string numero = "5078601870000127985";

            IValidacaoCartao validacao = new ValidacaoAura();

            //act
            bool valido = validacao.Validar(numero);

            //assert
            Assert.IsTrue(valido);
        }

        [TestMethod]
        public void Cartao_AURA_2_numero_invalido()
        {
            //arrange
            string numero = "5078611800003247449";

            IValidacaoCartao validacao = new ValidacaoAura();

            //act
            bool valido = validacao.Validar(numero);

            //assert
            Assert.IsFalse(valido);
        }

        [TestMethod]
        public void Cartao_AURA_2_numero_valido()
        {
            //arrange
            string numero = "5078601800003247449";

            IValidacaoCartao validacao = new ValidacaoAura();

            //act
            bool valido = validacao.Validar(numero);

            //assert
            Assert.IsTrue(valido);
        }
    }
}
