using ApprovalTests;
using ApprovalTests.Core;
using ApprovalTests.Reporters;
using ApprovalUtilities.Utilities;
using NUnit.Framework;

namespace ManyOfOne
{
    [UseReporter(typeof(DiffReporter))]
    public class _04ApprovalTests
    {
        [Test]
        public void TestFizzBuzz()
        {
            int[] numbers = new []{1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            var result = FizzBuzz(numbers[0]);
            Approvals.VerifyAll("FizzBuzz", numbers, n => FizzBuzz(n));
        }

        private string FizzBuzz(int number)
        {
            return "" + number;
        }
    }
}