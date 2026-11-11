using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLite
{
    internal class ArrayMultidimensional
    {
        public static void RunMyCode()
        {
            int[,] array;
            int[,] array2 = new int[2, 3];

            int[,] array3 = { 
                { 2, 3, 4 }, 
                { 4, 5, 1 }, 
                { 7, 8, 9 } 
            };

            int[,] array4 = new int[2, 3] { 
                { 9, 8, 7}, 
                { 6, 5, 4 } 
            };

            Console.WriteLine(array4[1, 1]);
            Console.WriteLine("---------------");

            Console.WriteLine(array3.Length);
            Console.WriteLine("---------------");

            for (int i = 0; i < array3.GetLength(0); i++) // for TAB+TAB
            {
                for (int j = 0; j < array3.GetLength(1); j++)
                {
                    Console.Write(array3[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("---------------");

            int[,] array5 = new int[4, 4];

            Random rand = new Random();

            for (int i = 0; i < array5.GetLength(0); i++) // for TAB+TAB
            {
                for (int j = 0; j < array5.GetLength(1); j++)
                {
                    array5[i, j] = rand.Next(1,10);
                    Console.Write(array5[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
