using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_2
{
    class ExceptionChecking
    {
        static void Main(string[] args)
        {
            //Вяльшина Вероника
            /*2. а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке). 
             * Требуется подсчитать сумму всех нечетных положительных чисел. Сами числа и сумму вывести 
             * на экран, используя tryParse;
            б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные. 
            При возникновении ошибки вывести сообщение. Напишите соответствующую функцию.*/


            int number;
            string numbers = "";
            while (true)
            {
                Console.Write("Введите число: ");
                //ввод чисел с проверкой на тип
                number = inputCheck();
                if (number % 2 != 0 && number > 0)
                {
                    numbers = numbers + number + ".";
                }
                if (number == 0)
                {
                    //извлечение чисел, подходящих под условие, из строки. Вывод чисел и их суммы
                    outputString(ref numbers);
                    break;
                }
            }

            Pause();
        }

        /// <summary>
        /// Проверка ввода
        /// </summary>
        /// <returns></returns>
        public static int inputCheck()
        {
            string temp;
            bool flag = false;
            int numb = 0;
            while (!flag)
            {
                temp = Console.ReadLine();
                exceptionChecking(ref temp, ref flag, ref numb);
            }

            return numb;
        }
        /// <summary>
        /// Обработка исключений
        /// </summary>
        /// <param name="temp">введенная пользователем строка</param>
        /// <param name="flag">флаг</param>
        /// <param name="numb">числовая переменная для присваивания значения</param>
        /// <returns></returns>
        public static bool exceptionChecking(ref string temp, ref bool flag, ref int numb)
        {
            try
            {
                numb = Int32.Parse(temp);
                flag = true;
            }
            catch
            {
                Console.Write("Неверный формат ввода. Введите целое число: ");
                flag = false;
            }
            return flag;
        }

        /// <summary>
        /// Вывод символов строки, с проверкой на Int и вывод суммы этих чисел
        /// </summary>
        /// <param name="str">строка символов</param>
        public static void outputString(ref string str)
        {
            string[] numbs = str.Split('.');
            bool flag;
            int temp, result = 0;

            if (numbs.Length == 1)
                Console.WriteLine("Нет нечетных положительных чисел");
            else
            {
                for (int i = 0; i < numbs.Length; i++)
                {
                    flag = int.TryParse(numbs[i].ToString(), out temp);
                    if (flag)
                    {
                        Console.WriteLine("Нечетное положительное число: " + temp);
                        result = result + temp;
                    }
                }
                Console.WriteLine("Сумма всех нечетных положительных чисел: " + result);
            }
        }

        /// <summary>
        /// Задержка экрана
        /// </summary>
        public static void Pause()
        {
            Console.ReadKey();
        }
    }
}