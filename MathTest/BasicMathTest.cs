using NUnit.Framework;

namespace MathTest
{
    [TestFixture]
    public class BasicMathTest
    {
        private const double f = 1.1;
        int i = 1 + 1;

        [Test]
        public void TestMethod1()
        {
            Assert.IsTrue(i == f);
        }
    }
}
