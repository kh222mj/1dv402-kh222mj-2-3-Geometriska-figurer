using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriskaFigurer
{
    class Program
    {
        private static Shape CreateShape(ShapeType shapeType)
        {
                     
            switch (shapeType) 
            {
                case ShapeType.Rectangle:
                    return new Rectangle();

                case ShapeType.Ellipse:
                    return new Shape();
            }

            string LangdText = "Ange längden: ";
            string BreddText = "Ange bredden: ";
            double langd;
            double bredd;

            langd = ReadDoubleGreaterThanZero(LangdText);
            bredd = ReadDoubleGreaterThanZero(BreddText);
        }
        private static double ReadDoubleGreaterThanZero(string prompt)
        {
            do
            {
                double index;
                Console.Write(prompt);
                if (double.TryParse(Console.ReadLine(), out index) && index > 0)
                {
                    return index;
                }
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("FEL! Ange ett flyttal större än 0.");
                Console.ResetColor();
                Console.WriteLine();               
            } while (true);           
        }
        private static void ViewMenu()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("=======================================");
            Console.WriteLine("=                                     =");
            Console.WriteLine("=         Geometriska Figurer         =");
            Console.WriteLine("=                                     =");
            Console.WriteLine("=======================================");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine(" 0. Avsluta.");
            Console.WriteLine(" 1. Ellips.");
            Console.WriteLine(" 2. Rektangel.");
            Console.WriteLine("=======================================");
            Console.WriteLine();
            Console.Write(" Ange menyval [0-2]:");
        }
        private static void ViewShapeDetail(Shape shape)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("=======================================");
            Console.WriteLine("=         Geometriska Figurer         =");
            Console.WriteLine("=======================================");
            Console.ResetColor();
            Console.WriteLine();
            shape.ToString();
            Console.WriteLine();
            Console.WriteLine("=======================================");        
        }
        static void Main(string[] args)
        {
            ViewMenu();
        }
    }
}
