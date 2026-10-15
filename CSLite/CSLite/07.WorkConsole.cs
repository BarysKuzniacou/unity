using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLite
{
    internal class WorkConsole
    {
        public static void RunMyCode()
        {
            //Console.WriteLine();
            //Console.ReadKey();

            //строки для отображения кириллицы
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.Write($"Введите имя: ");

            string name;
            name = Console.ReadLine();

            Console.WriteLine($"Имя: {name}");


            Console.Write($"Введите возраст: ");
            
            int age;
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Возраст: {age}");

        }
    }
}
