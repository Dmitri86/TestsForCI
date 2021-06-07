using NUnit.Framework;

namespace TestsForCI
{
    [TestFixture]
    internal class Program
    {
        public static void Main(string[] args)
        {
        }

        public static int Sum(int a, int b)
        {
            return a + b;
        }

        [Test]
        public void Test1()
        {
            var actual = Sum(2, 3);
            Assert.AreEqual(actual, 5);
        }

        [Test]
        public void Test2()
        {
            var actual = Sum(4, 5);
            Assert.AreEqual(actual, 9);
        }

        [Test]
        public void Test3()
        {
            var actual = Sum(10, 3);
            Assert.AreEqual(actual, 13);
        }
    }
}