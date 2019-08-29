using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Profile
    {
        static void Main(string[] args)
        {
            /*Написать программу «Анкета». Последовательно задаются вопросы 
             * (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
            а) используя  склеивание;
	        б) используя форматированный вывод;
	        в) используя вывод со знаком $.*/
            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите вашу фамилию: ");
            string surname = Console.ReadLine();
            Console.Write("Сколько вам лет? ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите ваш рост: ");
            int growth = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите ваш вес: ");
            int weight = Convert.ToInt32(Console.ReadLine());

            Console.Write("Имя:" + name + " Фамилия:" + surname + " Возраст:" + age + " Рост:" + growth + " Вес:" + weight);

            Console.ReadKey();
        }
    }
}
