using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MachininigCalculatorLibary;

namespace MachiningCalculatorTests
{
    public class ReadNumberFromUITests
    {
        // Test for readIntNumber method
        // Test for readIntNumber method with valid input

        [Fact]
        public void readIntNumberValidInput()
        {
            // Arrange
            string input = "5";
            int expected = 5;

            // Act
            int actual = ReadNumberFromUI.readIntNumber(input);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void readIntNumberInvalidInput()
        {
            // Arrange
            string input = "abc";

            // Act and Assert
            Assert.Throws<Exception>(() => ReadNumberFromUI.readIntNumber(input));
        }

        [Fact]
        public void readDoubleNumberValidInput()
        {
            // Arrange
            string input = "5,5";
            double expected = 5.5;

            // Act
            double actual = ReadNumberFromUI.readDoubleNumber(input);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void readDoubleNumberInvalidInput()
        {
            // Arrange
            string input = "abc";

            // Act and Assert
            Assert.Throws<Exception>(() => ReadNumberFromUI.readDoubleNumber(input));
        }
    }
}
