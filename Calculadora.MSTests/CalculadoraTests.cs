using System.Security.AccessControl;

namespace Calculadora.MSTests
{
    [TestClass]
    public class CalculadoraTests
    {
        private Util.Calculadora _calc;

        [TestInitialize]
        public void Setup()
        {
            _calc = new Util.Calculadora(2);
        }
            
        [TestMethod]
        public void TestSomar()
        {
            Assert.AreEqual(4, _calc.Somar(2, 2));
        }

        [TestMethod]
        public void TestSubtriar()
        { 
            Assert.AreEqual(0, _calc.Subtrair(3,3));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestSomarComException()
        {
            _calc.Somar(1, 1);
        }

        [TestMethod]
        [Ignore]
        public void TestMultiplicar()
        {

        }

        [TestMethod]
        [Ignore]
        public void TestDivisao()
        {

        }

        [TestCleanup]
        public void CleanUp()
        {
            _calc = null;
        }
    }
}