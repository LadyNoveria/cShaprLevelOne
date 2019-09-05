using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вяльшина Вероника
            /*1. Написать метод, возвращающий минимальное из трех чисел.*/

            Console.Write("Enter number a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number c: ");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The minimum of three numbers is: " + minOfThreeNum(a, b, c));
            Console.WriteLine("The maximum of three numbers is: " + maxOfThreeNum(a, b, c));

            Console.ReadKey();
        }

        public static int maxOfTwoNum(int a, int b)
        {
            return (a > b) ? a : b;
        }

        public static int minOfTwoNum(int a, int b)
        {
            return (a < b) ? a : b;
        }

        public static int maxOfThreeNum(int a, int b, int c)
        {
            int max = maxOfTwoNum(a, b);
            return (max > c) ? max : c;
        }

        public static int minOfThreeNum(int a, int b, int c)
        {
            int min = minOfTwoNum(a, b);
            return (min < c) ? min : c;
        }
    }
}
