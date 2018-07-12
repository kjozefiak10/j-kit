using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Jk.Utilities.Common.UnitTests
{
    [TestClass]
    public class ArgsValidatorTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsNull_NullParameter_ThrowException()
        {
            ArgsValidator.IsNull(null, string.Empty);
        }

        [TestMethod]
        public void IsNull_NotNullParameter_DoNotThrowException()
        {
            ArgsValidator.IsNull(new object(), string.Empty);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsNullOrEmpty_NullParameter_ThrowException()
        {
            ArgsValidator.IsNullOrEmpty(null, string.Empty);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IsNullOrEmpty_EmptyParameter_ThrowException()
        {
            ArgsValidator.IsNullOrEmpty(string.Empty, string.Empty);
        }

        [TestMethod]
        public void IsNullOrEmpty_ParameterNotEmpty_DoNotThrowException()
        {
            ArgsValidator.IsNullOrEmpty("blah", string.Empty);
        }
    }
}
