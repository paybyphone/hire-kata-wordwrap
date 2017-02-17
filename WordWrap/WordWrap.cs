using System;
using NUnit.Framework;

namespace WordWrap
{
    public static class WordWrap
    {
        // Given an input string of words separated by spaces, and a maximum line length,
        //  break the input at word boundaries such that no line is longer than the
        //  maximum.
        //
        // For example, Wrap("This is a test", 7) and Wrap("This is a test", 8) should
        //  both return "This is\na test".
        public static string Wrap(string input, int maxLength)
        {
            throw new NotImplementedException();
        }
    }

    [TestFixture]
    public class WordWrapTests
    {
        // You can run unit tests by right-clicking on the circle left of the test
        //  method.
        [Test]
        public void write_your_first_test_here()
        {
            Assert.That(true, Is.True);
        }
    }
}
