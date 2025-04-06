using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, temp;
        // دریافت دو عدد از کاربر
        Console.WriteLine("لطفاً عدد اول را وارد کنید:");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("لطفاً عدد دوم را وارد کنید:");
            num2 = int.Parse(Console.ReadLine());

            // اطمینان از اینکه num1 کوچک‌تر است
            if (num1 > num2)
            {
                temp = num1;
                num1 = num2;
                num2 = temp;
            }

            // پیدا کردن و چاپ مضارب ۵ بین دو عدد
            Console.WriteLine("مضارب ۵ بین این دو عدد عبارتند از:");
            for (int i = num1; i <= num2; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine(i);
                    Console.ReadKey();
                }
            }
        }
    }
}
