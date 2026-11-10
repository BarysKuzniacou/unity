using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLite
{
    internal class BaseArray
    {
        public static void RunMyCode() 
        {
            //int[] cucumbers = new int[10];

            ////Console.WriteLine(cucumbers.Length);

            //Random rand = new Random();

            //for (int i = 0; i < cucumbers.Length; i++) 
            //{
            //    cucumbers[i] = rand.Next(1, 10);
            //    Console.Write(cucumbers[i] + " ");
            //}    

            int[] cucumbers = { 24, 25, 17, 38, 100, int.MaxValue, int.MinValue };

            for (int i = 0; i < cucumbers.Length; i++)
            {
                Console.Write(cucumbers[i] + " ");
            }

            Console.WriteLine();

            int[] cucumbers2 = new int[4] { 4, 1, 6, 2 };

            for (int i = 0; i < cucumbers2.Length; i++)
            {
                Console.Write(cucumbers2[i] + " ");
            }


        }
    }
}
