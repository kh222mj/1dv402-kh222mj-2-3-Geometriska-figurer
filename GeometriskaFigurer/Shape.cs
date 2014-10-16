using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriskaFigurer
{
    public enum ShapeType { Avsluta, Rectangle, Ellipse };
    abstract class Shape
    {
        private double _length;
        private double _width;
        public abstract double Area { get; }
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
        public abstract double Perimeter { get; }
        
        public double Width
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
            StringBuilder sb = new StringBuilder();
            sb.Append(" Längd    : ").AppendFormat("{0,10:00.00}", Length);
            sb.AppendLine();
            sb.Append(" Bredd    : ").AppendFormat("{0,10:00.00}", Width);
            sb.AppendLine();
            sb.Append(" Omkrets  : ").AppendFormat("{0,10:00.00}", Perimeter);
            sb.AppendLine();
            sb.Append(" Area     : ").AppendFormat("{0,10:00.00}", Area);
            return sb.ToString();      
        }
    }
}

// return String.Format
            //(@"Längd  : {0}"
            //+ "Bredd  : {1}"
            //+ "Omkrets: {2}"
            //+ "Area   : {3}"
            //+ Length + Width + Perimeter + Area);