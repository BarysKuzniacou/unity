using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLite
{
    internal class WhileCycle
    {
        public static void RunMyCode() 
        {
            int age;

            Console.Write("Сколько ваом лет? ");
            age = Convert.ToInt32(Console.ReadLine());

            while (age-- > 0)
            {
                if (age == 5)
                {
                    continue;
                }

                Console.WriteLine($"С днемрождения {age}");

                //if (age == 5)
                //{
                //    break;
                //}
            }
        }
    }
}
