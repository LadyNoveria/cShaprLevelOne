using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Counter
    {
        static void Main(string[] args)
        {
            //Вяльшина Вероника
            /*2. Написать метод подсчета количества цифр числа.*/

            Console.Write("Enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digits in number: " + counter(Math.Abs(number)));
            Console.ReadKey();
        }

        public static int counter(int x) {
            int count = 0;
            while (x > 0) {
                x = x / 10;
                count++;
            }
            return count;
        }
    }
}
