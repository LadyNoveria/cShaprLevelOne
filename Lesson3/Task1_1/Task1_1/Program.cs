using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_1
{
    #region struct Complex
    struct Complex
    {
        public double im;
        public double re;

        //Сложение двух комплексных чисел
        public Complex Plus(Complex x)
        {
            Complex y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }
        //Произведениу двух комплексных чисел
        public Complex Multi(Complex x)
        {
            Complex y;
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }

        //Вычитание двух комплексных чисел
        public Complex Minus(Complex x)
        {
            Complex y;
            y.im = im - x.im;
            y.re = re - x.re;
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
            /*1. а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры;*/

            Complex complex1;
            Console.Write("Введите действительную часть первого числа: ");
            complex1.re = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите мнимую часть первого числа: ");
            complex1.im = Convert.ToInt32(Console.ReadLine());

            Complex complex2;
            Console.Write("Введите действительную часть второго числа: ");
            complex2.re = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите мнимую часть второго числа: ");
            complex2.im = Convert.ToInt32(Console.ReadLine());

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
    }
}
