using System;
using NameParser;
using Xunit;

namespace XUnitTestNameParser.Tests
{
    public class NameParsingTest
    {
        [Fact]
        public void FirstAndLastNameParsed()
        {
            //Arrange
            var name = "Martin Cross";
            var parser = new Parser();

            //Act
            var result = parser.ParseName(name);

            //Assert if result.firstName is not = "Martin" The test will fail
            Assert.Equal("Martin", result.FirstName);
            Assert.Equal("Cross", result.LastName);
        }

        [Fact] // Fact / MUST BE PUBLIC / VOID / NO ARGUMENTS
        public void ThreePartNamesShouldBeParsedCorrectly()
        {
            //Arrange
            var name = "Martin Zachariah Cross";
            var parser = new Parser();
            //Act
            var result = parser.ParseName(name);
            //Assert
            Assert.Equal("Martin", result.FirstName);
            Assert.Equal("Cross", result.LastName);
        }
    }
}
