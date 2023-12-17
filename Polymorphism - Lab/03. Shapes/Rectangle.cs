using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public  class Rectangle : Shape
    {
        
        public Rectangle (int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        private int x;

        public int X
        {
            get { return x; }
            private set { x = value; }
        }

        private int y;

        public int Y
        {
            get { return y; }
           private set { y = value; }
        }

        public override double CalculatePerimeter()
        {
            return (this.X * 2) + (this.Y * 2);
            
        }

        public override double CalculateArea()
        {
            return this.X * this.Y;
        }
    }
}
