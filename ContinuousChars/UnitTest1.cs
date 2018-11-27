using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ContinuousChars
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void one_char()
        {
            var input = "b";
            var isContinuous = new Validator().IsContinuous(input);
            Assert.IsTrue(isContinuous);
        }
    }

    public class Validator
    {
        public bool IsContinuous(string input)
        {
            if (input == null) throw new ArgumentNullException(nameof(input));

            if (input.Length == 1)
            {
                return true;
            }

            throw new NotImplementedException();
        }
    }
}