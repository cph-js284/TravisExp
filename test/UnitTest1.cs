using codesrc;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        calc calcObj;
        [SetUp]
        public void Setup()
        {
            calcObj=new calc();
        }

        [Test]
        public void AddingTwoNumbers(){
            var res = calcObj.add(23,8);
            Assert.AreEqual(31, res,0.00001, "The numbers does not add up - add function fail");
        }

    }
}