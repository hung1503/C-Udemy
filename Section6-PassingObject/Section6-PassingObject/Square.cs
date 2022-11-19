using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section6_PassingObject
{
    internal class Square
    {
        private double area;
        private double length;

        public Square(double length)
        {
            this.length = length;
            this.area = SquareArea(length);
        }

        public double Area
        {
            get
            {
                return area;
            }
        }

        public double Length
        {
            get
            {
                return length;
            }
        }

        private double SquareArea(double length)
        {
            return length * length;
        }
    }
}
