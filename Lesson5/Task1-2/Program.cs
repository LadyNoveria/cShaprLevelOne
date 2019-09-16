using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вяльшина Вероника
            /*1. Создать программу, которая будет проверять корректность ввода логина. Корректным логином будет строка 
             * от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
               б) с использованием регулярных выражений.*/

            string login = inputLogin();
            bool check = checkLogin(login);
            if (!check) Console.WriteLine("Некорректный логин!");
            else Console.WriteLine("Все ок!");
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
        /// Ввод пароля
        /// </summary>
        /// <returns></returns>
        public static string inputLogin()
        {
            Console.Write("Введите логин (от 2 до 10 символов, только буквы латинского алфавита или цифры, цифра не может быть первой): ");
            string login = Console.ReadLine();
            return login;
        }

        /// <summary>
        /// Проверка введённого логина на соответствие требованиям
        /// </summary>
        /// <param name="login">веддённый логин</param>
        /// <returns></returns>
        public static bool checkLogin(string login)
        {
            string pattern = @"^[a-zA-Z][a-zA-Z0-9]{2,10}$";
            Regex regex = new Regex(pattern);

            if (regex.IsMatch(login))
                return true;
            else
                return false;
        }
    }
}
