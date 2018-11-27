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

        [TestMethod]
        public void with_star_signal()
        {
            _validator = new Validator();
            Assert.IsTrue(_validator.IsContinuous("I*k"));
        }

        [TestMethod]
        public void only_one_star()
        {
            _validator = new Validator();
            Assert.IsTrue(_validator.IsContinuous("*"));
        }

        [TestMethod]
        public void first_char_is_star()
        {
            _validator = new Validator();
            Assert.IsTrue(_validator.IsContinuous("*k"));
        }

        [TestMethod]
        public void last_char_is_star()
        {
            _validator = new Validator();
            Assert.IsTrue(_validator.IsContinuous("K*"));
        }

        [TestMethod]
        public void first_and_last_char_are_star()
        {
            _validator = new Validator();
            Assert.IsTrue(_validator.IsContinuous("*K*"));
        }

        [TestMethod]
        public void two_star()
        {
            _validator = new Validator();
            Assert.IsTrue(_validator.IsContinuous("**"));
        }

        [TestMethod]
        public void two_star_inside_string()
        {
            _validator = new Validator();
            Assert.IsTrue(_validator.IsContinuous("A*c*E"));
        }

        [TestMethod]
        public void two_star_inside_string_not_continuous()
        {
            _validator = new Validator();
            Assert.IsFalse(_validator.IsContinuous("A*A*E"));
        }

        [TestMethod]
        public void other_signal()
        {
            _validator = new Validator();
            Assert.IsFalse(_validator.IsContinuous("k-*"));
        }
    }
}