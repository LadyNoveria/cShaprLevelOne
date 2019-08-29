using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) 
             * по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.*/
            double I;
            Console.Write("Введите массу тела: ");
            double m = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите рост человека: ");
            double h = Convert.ToDouble(Console.ReadLine());

            I = m / (h * h);

            Console.WriteLine($"Индекс массы тела I = {I}");
            
            Console.ReadKey();
        }
    }
}
