using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI計算機
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("輸入體重:");
            double kg = double.Parse(Console.ReadLine());
            Console.Write("輸入身高:");
            double cm = double.Parse(Console.ReadLine());
            double BMI = kg / ((cm * 0.01) * (cm * 0.01));
            Console.WriteLine("BMI值為:" + BMI);

            if (BMI < 16.5)
            {
                Console.WriteLine("體重過輕，免役");
            }

            if (BMI >= 16.5 && BMI < 26)
            {
                Console.WriteLine("正常範圍，給我當兵");
            }

            if (BMI >= 26 && BMI < 30)
            {
                Console.WriteLine("過重，去減肥吧不用當兵");
            }


            if (BMI > 30)
            {
                Console.WriteLine("超重，免役");
                Console.Beep(523, 100);
                Console.Beep(587, 100);
                Console.Beep(659, 100);
                Console.Beep(784, 100);
            }

            Console.ReadLine();
        }
    }
}