using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMath
{
    public static class AlgebraClass
    {
        //Корни квадратного уравнения
        public static string SquareEquation(int a, int b, int c) 
        {
            int d = b * b - 4 * a * c;
            int sqd= (int)Math.Sqrt(d);
            double x1 = (-b - sqd) / 2;
            double x2 = (-b + sqd) / 2;
            
            string end = Convert.ToString(x1);
            end += " " + Convert.ToString(x2);
            
            return end;
        }
        //Корни линейного уравнения
        //Сумма ряда
        //Максимальное значение
        //Среднее значение

    }
}
