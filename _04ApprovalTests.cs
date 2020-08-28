using ApprovalTests;
using ApprovalTests.Core;
using ApprovalTests.Reporters;
using ApprovalUtilities.Utilities;
using NUnit.Framework;

namespace ManyOfOne
{
    [UseReporter(typeof(ClipboardReporter))]
    public class _04ApprovalTests
    {
        [Test]
        public void TestFizzBuzz()
        {
            int[] numbers = new []{1};
            var result = FizzBuzz(numbers[0]);
            Approvals.VerifyAll("FizzBuzz", numbers, n => FizzBuzz(n));
        }

        private string FizzBuzz(int number)
        {
            return "" + number;
        }
    }
}