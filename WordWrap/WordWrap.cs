using System;
using System.Collections.Generic;
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
            List<String> list = new List<String>();
            String leftString = "";
            String nextString = "";
            int startposition = 0;
            int endposition = maxLength;
            String cutChar = input.Substring(maxLength, maxLength + 1);

            do
            {
                if (cutChar.Equals(" "))
                {
                    leftString = input.Substring(startposition, maxLength);
                }




            } while (endposition <= maxLength);
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
            
            String testA = "This is a test";
            String testExpectationA = "This is a \na test";
            String testB = "I am also a test";
            int testIntA = 7;
            int testIntB = 8;
            Assert.True(testExpectationA.Equals(WordWrap.Wrap(testA, testIntA)));
        }
    }
}

