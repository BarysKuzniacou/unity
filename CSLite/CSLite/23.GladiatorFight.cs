using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLite
{
    internal class GladiatorFight
    {
        public static void RunMyCode() 
        {
            Random rand = new Random();

            float health1 = rand.Next(90, 110);
            int damage1 = rand.Next(7, 35); // ctrl + alt and ctrl + v
            int armor1 = rand.Next(45, 100);

            float health2 = rand.Next(80, 120);
            int damage2 = rand.Next(5, 40);
            int armor2 = rand.Next(65, 100);

            Console.WriteLine($"Гладиатор 1 - {health1} здоровье, " +
                $"{damage1} урон, {armor1} броня");

            Console.WriteLine($"Гладиатор 2 - {health2} здоровье, " +
                $"{damage2} урон, {armor2} броня"); // ctrl + d

            while (health1 > 0 && health2 > 0)
            {
                health1 -= Convert.ToSingle(rand.Next(0, damage2 + 1)) 
                    / 100 * armor1;
                health2 -= Convert.ToSingle(rand.Next(0, damage1 + 1)) 
                    / 100 * armor2;

                Console.WriteLine($"Здоровье гладиатора 1: {health1}");
                Console.WriteLine($"Здоровье гладиатора 2: {health2}");
            }

            if (health1 <= 0 && health2 <= 0)
            {
                Console.WriteLine("Ничья! Оба погибли!");
            }
            else if (health1 <= 0)
            {
                Console.WriteLine("Гладиатор 1 прогирал!");
            }
            else if (health2 <= 0)
            {
                Console.WriteLine("Гладиатор 2 прогирал!");
            }
        }
    }
}
