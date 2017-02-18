using System;
using System.Collections.Generic;
using System.Linq;
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
            String[] words = input.Split(' ');
            int lineLenght = maxLength;
            String line = "";
            String output;

            foreach(String word in words)
            {

                if (line.Length + word.Length <= lineLenght)
                {
                    line = String.Concat(line, " ", word);
                }

                else
                {
                    line = String.Concat(line, "\n", word);
                    lineLenght += maxLength;
                }

            }
            return line.TrimEnd();
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
            String testExpectationA = "This is\na test";
            String testB = "test";
            String testExpectationB = "test";
            int testIntA = 7;
            int testIntB = 8;
            Assert.True(testExpectationB.Equals(WordWrap.Wrap(testB, testIntA)));
        }
    }
}

