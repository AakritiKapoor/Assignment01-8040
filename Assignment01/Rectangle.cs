using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    public class Rectangle
    {
        private double length;
        private double width;

        public Rectangle()
        {
            length = 1;
            width = 1;
        }
        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public double GetLength() {
            return length;

        }
        public double SetLength(double length) {
            if (length < 1)
            {
                throw new ArgumentOutOfRangeException("Invalid dimension");
                
            }
            else
            {
                this.length = length;
            }

            return this.length;
        }
        public double GetWidth() {
            return width;
        }
        public double SetWidth(double width)
        {
            if (width < 1)
            {
                throw new ArgumentOutOfRangeException("Invalid dimension");
            }
            else
            {
                this.width = width;
            }

            return this.width;
        }
        public double GetPerimeter() {
           return Math.Round(2*(length+width),2);
        }
        public double GetArea() { return Math.Round(length*width,2); }

    }
   
}
