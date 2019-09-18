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
        /// Формирование строки самых длинных слов с помощью StringBuilder
        /// </summary>
        /// <returns></returns>
        public StringBuilder stringOfLongestWords() {
            StringBuilder strmax = new StringBuilder();
            string[] max = findLongestWord();
            for (int i = 0; i < max.Length; i++) {
                strmax.Append($"{max[i]} ");
            }

            return strmax;
        }

        /// <summary>
        /// Нахождение самого длинного слова в строке
        /// </summary>
        /// <returns></returns>
        public string[] findLongestWord()
        {
            string str1 = NewLineForming();
            string[] str2 = str1.Split(' ');
            string tmp = str2[0];
            for (int i = 0; i < str2.Length; i++)
            {
                if (str2[i].Length > tmp.Length) tmp = str2[i];
            }
            string[] max = new string[0];
            for (int i = 0; i < str2.Length; i++)
            {
                if (str2[i].Length == tmp.Length)
                {
                    Array.Resize(ref max, max.Length + 1);
                    max[max.Length - 1] = str2[i];
                }
            }
            return max;
        }

        /// <summary>
        /// Формирование новой строки
        /// </summary>
        /// <returns></returns>
        private string NewLineForming()
        {
            string str1 = "";
            for (int i = 0; i < msg.Length; i++)
            {
                if (@".,!?-".IndexOf(msg[i]) != -1) str1 += $" {msg[i]} ";
                else str1 += $"{msg[i]}";
            }

            return str1;
        }

        /// <summary>
        /// удаление слов, которые заканчиваются на заданный символ
        /// </summary>
        public void deleteWord(char ch) {
            string str1 = NewLineForming();
            var str2 = str1.Split(' ');
            string str3 = "";
            foreach (var e in str2) {
                if(@".,!?-".IndexOf(e) != -1) str3 += $"{e}";
                else if(e != "" && e[e.Length - 1] != ch) str3 += $"{e} ";
            }
            //дописать
            Console.WriteLine($"msg: {str3}");
        }
        /// <summary>
        /// Вывод сообщений, содержащих не более n символов
        /// </summary> 
        /// <param name="n"></param>
        public void consoleLimInLength(int n) {
            string str1 = NewLineForming();

            string[] str2 = str1.Split(' ');
            string pattern = @"[a-zA-Z]{" + (n) + "}";
            Regex regex = new Regex(pattern);

            for (int i = 0; i < str2.Length;i++)
            {
                if (regex.IsMatch(str2[i]) && str2[i].Length == n) Console.WriteLine($">>> {str2[i]}");
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
            Console.WriteLine($"Longest word: ");
            string[] LongestWord = msg.findLongestWord();
            for (int i = 0; i < LongestWord.Length; i++) {
                Console.WriteLine($">>> {LongestWord[i]}");
            }

            Console.WriteLine($"String Of Longest Words: {msg.stringOfLongestWords()}"); 

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
