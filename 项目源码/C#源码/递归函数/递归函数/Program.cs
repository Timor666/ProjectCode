using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 递归函数
{
    class Program
    {
        static void Main(string[] args)
        {
            //计算5天


           // Console.WriteLine("最终值" + FunFor(5));

          Console.WriteLine("最终值" + FunRecursion(5));




            Console.ReadKey();
        }

        //For语句
        static int FunFor(int date)
        {
            int sum = 0;
            for (int i = 1; i <= date; i++)
            {
                sum += i;
                Console.WriteLine(i);
            }
            return sum;
        }

        //递归函数
        static int FunRecursion(int date)
        {
            Console.WriteLine(date);
            if(date == 0)
            {
                return 0;
            }
            else
            {
                return FunRecursion(date-1) + date;
            }
        }
    }
}
