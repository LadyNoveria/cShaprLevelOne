using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static double functionA(double a, double x) { return a * Math.Pow(x, 2); }
        static double functionB(double a, double x) { return a * Math.Asin(x); }

        delegate double Function(double a, double x);

        static void Main(string[] args)
        {
            //Вяльшина Вероника
            /*1. Изменить программу вывода таблицы функции так, чтобы можно было передавать функции 
             * типа double (double, double). Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).*/

            Function func = new Function(functionA);
            workWithFunction(func);
            func += functionB;
            workWithFunction(func);

            Pause();
        }

        /// <summary>
        /// Работы с функцией
        /// </summary>
        /// <param name="func"></param>
        private static void workWithFunction(Function func)
        {
            double a = inputValue("a", out a);
            double x = inputValue("x", out x);
            double result = func(a, x);
            Console.WriteLine($"Result: {result}");
        }

        /// <summary>
        /// Задержка экрана
        /// </summary>
        public static void Pause() {
            Console.ReadKey();
        }

        /// <summary>
        /// Ввод значений
        /// </summary>
        /// <param name="str"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public static double inputValue(string str, out double val)
        {
            Console.WriteLine($"Введите значение {str}: ");
            val = inputCheck();
            return val;
        }

        /// <summary>
        /// Проверка корректности ввода
        /// </summary>
        /// <returns></returns>
        public static double inputCheck()
        {
            bool flag;
            double temp;

            do
            {
                flag = double.TryParse(Console.ReadLine(), out temp);
                if (!flag) Console.WriteLine("Неверный формат ввода. Введите целое число.");
            } while (!flag);

            return temp;
        }
    }
}
