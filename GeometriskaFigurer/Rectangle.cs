using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriskaFigurer
{
    class Rectangle : Shape
    {
        public abstract double Area
        {
            get { return Area; }
            set
            {
                Area = Length * Width;
            }
        }
        public abstract double Perimeter
        {
            get { return Perimeter;}
            set 
            {
                Perimeter = 2 * Length + 2 * Width;             
            }
        }
        public Rectangle(double length, double width) 
            :base(length, width)
        {
        }
    }
}
