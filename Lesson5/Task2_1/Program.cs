using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task2_1
{
    #region Class Message
    class Message {
        string msg;

        public string getMsg() {
            return msg;
        }

        public Message(string msg) {
            this.msg = msg;
        }
        /// <summary>
        /// удаление слов, которые заканчиваются на заданный символ
        /// </summary>
        public void deleteWord(char ch) {
            string str1 = "";

            for (int i = 0; i < msg.Length; i++) {
                if (@".,!?-".IndexOf(msg[i]) != -1)
                    str1 += $" {msg[i]} ";
                else
                    str1 += $"{msg[i]}";
            }

            var str2 = str1.Split(' ');
            msg = "";
            foreach (var e in str2) {
                if(@".,!?-".IndexOf(e) != -1)
                    msg += $"{e}";
                else if(e != "" && e[e.Length - 1] != ch)
                    msg += $"{e} ";
            }
            //дописать
            Console.WriteLine($"msg: {msg}");
        }
        /// <summary>
        /// Вывод сообщений, содержащих не более n символов
        /// </summary> 
        /// <param name="n"></param>
        public void consoleLimInLength(int n) {
            string[] str = msg.Split(' ');
            string pattern = @"[a-zA-Z]{" + (n) + "}";
            Regex regex = new Regex(pattern);

            for (int i = 0; i < str.Length;i++)
            {
                if (regex.IsMatch(str[i]) && str[i].Length == n)
                    Console.WriteLine($">>> {str[i]}");
            }
        }
    }
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            //Вяльшина Вероника
            /*. Разработать класс Message, содержащий следующие статические методы для обработки текста:
            а) Вывести только те слова сообщения, которые содержат не более n букв.
            б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
            в) Найти самое длинное слово сообщения.
            г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
            Продемонстрируйте работу программы на текстовом файле с вашей программой.*/

            string str = inputMessage();
            Message msg = new Message(str);
            int n = inputN();
            Console.WriteLine($"msg: {msg.getMsg()}");

            msg.consoleLimInLength(n);
            char ch = inputChar();
            msg.deleteWord(ch);
            //Console.WriteLine($"msg: {msg.getMsg()}");

            Pause();
        }

        private static int inputN()
        {
            Console.Write("Введите значение для ограничения сообщений: ");
            int n = inputCheck();
            return n;
        }

        private static char inputChar()
        {
            Console.Write("Введите символ: ");
            string str = Console.ReadLine();
            char ch = str[0];
            return ch;
        }

        private static void Pause()
        {
            Console.ReadKey();
        }

        public static string inputMessage() {
            Console.Write("Введите сообщение: ");
            string str = Console.ReadLine();
            return str;
        }

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
