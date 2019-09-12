using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вяльшина Вероника
            /*1. Дан целочисленный массив из 20 элементов. Элементы массива могут принимать целые значения 
             * от –10 000 до 10 000 включительно. Написать программу, позволяющую найти и вывести количество 
             * пар элементов массива, в которых хотя бы одно число делится на 3. В данной задаче под парой 
             * подразумевается два подряд идущих элемента массива. Например, для массива из пяти элементов: 
             * 6; 2; 9; –3; 6 – ответ: 4.*/

            string pairs = "";
            Console.Write("Введите размер массива: ");
            int n = inputCheck();
            int[] array = fillArray(n, -10000, 10000);
            Console.Write("Массив: ");
            Print(array);
            int count = pairSearch(array, ref pairs);
            output(pairs, count);

            Pause();
        }

        /// <summary>
        /// Заполнение массива случайными целыми числами
        /// </summary>
        /// <param name="n">размер массива</param>
        /// <param name="min">нижняя граница допустимых значений</param>
        /// <param name="max">верхняя граница допустимых значений</param>
        /// <returns></returns>
        static int[] fillArray(int n, int min = 0, int max = 10) {
            Random random = new Random();
            int[] array = new int[n];
            for (int i = 0; i < n; i++) {
                array[i] = random.Next(min, max);
            }
            return array;
        }

        /// <summary>
        /// Задержка экрана
        /// </summary>
        public static void Pause()
        {
            Console.ReadKey();
        }
        /// <summary>
        /// Проверка ввода
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
        /// <summary>
        /// Вывод элементов массива на экран
        /// </summary>
        /// <param name="array">массив</param>
        static void Print(int[] array) {
            foreach (int x in array) {
                Console.Write(x + " ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Поиск пар элементов массива, в которых хотя бы одно число делится на 3
        /// </summary>
        /// <param name="array">массив</param>
        /// <param name="pairs">строка для записи найденных элементов массива</param>
        /// <returns></returns>
        static int pairSearch(int[] array, ref string pairs)
        {
            int count = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] % 3 == 0 || array[i + 1] % 3 == 0)
                {
                    count++;
                    pairs = pairs + array[i] + " " + array[i + 1] + ";";
                }
            }
            return count;
        }
        /// <summary>
        /// Вывод результатов на экран
        /// </summary>
        /// <param name="pairs">пары</param>
        /// <param name="count">количество пар</param>
        private static void output(string pairs, int count)
        {
            Console.WriteLine("Количество пар: " + count);
            string[] numbers = pairs.Split(';');
            Console.WriteLine("Пары:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}

