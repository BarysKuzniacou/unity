using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLite
{
    internal class ConsoleTricks
    {
        public static void RunMyCode() 
        {
            Console.WriteLine("Привет, Андрей!\nКуда ты " +
                "вчера делся?\nЯ убежал к...]\b \b");

            Console.ReadKey();

            Console.Clear();

            Console.SetCursorPosition(10, 10);

            Console.ReadKey();

            Console.SetCursorPosition(0, 0);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkGray;

            Console.Clear();

            Console.WindowHeight = 10;
            Console.WindowWidth = 35;

            Console.WriteLine("Привет, Андрей!\nКуда ты " +
                 "вчера делся?\nЯ убежал к...]\b \b");

            Console.ReadKey();
        }
    }
}
