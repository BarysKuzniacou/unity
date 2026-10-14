using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLite
{
    internal class Сoncatenation
    {
        public static void RunMyCode()
        {
            string greeting = "Привет,";
            string name = "11";

            string message = greeting + " " + name;

            int age = 5;

            Console.WriteLine(message + ", рад видеть!" + " " +  
                "тебе" + " " + age + 1 + " " + "лет."); // Привет, 11,
                                                        // рад видеть! тебе 51 лет.
            
            Console.WriteLine(message + ", рад видеть!" + " " +
                "тебе" + " " + (age + 1) + " " + "лет."); // Привет, 11,
                                                          // рад видеть! тебе 6 лет.
            
            Console.WriteLine(5 + 5 + "hello"); // 10hello
            Console.WriteLine(5 + (5 + "hello")); // 55hello
        }
    }
}
