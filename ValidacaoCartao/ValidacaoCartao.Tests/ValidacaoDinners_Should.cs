using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ValidacaoCartao.Tests
{
    [TestClass]
    public class ValidacaoDinners_Should
    {
        [TestMethod]
        public void Cartao_DINNERS_numero_invalido()
        {
            //arrange
            string numero = "30211122223331";

            IValidacaoCartao validacao = new ValidacaoDinners();            

            //act
            bool valido = validacao.Validar(numero);

            //assert
            Assert.IsFalse(valido);
        }

        [TestMethod]
        public void Cartao_DINNERS_numero_valido()
        {
            //arrange
            string numero = "30111122223331";

            IValidacaoCartao validacao = new ValidacaoDinners();

            //act
            bool valido = validacao.Validar(numero);

            //assert
            Assert.IsTrue(valido);
        }
    }
}
