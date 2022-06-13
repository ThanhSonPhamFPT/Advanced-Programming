using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Rectangle:Shape
    {
        private double width;
        private double height;
        public double Width { get { return width; } set { width = value; } }
        public double Height { get { return height; } set { height = value; } }
        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public override double CalculatePerimeter()
        {
            return (width + height) * 2;
        }

        public override double CalculateArea()
        {
            return width * height;
        }
        public override string Draw()
        {
            return $"Draw a rectangle with width:{Width} m, height:{Height} m and area:{CalculateArea()} m2";
        }
    }
}
