using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLite
{
    internal class DepositeInterest
    {
        public static void RunMyCode() 
        {
            float money;
            int years, percent;

            Console.Write("Введите количество денег, внесенных на вклад: ");
            money = Convert.ToSingle(Console.ReadLine());       
            Console.Write("На сколько лет открыт вклад: ");
            years = Convert.ToInt32(Console.ReadLine());   
            Console.Write("Под какой процент: ");
            percent = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < years; i++)
            {
                money += money / 100 * percent;
                Console.WriteLine("В этом году у вас" + money);
                Console.ReadKey();
            }
        }
    }
}
