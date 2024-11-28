using AreaUtils.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaUtils.Tests
{
    public class ShapeValidationTests
    {
        [Fact]
        public void CreateCircle_WithNegativeRadius_ShouldThrowArgumentException()
        {
            var exception = Assert.Throws<ArgumentException>(() => new Circle(-5));
            Assert.Equal("Radius must be greater than zero.", exception.Message);
        }

        [Fact]
        public void CreateTriangle_WithNegativeSide_ShouldThrowArgumentException()
        {
            var exception = Assert.Throws<ArgumentException>(() => new Triangle(-3, 4, 5));
            Assert.Equal("Sides must be greater than zero.", exception.Message);
        }

        [Fact]
        public void CreateTriangle_WithInvalidSideLengths_ShouldThrowArgumentException()
        {
            var exception = Assert.Throws<ArgumentException>(() => new Triangle(1, 1, 3));
            Assert.Equal("The sum of any two sides must be greater than the third side.", exception.Message);
        }
    }
}
