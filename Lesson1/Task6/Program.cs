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
            /**Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).*/
            string text = "Veronika Vyal'shina Moscow";
            int a = 12;
            int b = -45;
            int c = 223;
            string d = "123qwerty";
            string e = "Hello World!";

            print(text);
            outputInCenter(text);
            exchangeOfVar(ref d, ref e);
            print(d, "d: ");
            print(e, "e: ");
            int maxAB = maxOfTwoNum(a, b);
            int minAC = minOfTwoNum(a, c);
            int maxABC = maxOfThreeNum(a, b, c);
            int minABC = minOfThreeNum(a, b, c);
            print(maxAB, "Max a and b = ");
            print(minAC, "Min a and c = ");
            print(maxABC, "Max a and b and c = ");
            print(minABC, "Min a and b and c = ");

            Console.ReadKey();
        }

        public static void outputInCenter(string text){
            var width = Console.WindowWidth;
            var padding = (width / 2) + (text.Length / 2);
            Console.WriteLine("{0, " + padding + "}", text);
        }

        public static void print(string text)
        {
            Console.WriteLine(text);
        }

        public static void print(int text)
        {
            Console.WriteLine(text);
        }

        public static void print(string text, string message)
        {
            Console.WriteLine(message + text);
        }

        public static void print(int text, string message)
        {
            Console.WriteLine(message + text);
        }

        public static void exchangeOfVar(ref string a, ref string b)
        {
            a = b + a;
            b = a.Substring(b.Length);
            a = a.Substring(0, a.Length - b.Length);
        }

        public static int maxOfTwoNum(int a, int b)
        {
            int max = a;
            if (max < b)
            {
                max = b;
                return max;
            }
            else
                return max;
        }

        public static int minOfTwoNum(int a, int b)
        {
            int min = a;
            if (min > b)
            {
                min = b;
                return min;
            }
            else
                return min;
        }

        public static int maxOfThreeNum(int a, int b, int c)
        {
            int max = maxOfTwoNum(a, b);

            if (max < c)
                max = c;

            return max;
        }

        public static int minOfThreeNum(int a, int b, int c)
        {
            int min = minOfTwoNum(a, b);

            if (min > c)
                min = c;

            return min;
        }
    }
}
