using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLite
{
    internal class OperatorSwitch
    {
        public static void RunMyCode()
        {
            string dayOfWeek;
            dayOfWeek = Console.ReadLine();

            switch (dayOfWeek) 
            {
                case "понедельник":
                case "суббота":
                    Console.WriteLine("идем в кино");
                    break;
                case "вторник":
                case "воскресенье":
                    Console.WriteLine("идем в театр");
                    break;
                case "среда":
                    Console.WriteLine("среда");
                    break;
                case "четверг":
                    Console.WriteLine("четверг");
                    break;
                case "пятница":
                    Console.WriteLine("пятница");
                    break;
                default:
                    Console.WriteLine("не день недели");
                    break;
            }
        }
    }
}
