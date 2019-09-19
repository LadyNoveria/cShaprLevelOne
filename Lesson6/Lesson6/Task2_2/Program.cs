using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_2
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
        static string functionB(double x1, double x2, double step)
        {
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
        static string functionD(double x1, double x2, double step)
        {
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

        delegate string Function1(double x1, double x2, double step);
        delegate string Function2(double x1, double x2, double step);

        static void Main(string[] args)
        {
            //Вяльшина Вероника
            /*2. Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
            б) Используйте массив (или список) делегатов, в котором хранятся различные функции.*/
            List<Function1> values1 = new List<Function1>();
            values1.Add(functionA);
            values1.Add(functionB);
            List<Function2> values2 = new List<Function2>();
            values2.Add(functionC);
            values2.Add(functionD);
            double x1, x2, step;

            int f = functionSelection();
            switch (f)
            {
                case 1:
                    Console.WriteLine("Вы выбрали функцию y = 2x^3 - 4x^2 + 6x");
                    Function1 func1 = new Function1(values1[0]);
                    setSegment(out x1, out x2, out step);
                    minFunc1(x1, x2, step, func1);
                    break;
                case 2:
                    Console.WriteLine("Вы выбрали функцию y = 6x^2 - 5x");
                    func1 = new Function1(values1[1]);
                    setSegment(out x1, out x2, out step);
                    minFunc1(x1, x2, step, func1);
                    break;
                case 3:
                    Console.WriteLine("Вы выбрали функцию y = 4x^2");
                    Function2 func2 = new Function2(values2[0]);
                    setSegment(out x1, out x2, out step);
                    minFunc2(x1, x2, step, func2);
                    break;
                case 4:
                    Console.WriteLine("Вы выбрали функцию y = 3x");
                    func2 = new Function2(values2[1]);
                    setSegment(out x1, out x2, out step);
                    minFunc2(x1, x2, step, func2);
                    break;
                default:
                    Console.WriteLine("Вы ничего не выбрали. Будет показана работа функции y=2x^3 - 4x^2 + 6x");
                    func1 = new Function1(values1[0]);
                    setSegment(out x1, out x2, out step);
                    minFunc1(x1, x2, step, func1);
                    break;
            }


            Pause();
        }

        /// <summary>
        /// Выбор отрезка и шага для нахождения точек функции
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="x2"></param>
        /// <param name="step"></param>
        private static void setSegment(out double x1, out double x2, out double step)
        {
            x1 = inputValue("x1", out x1);
            x2 = inputValue("x2", out x2);
            step = inputValue("step", out step);
        }

        /// <summary>
        /// ВЫвод минимума функции для делегата Function1
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="x2"></param>
        /// <param name="step"></param>
        /// <param name="func"></param>
        private static void minFunc1(double x1, double x2, double step, Function1 func)
        {
            string result = func(x1, x2, step);
            Console.WriteLine();
            Console.WriteLine($"Минимум функции в точке: {result}");
        }
        /// <summary>
        /// ВЫвод минимума функции для делегата Function2
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="x2"></param>
        /// <param name="step"></param>
        /// <param name="func"></param>
        private static void minFunc2(double x1, double x2, double step, Function2 func)
        {
            string result = func(x1, x2, step);
            Console.WriteLine();
            Console.WriteLine($"Минимум функции в точке: {result}");
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
        public static int functionSelection()
        {
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
