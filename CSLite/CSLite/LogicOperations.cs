using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLite
{
    internal class LogicOperations
    {
        public static void RunMyCode()
        {   
            // == > != >= < <=
            
            int a = 5;
            int b = 5;

            Console.WriteLine(a < b);

            int age = 18;
            bool accesIsAllowed;

            accesIsAllowed = age >= 18;

            Console.WriteLine("Вход разрешен: " + accesIsAllowed);
        }
    }
}
