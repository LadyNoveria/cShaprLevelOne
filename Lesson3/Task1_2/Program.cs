using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_2
{
    #region Class Complex
    class Complex
    {
        // Все методы и поля публичные. Мы можем получить доступ к ним из другого класса.
        public double im;
        public double re;

        /// <summary>
        /// Сложение двух комплексных чисел
        /// </summary>
        /// <returns></returns>
        public Complex Plus(Complex x)
        {
            Complex y = new Complex();
            y.im = x.im + this.im;
            y.re = x.re + this.re;
            return y;
        }
        /// <summary>
        /// Вычитание двух комплексных чисел
        /// </summary>
        /// <returns></returns>
        public Complex Minus(Complex x)
        {
            Complex y = new Complex();
            y.im = this.im - x.im;
            y.re = this.re - x.re;
            return y;
        }
        /// <summary>
        /// Произведение двух комплексных чисел
        /// </summary>
        /// <returns></returns>
        public Complex Multi(Complex x)
        {
            Complex y = new Complex();
            y.im = this.re * x.im + this.im * x.re;
            y.re = this.re * x.re - this.im * x.im;
            return y;
        }

        public string ToString()
        {
            if (im < 0)
                return re + "" + im + "i";
            else
                return re + "+" + im + "i";
        }
    }
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            //Вяльшина Вероника
            /*б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.*/

            Complex complex1 = new Complex();
            Console.Write("Введите действительную часть первого числа: ");
            complex1.re = inputCheck();
            Console.Write("Введите мнимую часть первого числа: ");
            complex1.im = inputCheck();

            Complex complex2 = new Complex(); ;
            Console.Write("Введите действительную часть второго числа: ");
            complex2.re = inputCheck();
            Console.Write("Введите мнимую часть второго числа: ");
            complex2.im = inputCheck();

            Complex result = complex1.Plus(complex2);
            Console.WriteLine("Сложение: " + result.ToString());
            result = complex1.Multi(complex2);
            Console.WriteLine("Произведение: " + result.ToString());
            result = complex1.Minus(complex2);
            Console.WriteLine("Вычитание: " + result.ToString());

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
        public static int inputCheck() {
            bool flag;
            int temp;

            do
            {
                flag = int.TryParse(Console.ReadLine(), out temp);
                if (!flag) Console.WriteLine("Неверный формат ввода. Введите целое число.");
            } while (!flag);

            return temp;
        }
    }
}
