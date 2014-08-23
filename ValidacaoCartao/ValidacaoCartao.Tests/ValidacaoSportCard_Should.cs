using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ValidacaoCartao.Tests
{
    [TestClass]
    public class ValidacaoSportCard_Should
    {
        [TestMethod]
        public void Cartao_SPORT_CARD_numero_invalido()
        {
            //arrange
            string numero = "4444161234567839";

            IValidacaoCartao validacao = new ValidacaoSportCard();            

            //act
            bool valido = validacao.Validar(numero);

            //assert
            Assert.IsFalse(valido);
        }

        [TestMethod]
        public void Cartao_SPORT_CARD_numero_valido()
        {
            //arrange
            string numero = "4444561234567839";

            IValidacaoCartao validacao = new ValidacaoSportCard();

            //act
            bool valido = validacao.Validar(numero);

            //assert
            Assert.IsTrue(valido);
        }
    }
}
