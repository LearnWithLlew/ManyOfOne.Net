using NUnit.Framework;

namespace ManyOfOne
{
    public class _02MethodSignatures
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual("#1", Merge("#", 1));
        }

        private string Merge(string prefix, int number)
        {
            return prefix + number;
        }
    }
}