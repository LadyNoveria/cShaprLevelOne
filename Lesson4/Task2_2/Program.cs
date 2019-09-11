using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_2
{
    #region Class MyArray
    class MyArray
    {
        int[] a;

        /// <summary>
        /// Считать массив из файла
        /// </summary>
        /// <param name="sr">поток</param>
        public MyArray(StreamReader sr)
        {
            int N = int.Parse(sr.ReadLine());
            a = new int[N];
            for (int i = 0; i < N; i++)
            {
                a[i] = int.Parse(sr.ReadLine());
            }
            sr.Close();

        }

        /// <summary>
        /// Создание массива и заполнение его одним значением el
        /// </summary>
        /// <param name="n"></param>
        /// <param name="el"></param>
        public MyArray(int n, int el)
        {
            a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = el;
        }

        /// <summary>
        /// Создание массива и заполнение его случайными числами от min до max
        /// </summary>
        /// <param name="n"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        public MyArray(int n, int min, int max)
        {
            a = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                a[i] = rnd.Next(min, max);
        }

        /// <summary>
        /// Создание массива и заполнение числами от начального значения с заданным шагом
        /// </summary>
        /// <param name="n"></param>
        public MyArray(int n)
        {
            a = new int[n];
            Console.Write("Введите начальный элемент массива: ");
            int init = Program.inputCheck();
            a[0] = init;
            Console.Write("Введите шаг изменения последующих элементов массива: ");
            int step = Program.inputCheck();

            for (int i = 1; i < n; i++)
            {
                a[i] = a[i - 1] + step;
            }
        }

        /// <summary>
        /// Запись массива в файл
        /// </summary>
        /// <param name="fileName">путь до файла</param>
        public void Filing(string fileName)
        {
            StreamWriter sw = new StreamWriter(fileName);
            for (int i = 0; i < a.Length; i++)
            {
                sw.WriteLine(a[i]);
            }

            sw.Close();
        }

        /// <summary>
        /// Поиск максимального элемента массива
        /// </summary>
        public int Max
        {
            get
            {
                int max = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] > max) max = a[i];
                return max;
            }
        }

        /// <summary>
        /// Поиск минимального элемента массива
        /// </summary>
        public int Min
        {
            get
            {
                int min = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] < min) min = a[i];
                return min;
            }
        }

        /// <summary>
        /// Количество положительных элементов массива
        /// </summary>
        public int CountPositiv
        {
            get
            {
                int count = 0;
                for (int i = 0; i < a.Length; i++)
                    if (a[i] > 0) count++;
                return count;
            }
        }

        /// <summary>
        /// Получениe элемента массива
        /// </summary>
        /// <param name="i">позиция элемента</param>
        /// <returns></returns>
        public int Get(int i)
        {
            return a[i];
        }

        /// <summary>
        /// Задание элемента массива
        /// </summary>
        /// <param name="i">позиция элемента</param>
        /// <param name="value">значение элемента</param>
        public void Set(int i, int value)
        {
            a[i] = value;
        }

        /// <summary>
        /// Получение суммы всех элементов массива
        /// </summary>
        public long Sum
        {
            get
            {
                long sum = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    sum = sum + a[i];
                }
                return sum;
            }
        }

        /// <summary>
        /// Изменение знаков элементов массива
        /// </summary>
        public void Inverse()
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < 0)
                    a[i] = Math.Abs(a[i]);
                else if (a[i] > 0)
                {
                    a[i] = a[i] * (-1);
                }
            }
        }

        /// <summary>
        /// Умножение каждого элемента массива на заданное число
        /// </summary>
        /// <param name="x">заданное число</param>
        public void Multi(int x)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = a[i] * x;
            }
        }

        /// <summary>
        /// Получение количества максимальных элементов массива
        /// </summary>
        public int MaxCount
        {

            get
            {
                int maxCount = 0;
                int max = Max;
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == max)
                        maxCount++;
                }
                return maxCount;
            }
        }

        public override string ToString()
        {
            string s = "";
            foreach (int v in a)
                s = s + v + " ";
            return s;
        }
    }

    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            //Вяльшина Вероника
            /*2. а) Дописать класс для работы с одномерным массивом. Реализовать конструктор, создающий 
             * массив заданной размерности и заполняющий массив числами от начального значения с заданным шагом. 
             * Создать свойство Sum, которые возвращают сумму элементов массива, метод Inverse, меняющий знаки у 
             * всех элементов массива, метод Multi, умножающий каждый элемент массива на определенное число, свойство 
             * MaxCount, возвращающее количество максимальных элементов. В Main продемонстрировать работу класса.
             б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.*/

            StreamReader sr = new StreamReader("..\\..\\arrayIn.txt");
            MyArray a = new MyArray(sr);
            Console.WriteLine("Элементы массива a: " + a.ToString());
            a.Filing("..\\..\\arrayTo.txt");


            Pause();
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
    }
}
