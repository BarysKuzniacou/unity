using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLite
{
    internal class PasswordLimitAttempts
    {
        public static void RunMyCode() 
        {
            int triesCount = 5;
            string password = "12345";
            string userInput;

            //while (triesCount-- > 0)
            //{
            //    Console.Write("Введите пароль: ");
            //    userInput = Console.ReadLine();

            //    if (userInput == password)
            //    {
            //        Console.WriteLine($"Введен верный пароль с {triesCount} " +
            //            $"попытки");
            //        break;
            //    }
            //    else 
            //    {
            //        Console.WriteLine("Введен НЕ верный пароль, " +
            //            $"у вас осталос {triesCount} попыток"); ;

            //    }
            //}

            for (int i = 0; i < triesCount; i++) 
            {
                Console.Write("Введите пароль: ");
                userInput = Console.ReadLine();

                if (userInput == password)
                {
                    Console.WriteLine($"Введен верный пароль.");
                    break;
                }
                else
                {
                    Console.WriteLine("Введен НЕ верный пароль.");
                    Console.WriteLine($"Осталось {triesCount - i - 1} попыток.");
                }
            }
        }
    }
}
