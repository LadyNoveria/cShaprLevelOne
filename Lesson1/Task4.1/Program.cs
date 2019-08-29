using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._1
{
    class Exchange
    {
        static void Main(string[] args)
        {
            /*Написать программу обмена значениями двух переменных:
            а) с использованием третьей переменной.*/
            string c;
            Console.Write("Введите значение переменной a: ");
            string a = Console.ReadLine();
            Console.Write("Введите значение переменной b: ");
            string b = Console.ReadLine();

            c = a;
            a = b;
            b = c;

            Console.WriteLine("a:" + a + " b:" + b);

            Console.ReadKey();

        }
    }
}
