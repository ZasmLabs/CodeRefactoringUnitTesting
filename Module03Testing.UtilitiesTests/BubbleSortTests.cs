using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Module03Testing.Interfaces;
using Module03Testing.Utilities;

namespace Module03Testing.UtilitiesTests
{
    [TestClass]
    public class BubbleSortTests
    {
        [TestMethod]
        public void ShouldReturnABCForInputStringCBA()
        {
            // Arrange
            var inputString = "cba";
            var expectedOutput = "abc";
            string actualOutput = null;
            ISort sort = new BubbleSort();

            // Act
            actualOutput = sort.Sort(inputString);

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void ShouldReturnNullForNullInputString()
        {
            // Arrange
            string inputString = null;
            string expectedOutput = null;
            string actualOutput = null;
            ISort sort = new BubbleSort();

            // Act
            actualOutput = sort.Sort(inputString);

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}
