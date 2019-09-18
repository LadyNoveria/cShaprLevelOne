using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вяльшина Вероника
            /*3. *Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой. Регистр можно не учитывать:
            б) *разработав собственный алгоритм.*/

            string str1 = inputStr();
            string str2 = inputStr();
            bool flag = equalityCheck(str1, str2);

            if (flag)
                Console.WriteLine("Одна строка является перестановкой другой");
            else
                Console.WriteLine("Строки разные");

            Pause();

        }

        /// <summary>
        /// проверка двух строк на равенство
        /// </summary>
        /// <param name="str1">строка 1</param>
        /// <param name="str2">строка 2</param>
        /// <returns></returns>
        public static bool equalityCheck(string str1, string str2) {
            //перевод строк в нижний регистр
            str1 = str1.ToLower();
            str2 = str2.ToLower();

            int count = 0;
            //если длины строк разные, то они точно разные
            if (str1.Length != str2.Length)
                return false;
            else {
                //сверка каждого символа первой строки с каждым символой второй строки с увеличением счетчика, если символы совпдают
                for (int i = 0; i < str1.Length; i++)
                {
                    for (int j = 0; j < str2.Length; j++)
                    {
                        if (str1[i].Equals(str2[j]))
                        {
                            count++;
                            break;
                        }
                    }
                }
                //если число совпадений равно длине строки - true
                if (count == str1.Length)
                    return true;
                else
                    return false;
            }                
        }

        /// <summary>
        /// ЗАдержка экрана
        /// </summary>
        public static void Pause()
        {
            Console.ReadKey();
        }

        /// <summary>
        /// Считывание строки из консоли
        /// </summary>
        /// <returns></returns>
        public static string inputStr()
        {
            Console.Write("Введите строку: ");
            string str = Console.ReadLine();
            return str;
        }
    }
}
