using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp41
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ведите координаты точки по Х");
            bool ok = false;
            double X_Coordinat = 0;
            do
            {
                string buf = Console.ReadLine();
                ok = double.TryParse(buf, out X_Coordinat);
                if (!ok) Console.WriteLine("Нужно вводить вещественные числа");
                
            }while(!ok);
            ok = false;
            Console.WriteLine("Введите коорднаты точки по Y");
            double Y_Coordinat = 0;
            do
            {
                string buf = Console.ReadLine();
                ok = double.TryParse(buf, out Y_Coordinat);
                if (!ok) Console.WriteLine("Нужно вводить вещественные числа");

            } while (!ok);
            Console.WriteLine("Координаты точки({0};{1})",X_Coordinat,Y_Coordinat);
            bool Anser = false;
            if ((X_Coordinat * X_Coordinat + Y_Coordinat * Y_Coordinat <= 1) && ((-1) * X_Coordinat / 2) + Y_Coordinat < 0) Anser = true;
           if (Anser) Console.WriteLine("Точка принадлежит заштрихованой области") ;
            else Console.WriteLine("Точка  не принадлежит заштрихованой области");
            Console.Read();
        }
    }
}
