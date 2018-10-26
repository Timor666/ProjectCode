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
            //立方体
            string[] cube = { "立1", "立2", "立3", "立4" };
            //位置
            string[] pos = { "前", "后", "左", "右", "上", "下" };
            //颜色
            string[] color = { "红", "黄", "绿", "白" };

            GroupArray(cube, pos, color);

            //计算5天


            // Console.WriteLine("最终值" + FunFor(5));

            // Console.WriteLine("最终值" + FunRecursion(5));

            //int[] a = { 1,2 };
            //BeautyArray(a,3);


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

 
        public static void GroupArray(string[] g,string[] p,string[] co)
        {
            //获取长度
            int len1 = g.Length;
            int len2 = p.Length;
            int len3 = co.Length;
            //所有结果存放
            string[] array = new string[len1 * len2 * len3];
            //索引
            int index = 0;

            for (int i = 0; i < len1; i++)
            {
                for (int j = 0; j < len2; j++)
                {
                    for (int k = 0; k < len3; k++)
                    {
                        array[index] = g[i] + "--" + p[j] + "--" + co[k];
                        index++;
                    }
                }
            }

            //打印
            foreach (var ar  in array)
            {
                Console.WriteLine(ar);
            }
        }
    }
 
}
// 64 63 62 61 
// 54 53 52 51 
// 44 43 42 41 

