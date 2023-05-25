using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMath
{
    public static class GeometryClass
    {
        //Площадь треугольника
        public static double STriangle(double at, double ht)
        {
            //a основание h высота
            double s = at * ht / 2;
            return s;

        }
        //Площадь прямоугольного треугольника
        public static double SPTriangle(double apt, double bpt)
        {
            //apt 1 сторона bpt 2 сторона
            double s = apt * bpt / 2;
            return s;

        }
        //Площадь прямоугольника
        public static double SRectangle(double ar, double br)
        {
            //ar 1 сторона br 2 сторона 
            double s = ar * br;
            return s;

        }
        //Площадь круга
        public static double SCircle(double r)
        {
            //r радиус
            double s = 3.14 * (r*r);
            return s;

        }
        //Площадь трапеции
        public static double STrapezoid(double atr, double btr, double htr)
        {
            //at 1 основание bt 2 основание ht ывсота
            double s = (atr + btr) / 2 * htr;
            return s;

        }


    }
}
