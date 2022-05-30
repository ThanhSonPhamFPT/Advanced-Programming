using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Box
    {
        private double length;
        private double width;
        private double height;
        private double Length { 
            set
            {
                if (value <= 0) throw new ArgumentException("Length can not be zero or negative");
                length = value;
            } 
        }
        private double Width
        {
            set
            {
                if (value <= 0) throw new ArgumentException("Width can not be zero or negative");
                width = value;
            }
        }
        private double Height
        {
            set
            {
                if (value <= 0) throw new ArgumentException("Height can not be zero or negative");
                height = value;
            }
        }
        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }
        public double SurfaceArea()
        {
            return 2 * length * width + 2 * length * height + 2 * width * height;
        }
        public double LateralSurfaceArea()
        {
            return 2 * length * height + 2 * width * height;
        }
        public double Volume()
        {
            return length * height * width;
        }
    }
}
    