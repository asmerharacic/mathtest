using NUnit.Framework;

namespace MathTest
{
    [TestFixture]
    public class BasicMathTest
    {
        int i = 1 + 1;

        [Test]
        public void TestMethod1()
        {
            Assert.IsTrue(i == 2);
            Assert.AreEqual(i, 2);
            Assert.AreNotEqual(i, 3);
        }
    }
}
