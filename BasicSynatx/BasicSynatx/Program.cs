//Program Name: Hello Universe
//Author Name: MD. Jubayer Hossain Abir
//Task: A program to print "Hello Universe"
//Date: 26th October, 2018: 8:30AM


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicSynatx
{
    class Program
    {
        static void Main(string[] args)
        {
         /*Console.Write("C# Programming: Learn to Build!");
            Console.Clear();
            Console.WriteLine("I'm Jannat Binte Alam. And You?");
            Console.ReadKey();*/
            
           System. Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            System.Console.WriteLine("Hello Universe");
           // Console.Beep(2100, 1000);
            Console.CursorSize = 100; //range 1-100
            Console.SetWindowSize(170, 43); // range maximum width 170 and maximum height 43
            //System.Console.ReadKey();
            ConsoleColor col = Console.ForegroundColor;
            ConsoleColor col1 = Console.BackgroundColor;
            Console.WriteLine(col);
            Console.WriteLine(col1);
            
         
            Console.ReadKey();
        }
    }
}
