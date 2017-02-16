using System;
using NUnit.Framework;

namespace WordWrap
{
    public static class WordWrap
    {
        // Implement a word-wrapping function that, given a string of words separated by spaces,
        //  breaks that string into multiple lines such that no line is longer than the maximum
        //  length.
        // For example, WordWrap.Wrap("This is a test", 7) should return "This is\na test"
        public static string Wrap(string input, int maxLineLength)
        {
            if (input.Length <= maxLineLength)
            {
                return input;
            }
            else
            {
                return input.Substring(0, maxLineLength) + "\n" + Wrap(input.Substring(maxLineLength), maxLineLength);
            }
        }
    }

    [TestFixture]
    public class WordWrapTests
    {
        [Test]
        public void EmptyStringTest()
        {
            var testString = "";
            var max = 1;
            var resp = WordWrap.Wrap(testString, max);
            if (resp.Length == 0)
            {
                Assert.That(true, Is.True);
            }
            else
            {
                Assert.That(true, Is.False);
            }
        }
    }
}
