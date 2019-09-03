using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Аuthentication
    {
        static void Main(string[] args)
        {
            //Вероника Вяльшина
            /*4. Реализовать метод проверки логина и пароля. На вход подается логин и пароль. 
             * На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
             * Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, 
             * программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля 
             * тремя попытками.*/

            if (checkLoginPaswd())
                Console.Write("Вы авторизованы.");
            else
                Console.Write("Введены неверные данные. Количество попыток закончилось. Попробуйте позже.");

            Console.ReadKey();
        }

        public static bool checkLoginPaswd() {
            string login = "root";
            string password = "GeekBrains";
            int amt = 3; //общее количество попыток
            int count = 0;
            do
            {
                Console.Write("Введите Ваш логин: ");
                string enteredLogin = Console.ReadLine();
                Console.Write("Введите Ваш пароль: ");
                string enteredPaswd = Console.ReadLine();
                if(enteredLogin.Equals(login) && enteredPaswd.Equals(password))
                    return true;
                else {
                    Console.WriteLine("Неверно введен логин или пароль. Попробуйте еще раз!");
                    count++;
                    Console.WriteLine("Оставшееся число попыток: " + (amt - count));
                }
            }
            while (count < amt);
            return false;
        }
    }
}
