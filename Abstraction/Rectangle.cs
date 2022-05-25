using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Rectangle
    {
        private Point topLeft;
        private Point bottomRight;
        // TODO: Public properties
        public Point TopLeft { get { return topLeft; } set { topLeft = value; } }
        public Point BottomRight { get { return bottomRight; } set { bottomRight = value; } } 
        public Rectangle()
        {
            this.TopLeft = new Point();
            this.BottomRight = new Point();
        }
        public Rectangle(Point x, Point y)
        {
            topLeft = x;
            bottomRight = y;
        }
        public Rectangle(int topLeftX, int topLeftY, int bottomRightX, int bottomRightY)
        {
            this.topLeft = new Point(topLeftX, topLeftY);
            this.bottomRight = new Point(bottomRightX, bottomRightY);
        }
        public bool Contains(Point point)
        {
            bool isInHorizontal = this.TopLeft.X <= point.X && this.BottomRight.X >= point.X;
            bool isInVertical = this.TopLeft.Y <= point.Y && this.BottomRight.Y >= point.Y;
            bool isInRectangle = isInHorizontal && isInVertical;
            return isInRectangle;

        }
        

    }
}
