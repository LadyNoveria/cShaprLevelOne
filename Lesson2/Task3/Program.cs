using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вероника Вяльшина
            /*3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.*/
            int number, result = 0;
            while (true)
            {
                Console.Write("Enter number: ");
                number = Convert.ToInt32(Console.ReadLine());
                if (number % 2 != 0 && number > 0){
                    result = result + number;
                }
                if (number == 0) {
                    Console.WriteLine("Сумма всех нечетных положительных чисел: " + result);
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}
