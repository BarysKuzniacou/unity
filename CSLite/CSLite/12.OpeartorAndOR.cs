using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLite
{
    internal class OpeartorAndOR
    {
        public static void RunMyCode()
        {
            //Console.WriteLine(5 == 5 || 4 == 3); // true

            // логическое И &&
            // x | y | x && y   true -> 1    false -> 0
            // 1 | 1 |  1
            // 1 | 0 |  0
            // 0 | 1 |  0
            // 0 | 0 |  0

            // логическое ИЛИ ||
            // x | y | x || y   true -> 1    false -> 0
            // 1 | 1 |  1
            // 1 | 0 |  1
            // 0 | 1 |  1
            // 0 | 0 |  0

            int money = 400;
            int level = 8;

            if (money >= 500 && level > 9)
            {
                Console.WriteLine("Welcome guild!");
            }
            else
            {
                Console.WriteLine("Go away!");
            }
        }
    }
}
