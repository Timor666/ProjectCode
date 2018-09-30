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

            // Console.WriteLine("最终值" + FunRecursion(5));

            int[] a = { 1,2 };
            BeautyArray(a,3);
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


 


        public static void  BeautyArray(int[] array ,int length)
        {
            int a = 0;
            for (int i = 0; i < array.Length; i++)
            {
                a += array[i];
                for (int j =i; j < array.Length; j++)
                {
                    a += array[j];
                }
            }
            Console.WriteLine(a);
        }

    }
}
