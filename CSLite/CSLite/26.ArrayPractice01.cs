using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLite
{
    internal class ArrayPractice01
    {
        public static void RunMyCode() 
        {
            int[] array = { 2, 3, 4, 7, 8 };

            int sum = 0;

            for (int i = 0; i < array.Length; i++) 
            {
                Console.WriteLine(array[i]);
                sum += array[i];
            }

            Console.WriteLine(sum);
            Console.WriteLine("--------------------------");

            int[] array2 = { 1, 3, 5, 8, 12, 2 };
            int maxElement = int.MinValue;

            for (int i = 0; i < array2.Length; i++) 
            {
                if (array2[i] > maxElement)
                {
                    maxElement = array2[i];
                }
            }

            Console.WriteLine(maxElement);
        }
    }
}
