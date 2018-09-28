using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 排序算法
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 12, 3, 1, 4, 55, 19, 3, 6, 234, 76, 14, 5, 0, 23 }; //数组


            //array.BubbleSort();   //冒泡排序
            //array.SelectionSort();    //选则排序
            array.InsertSort();     //插入排序
            
            foreach (int item in array)
            {
                Console.Write(item + "、");
            }
            Console.ReadKey();
        }
    }
     
    /// <summary>
    /// 排序工具类
    /// </summary>
    public static class SortToolClass
    {
        /// <summary>
        /// 将数组进行冒泡排序，返回从小到大，排序好的数组
        /// </summary>
        /// <param name="arry"></param>
        /// <returns></returns>
        public static int[] BubbleSort(this int[] array)
        {
            for (int i = 0; i < array.Length -1; i++)
            {
                for (int j = 0; j < array.Length -1 -i; j++)    //由于大数往下沉，每次循环，最后一个必定是大树，所以减去i值
                {
                    int temp = array[j];    //记录当前元素

                    if(array[j] > array[j+1])   //跟后一个元素比较，大于则交换
                    {
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            return array;
        }

        /// <summary>
        /// 将数组进行选择排序，返回从小到大，排序好的数组
        /// </summary>
        /// <param name="arry"></param>
        /// <returns></returns>
        public static int[] SelectionSort(this int[] array)
        {
            int index = 0;  //存放每次最小数的索引位置
            int temp = 0;   //用来交换
            for (int i = 0; i < array.Length -1; i++)
            {
                index = i;
                for (int j = i+1; j < array.Length; j++)
                {
                    if(array[j] < array[index]) //每次记录小于的数，也可以记录最大数，试试更改为大于号
                    {
                        index = j;
                    }
                }
                temp = array[i];
                array[i] = array[index];
                array[index] = temp;
            }
            return array;
        }

        /// <summary>
        /// 将数组进行插入排序，返回从小到大，排序好的数组
        /// </summary>
        /// <param name="arry"></param>
        /// <returns></returns>
        public static int[] InsertSort(this int[] array)
        {
            for (int i = 1; i < array.Length; i++) {
                int index = i - 1;
                int temp = array[i];
                while (index >= 0 && array[index] > temp)
                { array[index + 1] = array[index--];
                }
                array[index + 1] = temp;
            }
            return array;
        }
    }
}