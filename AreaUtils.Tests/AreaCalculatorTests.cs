using AreaUtils.Models;
using AreaUtils.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaUtils.Tests
{
    public class AreaCalculatorTests
    {
        [Fact]
        public void CalculateCircleArea_ShouldReturnCorrectArea()
        {
            var circle = new Circle(5);
            double area = AreaCalculator.Calculate(circle);
            Assert.Equal(78.54, area, 2);
        }

        [Fact]
        public void CalculateTriangleArea_ShouldReturnCorrectArea()
        {
            var triangle = new Triangle(3, 4, 5);
            double area = AreaCalculator.Calculate(triangle);
            Assert.Equal(6, area, 2);
        }
    }
}
