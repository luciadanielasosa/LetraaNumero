using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumeroaLetra.Controllers;

namespace UnitTestNumeroaLetra
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestLiteral()
        {
            //arage
            LiteralController literalController = new LiteralController();
            int numero= 6; string esperado = "SEIS";

            //act
            string resultado = literalController.Literalget(numero);

            //assert
            Assert.AreEqual(esperado, resultado);

        }
    }
}
