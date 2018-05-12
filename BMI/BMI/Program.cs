using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("請誠實地輸入身高");

            // 宣告身高的變數 
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine("請誠實地輸入體重");

            // 宣告體重的變數 
            double weight = double.Parse(Console.ReadLine());

            // 宣告BMI的公式 
            double BMI = weight * 10000 / (height * height);
            if (BMI < 18.5)
            {
                Console.WriteLine("體重過輕");

                // 發出“嗶”的聲響
                Console.Beep();
                Console.BackgroundColor = ConsoleColor.Red;
            }
            else if (BMI >= 18.5 && BMI < 24)
            {
                Console.WriteLine("恭喜你，非常正常^^");

                Console.BackgroundColor = ConsoleColor.Green;
            }
            else if (BMI >= 24 && BMI < 27)
            {
                Console.WriteLine("你有點過重哦");
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Beep();
            }
            else if (BMI >= 27 && BMI < 30)
            {
                Console.WriteLine("輕度肥胖");
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Beep();
            }
            else if (BMI >= 30 && BMI < 35)
            {
                Console.WriteLine("中度肥胖");
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Beep();
            }
            else
            {
                Console.WriteLine("重度肥胖");
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Beep();
            }
            Console.WriteLine("你的BMI數值是" + BMI.ToString());

            // 按任意按鈕即可退出 
            Console.ReadKey();
        }
    }
}