using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLite
{
    internal class FoodShop
    {
        public static void RunMyCode()
        {
            int money;
            int food;
            int foodUnitPrice = 10;
            bool isAbleToPay = false;

            Console.WriteLine("Hello! Welcom to Shop. Todays food for " 
                + foodUnitPrice +
                " gold.");

            Console.Write("How much gold do you have? ");
            money = Convert.ToInt32(Console.ReadLine());

            Console.Write("How much food do you want? ");
            food = Convert.ToInt32(Console.ReadLine());

            isAbleToPay = money >= food * foodUnitPrice;

            food = Convert.ToInt32(isAbleToPay) * food;

            money -= food * foodUnitPrice;

            Console.WriteLine($"You have {food} food units, and {money} glod.");
        }
    }
}
