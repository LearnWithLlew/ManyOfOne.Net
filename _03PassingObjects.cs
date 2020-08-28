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
        [Test]
        public void Test2AllowForCustomPrefix()
        {
            Assert.AreEqual("*1", Format(1, new Options() { Prefix = "*"}));
        }
        
        [Test]
        public void Test3AllowForCustomPrefixAndSuffix()
        {
            var expected = "#1)";
            Assert.AreEqual(expected, Format(1, new Options(){ Suffix = ")"}));
        }

        private string Format(int number, Options options = default)
        {
            return options.Prefix + number + options.Suffix;
        }

        private struct Options
        {
            private string _prefix;
            private string _suffix;

            public string Prefix
            {
                get => _prefix ?? "#";
                set => _prefix = value;
            }

            public string Suffix
            {
                get => _suffix ?? string.Empty;
                set => _suffix = value;
            }
        }
    }
}