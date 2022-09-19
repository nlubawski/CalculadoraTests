namespace Calculadora.NUnit
{
    public class Tests
    {
        private Util.Calculadora _calc;
        [SetUp]
        public void Setup()
        {
            _calc = new Util.Calculadora();
        }

        [Test]
        public void TestSomar()
        {
            Assert.AreEqual(6, _calc.Somar(3, 3));
        }

        [Test]
        public void TestSubtrair()
        {
            Assert.IsTrue(0 == _calc.Subtrair(3, 3));
        }

        [Test]
        [Ignore("ainda nao foi implementado")]
        public void TestMultiplicar()
        {
        }

        [Test]
        public void TestDividir()
        {
            Assert.Pass();
        }

    }
}