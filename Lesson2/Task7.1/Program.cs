using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вяльшина Вероника
            /*7. a) Разработать рекурсивный метод, который выводит на экран числа от a до b (a<b);*/

            Console.Write("Введите число a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a < b)
                numOutput(a, b);
            else
                numOutput(b, a);

            Console.ReadKey();
        }

        public static void numOutput(int a, int b) {
            Console.WriteLine(a);
            if (a < b)
                numOutput(a + 1, b);
        }
    }
}
