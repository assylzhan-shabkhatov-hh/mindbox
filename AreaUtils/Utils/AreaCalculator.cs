using AreaUtils.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaUtils.Utils
{
    public static class AreaCalculator
    {
        public static double Calculate(IShape shape)
        {
            if (shape == null)
                throw new ArgumentNullException(nameof(shape), "Shape cannot be null.");

            return shape.CalculateArea();
        }
    }
}
