using AreaUtils.Interfaces;
using AreaUtils.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaUtils.Factories
{
    public static class ShapeFactory
    {
        public static IShape CreateCircle(double radius) => new Circle(radius);
        
        public static IShape CreateTriangle(double sideA, double sideB, double sideC) => new Triangle(sideA, sideB, sideC);
    }
}
