using NUnit.Framework;

namespace ManyOfOne
{
    public class _01InMethod
    {
       
        [Test]
        public void Test1()
        {
            Assert.AreEqual("1,2,3,5,7,11,13", PrintPrimes());
        }

        private string PrintPrimes()
        {
            var output = "";
            var number1 = 1;
            output += number1 + ",";
            var number2 = 2;
            output += number2 + ",";
            var number3 = 3;
            output += number3 + ",";
            var number4 = 5;
            output += number4 + ",";
            var number5 = 7;
            output += number5 + ",";
            var number6 = 11;
            output += number6 + ",";
            var number7 = 13;
            output += number7 + ",";
            return output;
        }
        
        
        [Test]
        public void Test2()
        {
            Assert.AreEqual("1,2,3,4,5,6,7,", PrintNumbersUpTo7());
        }

        private string PrintNumbersUpTo7()
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
            var number5 = 5;
            output += number5 + ",";
            var number6 = 6;
            output += number6 + ",";
            var number7 = 7;
            output += number7 + ",";
            return output;
        }
        
    }
}