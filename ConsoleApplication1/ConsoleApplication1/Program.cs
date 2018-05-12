using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintText("123", ConsoleColor.Red, ConsoleColor.Blue);
            Console.ReadKey();
        }

        static void PrintText(string text, ConsoleColor textColor, ConsoleColor bgColor)
        {
            Console.BackgroundColor = bgColor;
            Console.ForegroundColor = textColor;
            Console.Write(text);
        }
    }
}

