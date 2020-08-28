using ApprovalUtilities.Utilities;
using NUnit.Framework;

namespace ManyOfOne
{
    public class _02PassingArrays
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual("#1\n", Merge("#", 1));
        }
     
        private string Merge(string prefix, params int[] numbers)
        {
            string result = string.Empty;
            foreach (var number in numbers)
            {
                result = prefix + number + "\n";
            }

            return result;
        }
       // [Test]
        public void Test2()
        {
            var expected = @"
                #1
                #2
                #3
                #4
                #5
                ".RemoveIndentation();
            Assert.AreEqual(expected, Merge("#", 1 ,2,3,4,5));
        }

    }
}