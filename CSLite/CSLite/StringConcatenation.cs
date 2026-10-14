using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLite
{
    internal class StringConcatenation
    {
        public static void RunMyCode()
        {
            int age = 27;
            string name = "Bob";

            Console.WriteLine("Ваше имя: " + name + " вам " + age + " лет"); // cw + tab
            Console.WriteLine($"Ваше имя: {name} вам {age} лет"); // ctrl + d
        }
    }
}
