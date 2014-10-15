using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriskaFigurer
{
    public enum ShapeType { Rectangle, Ellipse };
    class Shape
    {
        private double _length;
        private double _width;
        public abstract double Area 
        {
            get { return Area; }   
        }
        public double Length
        {
            get { return _length; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException();
                }
                _length = value;
            }
        }
        public abstract double Perimeter
        {
            get { return Perimeter; }
        }
        public abstract double Width
        {
            get { return _width; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException();
                }
                _width = value;
            }
        }
        protected Shape(double length, double width)
        {
            Length = length;
            Width = width;
        }
        public override string ToString()
        {
            return String.Format
            (@"Längd  : {0}"
            + "Bredd  : {1}"
            + "Omkrets: {2}"
            + "Area   : {3}"
            + Length + Width + Perimeter + Area);
        }
    }
}
