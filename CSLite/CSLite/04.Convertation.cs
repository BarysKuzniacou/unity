using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLite
{
    internal class Convertation
    {
        public static void RunMyCode()
        {
            int age;
            string input = "15";

            age = Convert.ToInt32(input);

            Console.WriteLine(age);

            float result;
            int x = 5, y = 2;

            result = Convert.ToSingle(x) / y;

            Console.WriteLine(result);

            //Convert.ToInt16 short
            //Convert.ToInt32 int
            //Convert.ToInt64 long
            //Convert.ToSByte sbyte
            //Convert.ToSingle float
            //Convert.ToString string
            //Convert.ToUInt16 32 64 бесзнаковые типы
            //Convert.ToDouble deouble
            //Convert.ToBoolean bool

            int flag = 1;

            bool flagInBoolean = Convert.ToBoolean(flag);

            Console.WriteLine(flagInBoolean);

            int reconvert = Convert.ToInt16(flagInBoolean);

            Console.WriteLine(reconvert);
        }
    }
}
