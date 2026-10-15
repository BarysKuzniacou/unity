using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLite
{
    internal class IncrementDecrement
    {
        public static void RunMyCode()
        {
            int i = 0, j = 0;
            Console.WriteLine("i++: " + i++);
            Console.WriteLine("++j: " + ++j);

            int a = 0;
            //                  1   + 2 + 1 +   1   + '1' +   3   * 2 => 516
            Console.WriteLine((++a) + 2 + 1 + (a++) + "1" + (++a) * 2);
        }
    }
}
