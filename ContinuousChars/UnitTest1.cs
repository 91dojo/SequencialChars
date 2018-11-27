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
            throw new NotImplementedException();
        }
    }
}