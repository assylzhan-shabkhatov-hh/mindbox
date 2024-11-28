using AreaUtils.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaUtils.Tests
{
    public class TriangleTests
    {
        [Fact]
        public void IsRightAngled_ShouldReturnTrue_ForRightTriangle()
        {
            var rightTriangle = new Triangle(3, 4, 5);
            bool result = rightTriangle.IsRightAngled();
            Assert.True(result);
        }

        [Fact]
        public void IsRightAngled_ShouldReturnFalse_ForNonRightTriangle()
        {
            var nonRightTriangle = new Triangle(2, 3, 4);
            bool result = nonRightTriangle.IsRightAngled();
            Assert.False(result); 
        }
    }
}
