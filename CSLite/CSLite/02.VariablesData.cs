using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLite
{
    internal class VariablesData
    {
        public static void RunMyCode()
        {
            // Целочисленные
            byte b; // 0 255
            sbyte sb; // -128 127
            short s; // -32768 32767
            ushort us; // 0 65535
            int i; // -2147483648 2147483647
            uint ui; // 0 4294672295
            long l = long.MaxValue;
            ulong ul;

            // С плавающей точкой
            float f = 5.7f;
            double d = 5.7;

            // символьный тип
            char c = 'c';

            // строковый тип
            string str = "string";

            // логический тип
            bool bl = true;

            // + - * / %
            float result;
            int x, y;

            x = 5;
            y = 2;

            // для получения значения с плавающей точкой, одна из переменных приводится к типу float
            result = Convert.ToSingle(x) / y;

            Console.WriteLine(result);

            int timeInMinets = 130;
            int hour;
            int minute;

            hour = timeInMinets / 60;
            minute = timeInMinets % 60;

            Console.WriteLine("hours: " + hour + ", minutes: " + minute);

            // int result= 5 - (12 + 2); // 5 - 12 + 2

            Console.WriteLine(result);
        }
    }
}
