using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labWork3
{
    internal class Circle : Ishape
    {
        const double PI = 3.14;
        double radius;

        public double CalcualtePerimeter()
        {
            return 2 * PI * this.radius;
        }

        public double CalculateArea()
        {
            return PI * (this.radius * this.radius);
        }
    }
}
