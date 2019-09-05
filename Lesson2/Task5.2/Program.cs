using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._2
{
    class Calc_mass
    {
        static void Main(string[] args)
        {
            //Вяльшина Вероника
            /*5. а) Написать программу, которая запрашивает массу и рост человека, вычисляет его 
             * индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме;
            б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.*/

            Console.Write("Введите Ваш вес: ");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите Ваш рост: ");
            double height = Convert.ToDouble(Console.ReadLine());
            bodyMassIndex(weight, height);

            Console.ReadKey();
        }

        public static void bodyMassIndex(double weight, double height)
        {
            int count = 0;
            height = convertToSantimeters(height);

            do
            {
                double bmi = weight / (height * height);
                if (bmi < 18.50){
                    count++;
                    weight++;
                }
                else if (bmi >= 18.50 && bmi < 25){
                    if (count == 0){
                        Console.WriteLine(String.Format("{0:f2}", bmi) + " - Норма.");
                        break;
                    }
                    else if (count < 0){
                        Console.WriteLine("Ваш идекс массы тела: " + String.Format("{0:f2}", bmi) + ". Вам необходимо похудеть на " + Math.Abs(count) + " кг");
                        break;
                    }
                    else{
                        Console.WriteLine("Ваш идекс массы тела: " + String.Format("{0:f2}", bmi) + ". Вам необходимо набрать " + count + " кг");
                        break;
                    }
                }
                else if (bmi >= 25){
                    count--;
                    weight--;
                }

            } while (true);
        }

        public static double convertToSantimeters(double height)
        {
            return height / 100;
        }
    }
}
