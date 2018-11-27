using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ContinuousChars
{
    [TestClass]
    public class UnitTest1
    {
        private Validator _validator;

        [TestMethod]
        public void one_char()
        {
            _validator = new Validator();
            Assert.IsTrue(_validator.IsContinuous("b"));
        }

        [TestMethod]
        public void two_char_and_is_continuous()
        {
            _validator = new Validator();
            Assert.IsTrue(_validator.IsContinuous("bc"));
        }

        [TestMethod]
        public void two_char_and_is_not_continuous()
        {
            _validator = new Validator();
            Assert.IsFalse(_validator.IsContinuous("bd"));
        }

        [TestMethod]
        public void two_char_upper_case_and_is_continuous()
        {
            _validator = new Validator();
            Assert.IsTrue(_validator.IsContinuous("IJk"));
        }
    }
}