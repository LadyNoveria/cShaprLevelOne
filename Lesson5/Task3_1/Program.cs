using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вяльшина Вероника
            /*3. *Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой. Регистр можно не учитывать:
            а) с использованием методов C#;
            Например:
            badc являются перестановкой abcd.*/

            string str1 = inputStr();
            string str2 = inputStr();
            //перевод обеих строк в нижний регистр и сортировка символов в обеих по возрастанию
            if (str1.ToLower().OrderBy(i => i).SequenceEqual(str2.ToLower().OrderBy(i => i)))
                Console.WriteLine("Одна строка является перестановкой другой");
            else
                Console.WriteLine("Строки разные");

            Pause();

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
