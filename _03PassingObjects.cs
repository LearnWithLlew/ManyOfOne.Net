using ApprovalUtilities.Utilities;
using NUnit.Framework;

namespace ManyOfOne
{
    public class _03PassingObects
    {
        [Test]
        public void Test1HardCodedFormat()
        {
            Assert.AreEqual("#1", Format(1));
        }
        [Test, Ignore("Until ready")]
        public void Test2AllowForCustomPrefix()
        {
            Assert.AreEqual("*1", Format(1 /*, ? */));
        }
        
        [Test, Ignore("Until ready")]
        public void Test3AllowForCustomPrefixAndSuffix()
        {
            var expected = "#1)";
            Assert.AreEqual(expected, Format(1 /*, ?*/));
        }

        private string Format(int number, Options options = default)
        {
            return "#" + number ;
        }

        private struct Options
        {
    
            public string Prefix => "#";
        }
    }
}