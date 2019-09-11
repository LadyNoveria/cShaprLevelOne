using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_2
{
    #region class TwoDimensionalArray
    class TwoDimensionalArray
    {
        int[,] tdArray;

        /// <summary>
        /// Конструктор - заполнение массива рандомными значениями
        /// </summary>
        /// <param name="row">количество строк</param>
        /// <param name="col">количество столбцов</param>
        /// <param name="min">нижняя граница значений массива</param>
        /// <param name="max">верхняя граница значений массива</param>
        public TwoDimensionalArray(int row, int col, int min = -10, int max = 10)
        {
            Random random = new Random();
            tdArray = new int[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    tdArray[i, j] = random.Next(min, max);
                }
            }
        }
        /// <summary>
        /// Конструктор - заполнение массива из файла
        /// </summary>
        /// <param name="fileName">путь к файлу</param>
        /// <param name="row">количество строк</param>
        /// <param name="col">количество столбцов</param>
        public TwoDimensionalArray(string fileName, ref int row, ref int col)
        {
            StreamReader sr = new StreamReader(fileName);
            row = int.Parse(sr.ReadLine());
            col = int.Parse(sr.ReadLine());
            tdArray = new int[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    tdArray[i, j] = int.Parse(sr.ReadLine());
                }
            }
            sr.Close();
        }

        /// <summary>
        /// Получить элемент массива
        /// </summary>
        /// <param name="i">строка</param>
        /// <param name="j">столбец</param>
        /// <returns></returns>
        public int getValue(int i, int j)
        {
            return tdArray[i, j];
        }

        /// <summary>
        /// Сумма всех элементов массива
        /// </summary>
        /// <returns></returns>
        public int summ()
        {
            int sum = 0;
            for (int i = 0; i < tdArray.GetLength(0); i++)
            {
                for (int j = 0; j < tdArray.GetLength(1); j++)
                {
                    sum = sum + tdArray[i, j];
                }
            }
            return sum;
        }

        /// <summary>
        /// Сумма всех элементов массива, больше number
        /// </summary>
        /// <returns></returns>
        public int summ(int number)
        {
            int sum = 0;
            for (int i = 0; i < tdArray.GetLength(0); i++)
            {
                for (int j = 0; j < tdArray.GetLength(1); j++)
                {
                    if (tdArray[i, j] > number)
                        sum = sum + tdArray[i, j];
                }
            }
            return sum;
        }

        /// <summary>
        /// Минимальный элемент массива
        /// </summary>
        /// <returns></returns>
        public int getMin()
        {
            int min = tdArray[0, 0];
            for (int i = 0; i < tdArray.GetLength(0); i++)
            {
                for (int j = 0; j < tdArray.GetLength(1); j++)
                {
                    if (tdArray[i, j] < min)
                        min = tdArray[i, j];
                }
            }

            return min;
        }

        /// <summary>
        /// Максимальный элемент массива
        /// </summary>
        /// <returns></returns>
        public int getMax()
        {
            int max = tdArray[0, 0];
            for (int i = 0; i < tdArray.GetLength(0); i++)
            {
                for (int j = 0; j < tdArray.GetLength(1); j++)
                {
                    if (tdArray[i, j] > max)
                        max = tdArray[i, j];
                }
            }

            return max;
        }

        /// <summary>
        /// Номер максимального элемента массива
        /// </summary>
        /// <returns></returns>
        public string maxItemNumber(ref string item)
        {
            int max = getMax();
            for (int i = 0; i < tdArray.GetLength(0); i++)
            {
                for (int j = 0; j < tdArray.GetLength(1); j++)
                {
                    if (tdArray[i, j] == max)
                        item = (i + 1) + "," + (j + 1);
                }
            }
            return item;
        }

    }
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            //Вяльшина Вероника
            /*4. *а) Реализовать класс для работы с двумерным массивом. Реализовать конструктор, заполняющий массив 
             * случайными числами. Создать методы, которые возвращают сумму всех элементов массива, сумму всех элементов 
             * массива больше заданного, свойство, возвращающее минимальный элемент массива, свойство, возвращающее максимальный 
             * элемент массива, метод, возвращающий номер максимального элемента массива (через параметры, используя модификатор ref или out).
             
             *б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.*/

            int row = 0;
            int col = 0;
            TwoDimensionalArray a = new TwoDimensionalArray("..\\..\\array.txt", ref row, ref col);
            printArray(row, col, a);
            Filing("..\\..\\arrayTo.txt", a, row, col);


            Pause();
        }

        /// <summary>
        /// Запись элементов массива в файл
        /// </summary>
        /// <param name="fileName">путь к файлу</param>
        /// <param name="array">массив</param>
        /// <param name="row">количество строк</param>
        /// <param name="col">количество столбцов</param>
        public static void Filing(string fileName, TwoDimensionalArray array, int row, int col)
        {
            StreamWriter sw = new StreamWriter(fileName);

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    sw.WriteLine(array.getValue(i, j));
                }
            }

            sw.Close();
        }

        /// <summary>
        /// Вывод массива на экран
        /// </summary>
        /// <param name="row">количество строк</param>
        /// <param name="col">количество столбцов</param>
        /// <param name="a">массив</param>
        private static void printArray(int row, int col, TwoDimensionalArray a)
        {
            Console.WriteLine("Массив: ");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(a.getValue(i, j) + " ");
                }
                Console.WriteLine();
            }
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
        /// 
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
