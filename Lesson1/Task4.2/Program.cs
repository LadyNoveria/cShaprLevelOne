﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Написать программу обмена значениями двух переменных:
            а)  *без использования третьей переменной.*/
            
            Console.Write("Введите значение переменной a: ");
            string a = Console.ReadLine();
            Console.Write("Введите значение переменной b: ");
            string b = Console.ReadLine();

            a = b + a;
            b = a.Substring(b.Length);
            a = a.Substring(0, a.Length - b.Length);

            Console.WriteLine("a:" + a + " b:" + b);
            Console.ReadKey();
        }
    }
}
