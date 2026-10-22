using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLite
{
    internal class ForCycle
    {
        public static void RunMyCode() 
        {
            int age;

            Console.Write("Сколько вам лет? ");
            age = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= age; i++)
            {
                if (i == 0)
                {
                    continue;
                }
                Console.WriteLine($"С днем {i} рождения");
            }
        }
    }
}
