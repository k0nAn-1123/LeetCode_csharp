using LeetCode.DynamicPlanning;
using LeetCode.Sort;
using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 5, 3, 6, 1, 4, 8, 2, 7 };
            SortService sort = new SortService();
            sort.InsertSort(arr);
            foreach (var i in arr)
            {
                Console.Write(i + " ");
            }
        }
    }
}
