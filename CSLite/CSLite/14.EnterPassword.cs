using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CSLite
{
    internal class EnterPassword
    {
        public static void RunMyCode() 
        {
            string password = "123qwe";
            string userInput;

            Console.Write("Введите пароль: ");
            userInput = Console.ReadLine();

            if (userInput == password)
            {
                Console.WriteLine("Введен верный пароль");
            }
            else 
            {
                Console.WriteLine("Введен неверный пароль");
            }
        }
    }
}
