using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._1
{
    class BMI_Calc
    {
        static void Main(string[] args)
        {
            //Вяльшина Вероника
            /*5. а) Написать программу, которая запрашивает массу и рост человека, 
             * вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, 
             * набрать вес или все в норме;*/

            Console.Write("Введите Ваш вес: ");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите Ваш рост: ");
            double height = Convert.ToDouble(Console.ReadLine());
            bodyMassIndex(weight, height);

            Console.ReadKey();
        }

        public static void bodyMassIndex(double weight, double height) {
            height = convertToSantimeters(height);
            Console.WriteLine("рос: " + height);
            double bmi = weight / (height * height);
            if (bmi < 15.99)
                Console.WriteLine(String.Format("{0:f2}", bmi) + " - Выраженный дефицит массы тела. Необходимо набрать вес.");
            else if(bmi >= 16.00 && bmi < 18.50)
                Console.WriteLine(String.Format("{0:f2}", bmi) + " - Недостаточная (дефицит) масса тела. Необходимо набрать вес.");
            else if (bmi >= 18.50 && bmi < 25)
                Console.WriteLine(String.Format("{0:f2}", bmi) + " - Норма.");
            else if (bmi >= 25.00 && bmi < 30)
                Console.WriteLine(String.Format("{0:f2}", bmi) + " - Избыточная масса тела (предожирение). Необходимо снизить вес.");
            else if (bmi >= 30.00 && bmi < 35)
                Console.WriteLine(String.Format("{0:f2}", bmi) + " - Ожирение первой степени. Необходимо снизить вес.");
            else if (bmi >= 35.00 && bmi < 40)
                Console.WriteLine(String.Format("{0:f2}", bmi) + " - Ожирение второй степени. Необходимо снизить вес.");
            else if (bmi >= 40)
                Console.WriteLine(String.Format("{0:f2}", bmi) + " - Ожирение третьей степени (морбидное). Необходимо снизить вес.");
        }

        public static double convertToSantimeters(double height) {
            return height / 100;
        }
    }
}
