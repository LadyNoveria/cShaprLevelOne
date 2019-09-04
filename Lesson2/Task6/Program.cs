using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вяльшина Вероника
            /*6. *Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000. 
             * Хорошим называется число, которое делится на сумму своих цифр. Реализовать подсчет времени 
             * выполнения программы, используя структуру DateTime.*/

            DateTime startTime = DateTime.Now;

            for (long i = 1; i <= 1000000000; i++) {
                long result = calcSumm(i);
                if (i % result == 0) {
                    Console.WriteLine("Хорошее число: " + i + ". Сумма его цифр: " + result);
                }
            }

            DateTime endTime = DateTime.Now;
            TimeSpan span = endTime - startTime;
            Console.WriteLine("Время работы программы: " + span.TotalSeconds);
            Console.ReadKey();
        }

        public static long calcSumm(long i)
        {
            string str = i.ToString();
            int[] digits = new int[str.Length];
            long temp = 0;
            for (int j = 0; j < digits.Length; j++)
            {
                digits[j] = (int)char.GetNumericValue(str[j]);
                temp = temp + digits[j];
            }
            return temp;
        }
    }
}
