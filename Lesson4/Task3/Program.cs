using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    #region struct Account
    struct Account {
        string Login;
        string Password;

        /// <summary>
        /// Присвоить значение переменной Login
        /// </summary>
        /// <param name="login"></param>
        public void setLogin(string login) {
            Login = login; 
        }

        /// <summary>
        /// Присвоить значение переменной Password
        /// </summary>
        /// <param name="password"></param>
        public void setPassword(string password)
        {
            Password = password;
        }

        /// <summary>
        /// Получить значение переменной Login
        /// </summary>
        /// <returns></returns>
        public string getLogin() {
            return Login;
        }

        /// <summary>
        /// Получить значение переменной Password
        /// </summary>
        /// <returns></returns>
        public string getPaswd() {
            return Password;
        }
    }

        #endregion


        class Program
    {
        static void Main(string[] args)
        {
            //Вяльшина Вероника
            /*3. Решить задачу с логинами из предыдущего урока, только логины и пароли считать из файла в массив. 
             * Создайте структуру Account, содержащую Login и Password.*/

            /*Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. 
             * На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
             * Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа 
             * пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.*/

            string[] logins = getAuth("..\\..\\logins.txt"); //читаем массив с логинами
            string[] paswd = getAuth("..\\..\\paswd.txt"); //читаем массив с паролями
            Account a = new Account();
            authorization(logins, paswd, a);

            Pause();

        }

        /// <summary>
        /// Авторизация
        /// </summary>
        /// <param name="logins">массив логинов</param>
        /// <param name="paswd">массив паролей</param>
        /// <param name="a">экземпляр структуры Account</param>
        private static void authorization(string[] logins, string[] paswd, Account a)
        {
            for (int i = 0; i < logins.Length; i++)
            {
                bool check = checkLoginPaswd(logins[i], paswd[i]);
                if (check)
                {
                    Console.Write("Вы авторизованы.");
                    a.setLogin(logins[i]);
                    a.setPassword(paswd[i]);
                    Console.WriteLine($"Логин: {a.getLogin()} Пароль: {a.getPaswd()}");
                }
                if (i == logins.Length - 1 && !check) {
                    Console.WriteLine("Неверные логин или пароль. Количество попыток закончилось. Попробуйте позже.");
                }
            }
        }

        /// <summary>
        /// Заполнение массива из файла
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string[] getAuth(string path) {
            StreamReader sr = new StreamReader(path);
            int N = int.Parse(sr.ReadLine());
            string[] auth = new string[N];
            for (int i = 0; i < N; i++)
            {
                auth[i] = sr.ReadLine();
            }
            sr.Close();
            return auth;
        }

        /// <summary>
        /// Проверка логина и пароля из массивов на совпадение
        /// </summary>
        /// <param name="logins">элемент массива logins</param>
        /// <param name="passwords">элемент массива paswd</param>
        /// <returns></returns>
        public static bool checkLoginPaswd(string logins, string passwords)
        {
            string login = "root";
            string password = "GeekBrains";
            int amt = 3; //общее количество попыток
            int count = 0;
            do
            {
                if (logins.Equals(login) && passwords.Equals(password))
                    return true;
                else
                    count++;
            }
            while (count < amt);
            return false;
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
