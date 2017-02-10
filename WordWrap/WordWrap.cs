using System;
using NUnit.Framework;

namespace WordWrap
{
    public static class WordWrap
    {
        public static string Wrap(string input, int maxLength)
        {
            // this is divys
        /*this
         * is
         *  
          */
            if (!String.IsNullOrEmpty(input))
            {
                string[] wordSplit = input.Split(' ');
                foreach (var item in wordSplit)
                {
                    if (item.Length > maxLength)
                        return item + " :exceeds maxlength ";
                    else
                        return item;
                }
            }
            else
            {
                return "empty";
            }
            return "";
            //throw new NotImplementedException();
        }
    }

    [TestFixture]
    public class WordWrapTests
    {
        [Test]
        public void wordWrap_CheckEmptyString()
        {
            string returnValue = WordWrap.Wrap("", 2);
            Assert.Equals(returnValue, "empty");

        }
    }
}
