using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using View;

namespace UnitTestProjectCalculadora
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestaSomar1()
        {
            Assert.AreEqual(new Operacoes().Somar(2, 7), 9);
        }

        [TestMethod]
        public void TestaSomar2()
        {
            Assert.AreEqual(new Operacoes().Somar(22, 7), 29);
        }

        [ExpectedException(typeof(ArgumentException), "Não permite este tipo de cálculo")]
        [TestMethod]
        public void TestaSubtracaoComDadosInvalidos()
        {
            Assert.AreEqual(new Operacoes().Subtrair(1, 7), -6);
        }
        
        //ERRADO
        [TestMethod]
        public void TestaSubtracaoComDadosInvalidos2()
        {
            Assert.AreEqual(new Operacoes().Subtrair(1, 7), -6);
        }
    }
}
