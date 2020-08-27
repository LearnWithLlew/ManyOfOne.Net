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
            int number = 1;
            var result = FizzBuzz(number);
            Approvals.Verify(result);
        }

        private string FizzBuzz(int number)
        {
            return "" + number;
        }
    }
}