using System;

namespace CalSumMaxOfArr
{
    class Program
    {
        static int max1;
        static int max2;
        static int[] arr = { 1, -22, 3, 4, -665, -66 };
        static void Main(string[] args)
        {
            
            for(int i = 0; i<arr.Length-1;i++)
            {
                max2 = Math.Max(doSum(i,ref max1,0), max2);
                max1 = 0;
            }
            Console.WriteLine(max2);
        }
        static int doSum(int begin ,ref int max1,int sum)
        {
            if (begin == arr.Length)
                return max1;
            else
            {
                sum = sum + arr[begin];
                max1 = Math.Max(max1, sum);
                return doSum(begin + 1, ref max1, sum);
            }
        }
    }
}
