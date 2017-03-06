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
            if (string.IsNullOrEmpty((input)))
            {
                return string.Empty;
            }
            if (maxLength > input.Length)
            {
                maxLength = input.Length;
            }
            string front = input.Substring(0, maxLength-1);
            string back = input.Substring(maxLength);
            string result = string.Empty;
            result += front;
            result += "\n";
            result += back;
            return result;
        }
    }

    [TestFixture]
    public class WordWrapTests
    {
        // You can run unit tests by right-clicking on the circle to the left of the test
        //  method's line number.
        [Test]
        public void write_your_first_test_here()
        {
            // NUnit assertions follow the form:
            //  Assert.That(testResult, Is.Predicate(expression));
            // For example:
            //  Assert.That(someString,     Is.EqualTo("foo"));
            //  Assert.That(someInt,        Is.LessThan(42));
            //  Assert.That(someCollection, Is.Not.Empty);
            Assert.That(true, Is.True);
        }

        [Test]
        public void test_empty_string()
        {
            Assert.That(WordWrap.Wrap("", 5), Is.EqualTo(""));
        }
        [Test]
        public void test_no_word_wrap()
        {
            Assert.That(WordWrap.Wrap("I am Jack", 15), Is.EqualTo("I am Jack"));
        }

        [Test]
        public void test_with_word_wrap()
        {

            Assert.That(WordWrap.Wrap("I am Jack", 5), Is.EqualTo("I am\n Jack"));
        }
    }
}
