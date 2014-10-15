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
            double langd;
            double bredd;
            string Langd = "Ange längden: ";
            string Bredd = "Ange bredden: ";
            Console.Write(Langd);
            langd = double.Parse(Console.ReadLine());
            if (langd < 0) 
            {
                ReadDoubleGreaterThanZero(Langd);
            }
            Console.Write(Bredd);
            bredd = double.Parse(Console.ReadLine());
            if (bredd < 0) 
            {
                ReadDoubleGreaterThanZero(Bredd);
            }
            if (shapeType == 0) 
            {
                return Shape;
            }
            
        }
        private static double ReadDoubleGreaterThanZero(string prompt)
        {
            do
            {
                double index;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("FEL! Ange ett flyttal större än 0.");
                Console.ResetColor();
                Console.WriteLine();
                Console.Write(prompt);
                if (double.TryParse(Console.ReadLine(), out index) && index > 0)
                {
                    return index;
                }
                
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
