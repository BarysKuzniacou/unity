using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLite
{
    internal class RandomClass
    {
        public static void RunMyCode()
        {
            //Random random = new Random();

            //while (true)
            //{
            //    int value = random.Next(0, 10); // 0123456789
            //    Console.WriteLine(value);
            //    Console.ReadKey();
            //}

            Random random = new Random();
            
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(random.Next(0, 5));
            }
        }
    }
}
