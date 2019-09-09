using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_1
{
    class InputNumbers
    {
        static void Main(string[] args)
        {
            //Вяльшина Вероника
            /*2. а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке). 
             * Требуется подсчитать сумму всех нечетных положительных чисел. Сами числа и сумму вывести 
             * на экран, используя tryParse;*/


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
        /// Вывод символов строки, с проверкой на Int и вывод суммы этих чисел
        /// </summary>
        /// <param name="str">строка символов</param>
        public static void outputString(ref string str) {
            string[] numbs = str.Split('.');
            bool flag;
            int temp, result = 0;

            if (numbs.Length == 1)
                Console.WriteLine("Нет нечетных положительных чисел");
            else { 
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
