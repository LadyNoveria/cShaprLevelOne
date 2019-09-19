using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_1
{
    class Program
    {
        /// <summary>
        /// Нахождение минимума функции
        /// </summary>
        /// <param name="x1">нижняя граница отрезка</param>
        /// <param name="x2">верхняя граница отрезка</param>
        /// <param name="step">шаг изменения</param>
        /// <param name="values">массив значений функции</param>
        /// <returns></returns>
        private static string findMin(double x1, double x2, double step, List<double> values)
        {
            //находим минимальное значение всех нечетных элементов массива (по y)
            double min = values[1];
            for (int i = 0; i < values.Count; i++)
            {
                if (i % 2 != 0)
                {
                    if (values[i] < min)
                        min = values[i];
                }
            }
            //записываем в строку значения точки (x, y)
            string result = "";
            for (int i = 1; i < values.Count; i++)
            {
                if (i % 2 != 0 && values[i] == min)
                {
                    result = $"{values[i - 1]}, {values[i]}";
                    break;
                }
            }

            return result;
        }

        /// <summary>
        /// Функция 2x^3 - 4x^2 + 6x
        /// </summary>
        /// <param name="x1">нижняя граница отрезка</param>
        /// <param name="x2">верхняя граница отрезка</param>
        /// <param name="step">шаг изменения</param>
        /// <returns></returns>
        static string functionA(double x1, double x2, double step)
        {
            List<double> values = new List<double>();
            for (double i = x1; i <= x2; i += step)
            {
                double tmp = (2 * Math.Pow(i, 3)) - (4 * Math.Pow(i, 2)) + (6 * i);
                values.Add(i);
                values.Add(tmp);
            }

            //Вывод получившегося массива на экран
            Console.Write($"Точки функции: ");
            for (int i = 0; i < values.Count; i++)
            {
                Console.Write($"{values[i]} ");
            }

            string result = findMin(x1, x2, step, values);
            return result;
        }

        /// <summary>
        /// Функция 6x^2 - 5x
        /// </summary>
        /// <param name="x1">нижняя граница отрезка</param>
        /// <param name="x2">верхняя граница отрезка</param>
        /// <param name="step">шаг изменения</param>
        /// <returns></returns>
        static string functionB(double x1, double x2, double step) {
            List<double> values = new List<double>();
            //заполняем массив точками функции (x, y)
            for (double i = x1; i <= x2; i += step)
            {
                double tmp = (6 * Math.Pow(i, 2)) - (5 * i);
                values.Add(i);
                values.Add(tmp);
            }

            //Вывод получившегося массива на экран
            Console.Write($"Точки функции: ");
            for (int i = 0; i < values.Count; i++)
            {
                Console.Write($"{values[i]} ");
            }

            string result = findMin(x1, x2, step, values);
            return result;
        }

        /// <summary>
        /// Функция 4x^2
        /// </summary>
        /// <param name="x1">нижняя граница отрезка</param>
        /// <param name="x2">верхняя граница отрезка</param>
        /// <param name="step">шаг изменения</param>
        /// <returns></returns>
        static string functionC(double x1, double x2, double step)
        {
            List<double> values = new List<double>();
            //заполняем массив точками функции (x, y)
            for (double i = x1; i <= x2; i += step)
            {
                double tmp = (4 * Math.Pow(i, 2));
                values.Add(i);
                values.Add(tmp);
            }

            //Вывод получившегося массива на экран
            Console.Write($"Точки функции: ");
            for (int i = 0; i < values.Count; i++)
            {
                Console.Write($"{values[i]} ");
            }

            string result = findMin(x1, x2, step, values);
            return result;
        }

        /// <summary>
        /// Функция 3x
        /// </summary>
        /// <param name="x1">нижняя граница отрезка</param>
        /// <param name="x2">верхняя граница отрезка</param>
        /// <param name="step">шаг изменения</param>
        /// <returns></returns>
        static string functionD(double x1, double x2, double step) {
            List<double> values = new List<double>();
            for (double i = x1; i <= x2; i += step)
            {
                double tmp = (3 * i);
                values.Add(i);
                values.Add(tmp);
            }

            //Вывод получившегося массива на экран
            Console.Write($"Точки функции: ");
            for (int i = 0; i < values.Count; i++)
            {
                Console.Write($"{values[i]} ");
            }

            string result = findMin(x1, x2, step, values);
            return result;
        }

        delegate string Function(double x1, double x2, double step);

        static void Main(string[] args)
        {
            //Вяльшина Вероника
            /*2. Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
            а) Сделайте меню с различными функциями и предоставьте пользователю выбор, для какой функции и на каком отрезке находить минимум.*/

            Function function;
            int f = functionSelection();
            switch (f)
            {
                case 1:
                    Console.WriteLine("Вы выбрали функцию y = 2x^3 - 4x^2 + 6x");
                    function = new Function(functionA);
                    break;
                case 2:
                    Console.WriteLine("Вы выбрали функцию y = 6x^2 - 5x");
                    function = new Function(functionB);
                    break;
                case 3:
                    Console.WriteLine("Вы выбрали функцию y = 4x^2");
                    function = new Function(functionC);
                    break;
                case 4:
                    Console.WriteLine("Вы выбрали функцию y = 3x");
                    function = new Function(functionD);
                    break;
                default:
                    Console.WriteLine("Вы ничего не выбрали. Будет показана работа функции y=2x^3 - 4x^2 + 6x");
                    function = new Function(functionA);
                    break;
            }

            double x1 = inputValue("x1", out x1);
            double x2 = inputValue("x2", out x2);
            double step = inputValue("step", out step);
            string result = function(x1, x2, step);
            Console.WriteLine();
            Console.WriteLine($"Минимум функции в точке: {result}");


            Pause();
        }
        /// <summary>
        /// Ввод значений
        /// </summary>
        /// <param name="str"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public static double inputValue(string str, out double val)
        {
            Console.Write($"Введите значение {str}: ");
            val = inputCheckDouble();
            return val;
        }

        /// <summary>
        /// Задержка экрана
        /// </summary>
        public static void Pause()
        {
            Console.ReadKey();
        }

        /// <summary>
        /// Меню для пользователя - выбор функции
        /// </summary>
        /// <returns></returns>
        public static int functionSelection() {
            Console.WriteLine("Для выбора функции y = 2x^3 - 4x^2 + 6x нажмите 1");
            Console.WriteLine("Для выбора функции y = 6x^2 - 5x нажмите 2");
            Console.WriteLine("Для выбора функции y = 4x^2 нажмите 3");
            Console.WriteLine("Для выбора функции y = 3x нажмите 4");
            return inputCheck();
        }
        /// <summary>
        /// Проверка ввода double
        /// </summary>
        /// <returns></returns>
        public static double inputCheckDouble()
        {
            bool flag;
            double temp;

            do
            {
                flag = double.TryParse(Console.ReadLine(), out temp);
                if (!flag) Console.WriteLine("Неверный формат ввода. Введите число типа 0,00.");
            } while (!flag);

            return temp;
        }

        /// <summary>
        /// Проверка ввода int
        /// </summary>
        /// <returns></returns>
        public static int inputCheck()
        {
            bool flag;
            int temp;

            do
            {
                flag = int.TryParse(Console.ReadLine(), out temp);
                if (!flag) Console.WriteLine("Неверный формат ввода. Введите целое число.");
            } while (!flag);

            return temp;
        }
    }
}
