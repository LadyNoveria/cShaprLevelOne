using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._1
{
    class Output
    {
        static void Main(string[] args)
        {
            /*а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.*/
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your surname?");
            string surname = Console.ReadLine();
            Console.WriteLine("Where are you from?");
            string city = Console.ReadLine();

            Console.WriteLine(name + " " + surname + " " + city);
            Console.ReadKey();
        }
    }
}
