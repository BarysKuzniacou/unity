using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLite
{
    internal class OperatorIf
    {
        public static void RunMyCode1()
        {
            int age;

            Console.Write("How old are you? ");
            age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("Wellcome to bar!");
                Console.WriteLine("What do you want?");
            }
            else 
            {
                Console.WriteLine("You are too young!");
                Console.WriteLine($"Come after {18 - age} years.");
            }
        }

        public static void RunMyCode2()
        {
            string dayOfWeek;

            Console.Write("Enter the day of the week: ");
            dayOfWeek = Console.ReadLine();

            if (dayOfWeek == "Monday")
            {
                Console.WriteLine("Monday!");
            }
            else if (dayOfWeek == "Tuesday")
            {
                Console.WriteLine("Tuesday!");
            }
        }
    }
}
