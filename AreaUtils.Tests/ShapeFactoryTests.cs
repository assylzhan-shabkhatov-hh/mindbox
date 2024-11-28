using AreaUtils.Factories;
using AreaUtils.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaUtils.Tests
{
    public class ShapeFactoryTests
    {
        [Fact]
        public void CreateCircle_ShouldReturnValidCircle()
        {
            var circle = ShapeFactory.CreateCircle(5);
            Assert.IsType<Circle>(circle);
            Assert.Equal(5, ((Circle)circle).Radius);
        }

        [Fact]
        public void CreateTriangle_ShouldReturnValidTriangle()
        {
            var triangle = ShapeFactory.CreateTriangle(3, 4, 5);
            Assert.IsType<Triangle>(triangle);
            Assert.Equal(3, ((Triangle)triangle).SideA);
            Assert.Equal(4, ((Triangle)triangle).SideB);
            Assert.Equal(5, ((Triangle)triangle).SideC);
        }
    }
}
