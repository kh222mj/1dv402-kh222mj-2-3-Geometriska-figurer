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
               case ShapeType.Ellipse:
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    Console.WriteLine("=======================================");
                    Console.WriteLine("=               Ellips                =");
                    Console.WriteLine("=======================================");
                    Console.ResetColor();
                    Console.WriteLine();
                    double langdE = ReadDoubleGreaterThanZero(" Ange längden: ");
                    double breddE = ReadDoubleGreaterThanZero(" Ange bredden: ");
                    return new Ellipse(langdE, breddE);
               
               case ShapeType.Rectangle:
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    Console.WriteLine("=======================================");
                    Console.WriteLine("=              Rektangel              =");
                    Console.WriteLine("=======================================");
                    Console.ResetColor();
                    Console.WriteLine();
                    double langdR = ReadDoubleGreaterThanZero(" Ange längden: ");
                    double breddR = ReadDoubleGreaterThanZero(" Ange bredden: ");                  
                    Console.WriteLine();
                    return new Rectangle(langdR, breddR);

                default:
                    throw new NotImplementedException();
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
            Console.WriteLine();
            Console.CursorVisible = false;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("  Tryck tangent för att fortsätta  ");
            Console.ReadKey(true);
            Console.ResetColor();
            Console.CursorVisible = true;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                int index;               
                do
                {
                    Console.Clear();
                    ViewMenu();
                    if (int.TryParse(Console.ReadLine(), out index) && index >= 0 && index <= 2)
                    {
                        break;
                    }
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(" FEL! Ange ett nummer mellan 0 och 2.");
                    Console.ResetColor();
                    Console.WriteLine();
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("   Tryck tangent för att fortsätta");
                    Console.ResetColor();
                    Console.ReadKey(true);
                } while (true);
                switch (index)
                {
                    case 0:                   
                        return;
                    case 1:
                        Shape shapeElippse = CreateShape(ShapeType.Ellipse);
                        ViewShapeDetail(shapeElippse);
                        continue;
                    case 2:
                        Shape shapeRectangle = CreateShape(ShapeType.Rectangle);
                        ViewShapeDetail(shapeRectangle);
                        continue;
                }
            }
        }
    }
}