using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriskaFigurer
{
    class Rectangle : Shape
    {
        public override double Area { get; }
        public override double Perimeter { get; }
        public Rectangle(double length, double width) 
            :base(length, width)
        {
            Length = length;
            Width = width;
        }
    }
}
