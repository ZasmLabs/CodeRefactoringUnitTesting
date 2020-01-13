using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Module03Testing.Interfaces;
using Module03Testing.Utilities;
using Moq;

namespace Module03Testing.UtilitiesTests
{
    [TestClass]
    public class StringUtilTests
    {
        [TestMethod]
        public void ShouldFindOneGInRefactoring()
        {
            // Arrange
            var inputString = "Refactoring";
            var charToSearch = 'g';
            var expected = 1;
            var actual = 0;
            var objStringUtil = new StringUtil();

            // Act
            actual = objStringUtil.FindOccurences(inputString, charToSearch);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldBeCaseInsensitiveFindsTwoRInRefactoring()
        {
            // Arrange
            var inputString = "Refactoring";
            var charToSearch = 'r';
            var expected = 2;
            var actual = 0;
            var objStringUtil = new StringUtil();

            // Act
            actual = objStringUtil.FindOccurences(inputString, charToSearch);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldWorkWithNullInputStrings()
        {
            // Arrange
            string inputString = null;
            var charToSearch = 'g';
            var expected = 0;
            var actual = 0;
            var objStringUtil = new StringUtil(new BubbleSort());

            // Act
            actual = objStringUtil.FindOccurences(inputString, charToSearch);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldSortInputStringCharacters()
        {
            // Arrange
            var inputString = "yxz";
            var expectedResults = "xyz";
            var actualResults = string.Empty;
            var mockSort = new Mock<ISort>();
            mockSort.Setup(sort => sort.Sort(It.IsAny<string>()))
                .Returns("xyz");
            var objStringUtil = new StringUtil(new FakeSort());

            // Act
            actualResults = objStringUtil.SortInputStringChar(inputString);

            // Assert
            Assert.AreEqual(expectedResults, actualResults);
        }

        [TestMethod]
        public void SortInputStringCharShouldWorkWithNullInputStrings()
        {
            // Arrange
            string inputString = null;
            string expected = null;
            string actual = null;
            var objStringUtil = new StringUtil();

            // Act
            actual = objStringUtil.SortInputStringChar(inputString);

            // Assert
            Assert.AreEqual(expected, actual);
        }

    }
}