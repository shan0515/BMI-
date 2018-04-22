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
            // 設 BMI計算機為標題
            Console.Title = "BMI計算機";
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("╔═══════════╗");
            Console.WriteLine("║ BMI計算機 ║");
            Console.WriteLine("╚═══════════╝");

            // 輸入身高體重
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("輸入體重:");           

            // 轉型方式
            double kg = double.Parse(Console.ReadLine());
            Console.Write("輸入身高:");
            double cm = double.Parse(Console.ReadLine());

            // 計算BMI值
            double BMI = kg / ((cm * 0.01) * (cm * 0.01));
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("BMI值為:" + BMI);

            // 判斷BMI的範圍
            if (BMI < 16.5)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("╔════════════════════════╗");
                Console.WriteLine("║                        ║");
                Console.WriteLine("║  體重過輕，免疫        ║");
                Console.WriteLine("║                        ║");
                Console.WriteLine("╚════════════════════════╝");

             // 嗶嗶聲
                Console.Beep(523, 100);
                Console.Beep(587, 100);
                Console.Beep(988, 100);
                Console.Beep(880, 100);
            }

            if (BMI >= 16.5 && BMI < 26)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("╔════════════════════════╗");
                Console.WriteLine("║                        ║");
                Console.WriteLine("║  正常範圍，給我當兵    ║");
                Console.WriteLine("║                        ║");
                Console.WriteLine("╚════════════════════════╝");

                Console.Beep(784, 100);
                Console.Beep(659, 100);
                Console.Beep(784, 100);
                Console.Beep(784, 100);
            }

            if (BMI >= 26 && BMI < 30)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("╔════════════════════════╗");
                Console.WriteLine("║                        ║");
                Console.WriteLine("║ 過重，去減肥吧!不用當兵║");
                Console.WriteLine("║                        ║");
                Console.WriteLine("╚════════════════════════╝");

                Console.Beep(523, 100);
                Console.Beep(659, 100);
                Console.Beep(523, 100);
                Console.Beep(587, 100);
            }


            if (BMI > 30)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("╔════════════════════════╗");
                Console.WriteLine("║                        ║");
                Console.WriteLine("║  超重，免役            ║");
                Console.WriteLine("║                        ║");
                Console.WriteLine("╚════════════════════════╝");

                Console.Beep(523, 100);
                Console.Beep(587, 100);
                Console.Beep(659, 100);
                Console.Beep(784, 100);
            }

            Console.ReadLine();
        }
    }
}