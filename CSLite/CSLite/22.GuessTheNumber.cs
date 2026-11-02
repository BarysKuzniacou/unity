using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLite
{
    internal class GuessTheNumber
    {
        
        public static void RunMyCode()
        {
            int number;
            int lower, higher;
            int triesCount = 5;
            int userInput;
            Random random = new Random();

            number = random.Next(0, 101);
            lower = random.Next(number - 10, number);
            higher = random.Next(number + 1, number + 10);

            Console.WriteLine($"Загадано число от 0 до 100. Оно больше чем {lower} " +
                $"и меньше чем {higher}.");
            Console.WriteLine($"У вас {triesCount} попыток.");

            while (triesCount > 0)
            {

                Console.Write("Введите число: ");
                userInput = Convert.ToInt32(Console.ReadLine());

                if (userInput == number)
                {
                    Console.WriteLine($"Вы победили! Это  было число {number}.");
                    break;
                }
                else
                { 
                    Console.WriteLine($"Неверно! Это не число {userInput}.");
                    Console.WriteLine($"У вас {triesCount} попыток.");
                }

            }

            if (triesCount < 0)
            {
                Console.WriteLine($"Это было число {number}.");
            }
        }
    }
}
