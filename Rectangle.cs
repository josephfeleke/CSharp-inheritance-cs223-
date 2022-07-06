using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace labWork3
{
    internal class Rectangle : Ishape
    {

        

        double height;
        double width;

        Rectangle(double height, double width)
        {
            this.height = height;
            this.width = width;
        }

        public double CalcualtePerimeter()
        {
           return (this.height *2) + ( this.width*2);
        }

        public double CalculateArea()
        {
            return this.height * this.width;
            
        }
    }
}
