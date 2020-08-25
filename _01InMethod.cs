using NUnit.Framework;

namespace ManyOfOne
{
    public class _01InMethod
    {
       
        [Test]
        public void Test1()
        {

            Assert.AreEqual("1,2,3,4,", FizzBuzz1());
        }

        private string FizzBuzz1()
        {
            var output = "";
            var number1 = 1;
            output += number1 + ",";
            var number2 = 2;
            output += number2 + ",";
            var number3 = 3;
            output += number3 + ",";
            var number4 = 4;
            output += number4 + ",";
            return output;
        }
    }
}