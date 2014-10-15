using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriskaFigurer
{
    class Ellipse : Shape
    {
        public double Area
        {
            get { return Area; }
            set 
            {
                double a;
                double b;
                a = Length / 2;
                b = Width / 2;
                Area = Math.PI * a * b;
            }
        }
        public double Perimeter
        {
            get { return Perimeter; }
            set 
            {
                double a;
                double b;
                a = Length / 2;
                b = Width / 2;
                Perimeter = Math.PI * Math.Sqrt(2 * a * a + 2 * b *  b);
            }
        }
        public Ellipse(double length, double width) 
            :base(length, width)
        {
        }
    }
}
