using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вяльшина Вероника
            /*7. a) Разработать рекурсивный метод, который выводит на экран числа от a до b (a<b);
            б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.*/

            Console.Write("Введите число a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int amount = 0;
            if (a < b)
                culcAmount(a, b, ref amount);
            else
                culcAmount(b, a, ref amount);

            Console.WriteLine("Сумма чисел от a до b: " + amount);
            Console.ReadKey();
        }

        public static void culcAmount(int a, int b, ref int amount) {
            amount = amount + a;
            if (a < b)
                culcAmount(a + 1, b, ref amount);
        }

    }
}
