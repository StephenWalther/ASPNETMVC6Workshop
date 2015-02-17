using System;
using Xunit;
using MyProject.Models;

namespace MyProject.Test.Models
{
    
    public class CalculatorTests
    {


        [Fact]
        public void AddNumbers()
        {
            // Arrange
            var calcular = new Calculator();

            // Act
            var result = calcular.AddNumbers(1, 1);

            // Assert
            Assert.Equal(result, 13);
        }


        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(1, 1, 2)]
        [InlineData(-1, -1, -2)]
        public void AddNumbers(int num1, int num2, int expected)
        {
            // Arrange
            var calcular = new Calculator();

            // Act
            var result = calcular.AddNumbers(num1, num2);

            // Assert
            Assert.Equal(result, expected);
        }




    }
}