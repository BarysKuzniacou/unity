using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLite
{
    internal class ArrayRefTypes
    {
        public static void RunMyCode()
        {
            int[] array = new int[3];
            int[] tempArray = new int[3];

            array = tempArray;

             array[0] = 5;

            Console.WriteLine(tempArray[0]);

            int[] arr1 = new int[3];
            int[] arr2 = new int[5];
            int[] arr3;

            arr1 = arr2;

            arr1[0] = 5;
            arr1[1] = 3;

            arr3 = arr1;

            Console.WriteLine("\n-arr1-");
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr1[i] + " ");
            }

            Console.WriteLine("\n-arr2-");

            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write(arr2[i] + " ");
            }

            Console.WriteLine("\n-arr3-");

            for (int i = 0; i < arr3.Length; i++)
            {
                Console.Write(arr3[i] + " ");
            }

            arr3[0] = 77;

            Console.WriteLine("\n-arr1-");
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr1[i] + " ");
            }

            arr1 = new int[10] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            Console.WriteLine("\n-arr1-");
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr1[i] + " ");
            }

            Console.WriteLine("\n-arr2-");

            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write(arr2[i] + " ");
            }

            Console.WriteLine("\n-arr3-");

            for (int i = 0; i < arr3.Length; i++)
            {
                Console.Write(arr3[i] + " ");
            }
        }
    }
}
