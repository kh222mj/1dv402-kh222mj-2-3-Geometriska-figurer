using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriskaFigurer
{
    class Ellipse : Shape
    {
        public override double Area 
        { get;
 
        }
        public override double Perimeter
        {
            get { return Perimeter; }
            set 
            {              
                double a;
                double b;
                a = Length / 2;
                b = Width / 2;
                double perimeter = Math.PI * Math.Sqrt(2 * a * a + 2 * b * b);
            }
        }
        public Ellipse(double length, double width) 
            :base(length, width)
        {
            Length = length;
            Width = width;
        }
    }
}
