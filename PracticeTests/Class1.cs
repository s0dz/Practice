using NUnit.Framework;
using NUnit.Framework.Internal;
using Practice;

namespace PracticeTests
{
    [TestFixture]
    public class Program
    {
        private WordUtilities _wordUtilities;

        [SetUp]
        public void SetUp()
        {
            _wordUtilities = new WordUtilities();
        }

        [Test]
        public void ReverseVowelsTest()
        {
            var word1 = "apple";
            var result1 = _wordUtilities.ReverseVowels(word1);
            Assert.That(string.Equals(result1, "eppla"));

            var word2 = "friend";
            var result2 = _wordUtilities.ReverseVowels(word2);
            Assert.That(string.Equals(result2, "freind"));
        }
    }
}
