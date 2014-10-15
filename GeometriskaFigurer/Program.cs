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
            Console.Write("Ange längden: ");
            double length = double.Parse(Console.ReadLine());
            Console.Write("Ange bredden: ");
            double width = double.Parse(Console.ReadLine());
        }
        private static double ReadDoubleGreaterThanZero(string prompt)
        {
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
