using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriskaFigurer
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                ViewMenu();

                switch (Console.ReadLine())
                {
                    case "0":
                        return;

                    case "1":
                        Shape shapeElippse = CreateShape(ShapeType.Ellipse);
                        ViewShapeDetail(shapeElippse);
                        break;

                    case "2":
                        Shape shapeRectangle = CreateShape(ShapeType.Rectangle);
                        ViewShapeDetail(shapeRectangle);
                        break;

                    default:
                        Console.WriteLine();
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(" FEL! Ange ett nummer mellan 0 och 2.");
                        Console.ResetColor();
                        break;
                }

                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.CursorVisible = false;
                Console.WriteLine("   Tryck tangent för att fortsätta");
                Console.ResetColor();
                Console.ReadKey(true);
                Console.CursorVisible = true;
            }
        }

        private static Shape CreateShape(ShapeType shapeType)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine("=======================================");
            if (shapeType == ShapeType.Ellipse)
            {
                Console.WriteLine("=               Ellips                =");
            }
            else
            {
                Console.WriteLine("=              Rektangel              =");
            }
            Console.WriteLine("=======================================");
            Console.ResetColor();
            Console.WriteLine();
            double langd = ReadDoubleGreaterThanZero(" Ange längden: ");
            double bredd = ReadDoubleGreaterThanZero(" Ange bredden: ");
            if (shapeType == ShapeType.Ellipse) 
            {
                return new Ellipse(langd, bredd);
            }
            else
            {
                return new Rectangle(langd, bredd);
            }
        }
        private static double ReadDoubleGreaterThanZero(string prompt)
        {
            do
            {
                Console.Write(prompt); 
                double index;
                if (double.TryParse(Console.ReadLine(), out index) && index > 0)
                {
                    return index;
                }
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("FEL! Ange ett flyttal större än 0.");
                Console.ResetColor();
                Console.WriteLine();                        
            } while (true);           
        }
        private static void ViewMenu()
        {
            Console.Clear();
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
            Console.Write(" Ange menyval [0-2]: ");
        }
        private static void ViewShapeDetail(Shape shape)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("=======================================");
            Console.WriteLine("=              Detaljer               =");
            Console.WriteLine("=======================================");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine(shape.ToString());
            Console.WriteLine();
            Console.WriteLine("=======================================");
        }
    }
}