using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class DistanceCalc
    {
        static void Main(string[] args)
        {
            /*а) Написать программу, которая подсчитывает расстояние между точками с 
             * координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). 
             * Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
            б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.*/
            Console.Write("Введите координату x1: ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату y1: ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату x2: ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату y2: ");
            int y2 = Convert.ToInt32(Console.ReadLine());

            //Решение без применения метода
            //double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            //Решение с применением метода
            double r = DistCalc(x1, y1, x2, y2);

            Console.WriteLine(String.Format("Расстояние между точками r = {0:0.00}", r));

            Console.ReadKey();
        }

        public static double DistCalc(int x1, int y1, int x2, int y2) {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}
