using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLite
{
    internal class FightWithEnemy
    {
        public static void RunMyCode()
        {
            int playerHealth = 1000;
            int playerDamage = 5;
            int enemyHealth = 1500; 
            int enemyDamage = 3;

            while (playerHealth > 0 && enemyHealth > 0)
            {
                playerHealth -= enemyDamage;
                enemyHealth -= playerDamage;

                Console.WriteLine($"Player health: {playerHealth}, " +
                    $"enemy health {enemyHealth}.");
            }

            if (playerHealth <= 0 && enemyHealth <= 0)
            {
                Console.WriteLine("Draw.");
            }
            else if (enemyHealth <= 0)
            {
                Console.WriteLine("Player win.");
            }
            else if (playerHealth <= 0)
            {
                Console.WriteLine("Enemy win.");
            }
        }
    }
}
