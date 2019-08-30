using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._3
{
    class Outputer
    {
        static void Main(string[] args)
        {
            /*а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
            б) *Сделать задание, только вывод организовать в центре экрана.
            в) **Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y).*/

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your surname?");
            string surname = Console.ReadLine();
            Console.WriteLine("Where are you from?");
            string city = Console.ReadLine();

            string text = name + " " + surname + " " + city;
            outputInCenter(text);

            Console.ReadKey();
        }

        public static void outputInCenter(string text) {
            var width = Console.WindowWidth;
            var padding = (width / 2) + (text.Length / 2);
            Console.WriteLine("{0, " + padding + "}", text);
        }
    }
}




