using ApprovalUtilities.Utilities;
using NUnit.Framework;

namespace ManyOfOne
{
    public class _03PassingObects
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual("#1", Format(1));
        }
        [Test, Ignore("Until ready")]
        public void Test2()
        {
            Assert.AreEqual("#1", Format(1 /*, ? */));
        }
        
        [Test, Ignore("Until ready")]
        public void Test3()
        {
            var expected = "#1)";
            Assert.AreEqual(expected, Format(1 /*, ?*/));
        }

        private string Format(int number)
        {
            return "#" + number ;
        }
    }
}