using codesrc;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        calc c1;
        [SetUp]
        public void Setup()
        {
            c1 = new calc();
        }

        [Test]
        public void MultiplyTest()
        {
            double x = 3.0;
            double y = 12.7;

            double res = c1.Multiply(x,y);
            Assert.That((x*y), Is.EqualTo(res));
            
        }
    }
}