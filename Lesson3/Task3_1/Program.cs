using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_1
{
    #region class Fraction
    class Fraction {
        public long num; //numerator - числитель
        public long den; //denominator - знаменатель

        /// <summary>
        /// Сложение двух дробей
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public Fraction Plus(Fraction x)
        {
            Fraction y = new Fraction();
            y.num = (this.num * x.den) + (x.num * this.den);
            y.den = this.den * x.den;
            GFD(ref y.num, ref y.den);
            return y;
        }
        /// <summary>
        /// Вычитание двух дробей
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public Fraction Minus(Fraction x)
        {
            Fraction y = new Fraction();
            y.num = (this.num * x.den) - (x.num * this.den);
            y.den = this.den * x.den;
            GFD(ref y.num, ref y.den);
            return y;
        }

        /// <summary>
        /// Умножение двух дробей
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public Fraction Multi(Fraction x)
        {
            Fraction y = new Fraction();
            y.num = this.num * x.num;
            y.den = this.den * x.den;
            GFD(ref y.num, ref y.den);
            return y;
        }

        /// <summary>
        /// Деление двух дробей
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public Fraction Division(Fraction x)
        {
            Fraction y = new Fraction();
            y.num = this.num * x.den;
            y.den = this.den * x.num;
            GFD(ref y.num, ref y.den);
            return y;
        }

        public string ToString()
        {
            if (num < 0 || den < 0)
                return "-" + Math.Abs(num) + "/" + Math.Abs(den);
            else
                return num + "/" + den;
        }

        /// <summary>
        /// Нахождение Наибольшего Общего Делителя
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static long greatestCommonFactor(long a, long b)
        {
            while (b != 0)
            {
                long temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        /// <summary>
        /// Сокращение дроби
        /// </summary>
        /// <param name="num"></param>
        /// <param name="den"></param>
        public static void GFD(ref long num, ref long den) {
            long GCF = greatestCommonFactor(num, den);
            num = num / GCF;
            den = den / GCF;
        }
    }

    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            //Вяльшина Вероника
            /*3. *Описать класс дробей - рациональных чисел, являющихся отношением двух целых чисел. 
             * Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать программу, 
             * демонстрирующую все разработанные элементы класса.*/

            Fraction fraction1 = new Fraction();
            Fraction fraction2 = new Fraction();

            Console.Write("Введите числитель первой дроби: ");
            fraction1.num = inputCheck();
            Console.Write("Введите знаменатель первой дроби: ");
            fraction1.den = inputCheck();

            Console.Write("Введите числитель второй дроби: ");
            fraction2.num = inputCheck();
            Console.Write("Введите знаменатель второй дроби: ");
            fraction2.den = inputCheck();

            Fraction result = fraction1.Plus(fraction2);
            Console.WriteLine("Сложение: " + result.ToString());
            result = fraction1.Minus(fraction2);
            Console.WriteLine("Вычитание: " + result.ToString());
            result = fraction1.Multi(fraction2);
            Console.WriteLine("Умножение: " + result.ToString());
            result = fraction1.Division(fraction2);
            Console.WriteLine("Деление: " + result.ToString());

            Pause();
        }

        /// <summary>
        /// Задержка экрана
        /// </summary>
        public static void Pause()
        {
            Console.ReadKey();
        }

        /// <summary>
        /// Проверка ввода
        /// </summary>
        /// <returns></returns>
        public static long inputCheck()
        {
            bool flag;
            long temp;

            do
            {
                flag = long.TryParse(Console.ReadLine(), out temp);
                if (!flag) Console.WriteLine("Неверный формат ввода. Введите целое число.");
            } while (!flag);

            return temp;
        }
    }
}
