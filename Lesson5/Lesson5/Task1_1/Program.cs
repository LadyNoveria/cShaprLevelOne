using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вяльшина Вероника
            /*1. Создать программу, которая будет проверять корректность ввода логина. Корректным логином будет строка от 2 до 10 символов, 
             * содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
            а) без использования регулярных выражений;*/

            string login = inputLogin();
            bool check = checkLogin(login);
            if (!check) Console.WriteLine("Некорректный логин!");
            else Console.WriteLine("Все ок!");
            Pause();
        }

        /// <summary>
        /// Задержка экрана
        /// </summary>
        public static void Pause(){
            Console.ReadKey();
        }

        /// <summary>
        /// Ввод пароля
        /// </summary>
        /// <returns></returns>
        public static string inputLogin() {
            Console.Write("Введите логин (от 2 до 10 символов, только буквы латинского алфавита или цифры, цифра не может быть первой): ");
            string login = Console.ReadLine();
            return login;
        }

        /// <summary>
        /// Проверка введённого логина на соответствие требованиям
        /// </summary>
        /// <param name="login">веддённый логин</param>
        /// <returns></returns>
        public static bool checkLogin(string login) {

            char[] letters = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};
            //проверка на длину введенного логина
            if (login.Length < 2 || login.Length > 10)
                return false;

            //проверка на содержание логина (латинский алфавит и цифры)
            int count = 0;
            foreach (char x in login) {
                for (int i = 0; i < letters.Length; i++) {
                    if ((x == letters[i]))
                        count++;
                }
            }
            if (count < login.Length)
                return false;

            //проверка на первый символ введённого логина
            count = 0;
            for (int i = 25; i < letters.Length; i++) {
                if (login[0] == letters[i])
                    count++;
            }
            if (count > 0)
                return false;

            return true;
        }
    }
}
