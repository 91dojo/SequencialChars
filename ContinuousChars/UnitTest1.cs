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
    }
}