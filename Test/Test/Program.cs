using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Входные данные
            double x, y, r1, r2;
            Console.Write("Введите координату x: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату y: ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите радиус окружности r1: ");
            r1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите радиус окружности r2: ");
            r2 = Convert.ToDouble(Console.ReadLine());
            // Расстояние от центра до точки
            double distance = Math.Sqrt(x * x + y * y);
            // Проверка условий и вывод результата
            if (distance < r1)
            {
                Console.WriteLine("Точка лежит внутри области");
            }
            else if (distance > r2)
            {
                Console.WriteLine("Точка лежит вне области");
            }
            else
            {
                Console.WriteLine("Точка лежит на границе области");
            }
            Console.ReadLine();
        }
    }
}