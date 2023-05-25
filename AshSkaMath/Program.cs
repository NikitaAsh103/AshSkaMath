using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyMath;

namespace AshSkaMath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберете раздел математики, где: \n1-Алгебра\n2-Геометрия\n3-Тригонометрия");
            int choice = Convert.ToInt32(Console.ReadLine());   
            switch (choice) 
            {
                case 1: 
                    int a = Convert.ToInt32(Console.ReadLine());
                    int b = Convert.ToInt32(Console.ReadLine());
                    int c = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(AlgebraClass.SquareEquation(a, b, c));
                    break;
                case 2:

                    Console.WriteLine("Выберете интересующий вас пункт, где: \n1-Площадь треугольника\n2-Площадь прямоугольного треугольника" +
                        "\n3-Площадь прямоугольника\n4-Площадь круга\n5-Площадь трапеция");
                    int secondChoice = Convert.ToInt32(Console.ReadLine());
                    switch (secondChoice)
                    {
                        case 1:
                            Console.WriteLine("Введите длину основания к которому прилегает высота:");
                            double at=Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Введите длину высоты:");
                            double ht=Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine( "Площадь треугольника = "+ GeometryClass.STriangle(at, ht));
                            break;
                        case 2:
                            Console.WriteLine("Введите длину первой стороны прилегающей к прямому углу:");
                            double apt = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Введите длину высоты:");
                            double bpt = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Площадь прямоугольного треугольника = " + GeometryClass.SPTriangle(apt, bpt));
                            break;
                        case 3:
                            Console.WriteLine("Введите длину первой стороны:");
                            double ar = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Введите длину второй стороны:");
                            double br = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Площадь прямоугольника = " + GeometryClass.SRectangle(ar, br));
                            break;
                        case 4:
                            Console.WriteLine("Введите радиус круга:");
                            double r = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Площадь прямоугольника = " + GeometryClass.SCircle(r));
                            break;
                        case 5:
                            Console.WriteLine("Введите длину первого основания:");
                            double atr = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Введите длину первого основания:");
                            double btr = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Введите высоту:");
                            double htr = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Площадь прямоугольника = " + GeometryClass.STrapezoid(atr, btr, htr));
                            break;

                    }
                    break;
                case 3:
                    break;
            }
            Console.ReadKey();
        }
    }
}
