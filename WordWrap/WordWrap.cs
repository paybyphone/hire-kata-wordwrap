using System;
using System.Text;
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
            StringBuilder finalString = new StringBuilder();

            if (!String.IsNullOrEmpty(input))
            {
                string[] wordSplit = input.Split(' ');
                for (int i=0;i<wordSplit.Length;i++)
                {
                    string item = wordSplit[i];
                    if (item.Length > maxLength)
                        finalString.Append(item + "*" + "\n");
                    else
                    {
                        if(i < wordSplit.Length - 1)
                        finalString.Append(item + "\n");
                    }
                }
            }
            else
            {
                return "empty";
            }
            if(finalString.ToString().Contains("*"))
            return finalString.Append("* - indicates exceeds maxlength").ToString();
            else
            {
                return finalString.ToString();
            }
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
            Assert.AreEqual(returnValue, "empty");

        }
        [Test]
        public void wordWrap_CheckStringData1_NotExceedsMaxlength()
        {
            string returnValue = WordWrap.Wrap("This is",4 );
            Assert.AreEqual(returnValue, "This\nis");

        }
    }
}
