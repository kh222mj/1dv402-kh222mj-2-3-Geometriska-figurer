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
                    Console.WriteLine("=======================================");
                    Console.WriteLine("=               Ellips                =");
                    Console.WriteLine("=======================================");
                    Console.ResetColor();
                    Console.WriteLine();
                    Console.Write("Ange längden: ");
                    double langdE = double.Parse(Console.ReadLine());
                    Console.Write("Ange bredden: ");
                    double breddE = double.Parse(Console.ReadLine());
                    return new Ellipse(langdE, breddE);
               
               case ShapeType.Rectangle:
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("=======================================");
                    Console.WriteLine("=              Rektangel              =");
                    Console.WriteLine("=======================================");
                    Console.ResetColor();
                    Console.WriteLine();
                    Console.Write("Ange längden: ");
                    double langdR = double.Parse(Console.ReadLine());
                    Console.Write("Ange bredden: ");
                    double breddR = double.Parse(Console.ReadLine());
                    return new Rectangle(langdR, breddR);

                default:
                    throw new NotImplementedException();
            }
        }
        private static double ReadDoubleGreaterThanZero(string prompt)
        {
            do
            {
                double index;
                
                if (double.TryParse(Console.ReadLine(), out index) && index > 0)
                {
                    return index;
                }
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("FEL! Ange ett flyttal större än 0.");
                Console.ResetColor();
                Console.WriteLine();
                Console.Write(prompt);
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
            shape.ToString();
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
            int index;
            do
            {
                Console.Clear();
                ViewMenu();
                if (int.TryParse(Console.ReadLine(), out index) && index >= 0 && index <= 2)
                {
                    switch (index) 
                    {
                        case 0:
                            break;
                        case 1:
                            CreateShape(ShapeType.Rectangle);
                            ViewShapeDetail();
                            continue; 
                        case 2:
                            CreateShape(ShapeType.Rectangle);
                            ViewShapeDetail();
                            continue;
                    }
                }
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("FEL! Ange ett nummer mellan 0 och 2.");
                Console.ResetColor(); 
            } while (true);            
        }
    }
}
