using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLite
{
    internal class DamageCalculation
    {
        public static void RunMyCode()
        {
            //int health;
            float health;
            int armor;
            int damage;

            int percentConverter = 100;

            Console.Write("Enter health points: ");
            health = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter armor points: ");
            armor = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter damage points: ");
            damage = Convert.ToInt32(Console.ReadLine());

            //health -= damage * armor / percentConverter;
            health -= Convert.ToSingle(damage) / percentConverter * armor ;

            Console.WriteLine($"Your damage is {damage}. Your health is {health}.");
        }
    }
}
