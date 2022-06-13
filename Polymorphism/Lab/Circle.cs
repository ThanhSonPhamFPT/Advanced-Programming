using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Circle : Shape
    {
        private double radius;
        public double Radius { get { return radius; } set { radius = value; } }
        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
        public override string Draw()
        {
            return $"Draw a circle with radius:{radius} m and Area:{CalculateArea():0.00} m2";
        }


    }
}


