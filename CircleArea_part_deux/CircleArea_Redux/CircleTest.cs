using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
namespace CircleArea_Redux
{
    public class CircleTest
    {
        [Theory]
        [InlineData(1, 6.28)]
        [InlineData(1.5, 9.42)]
        [InlineData(0, 0)]
        [InlineData(-1, -6.28)]
        public void TestCircumference(double radius, double expected)
        {
            //Arrange
            Circle c = new Circle(radius);
            //Act
            double actual = Math.Round(c.Circumference, 2);
            //Assert
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(1, 3.14)]
        [InlineData(1.5, 7.07)]
        [InlineData(0, 0)]
        [InlineData(-1, 3.14)]
        [InlineData(3, 28.27)]
        public void TestArea(double radius, double expected)
        {
            //Arrange
            Circle c = new Circle(radius);
            //Act
            double actual = Math.Round(c.Area, 2);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
