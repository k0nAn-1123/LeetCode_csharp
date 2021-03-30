using LeetCode.DynamicPlanning;
using LeetCode.SlidingWindow;
using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //DynamicPlanning_Easy code = new DynamicPlanning_Easy();
            //int[] cost = new int[] { 0, 0, 0, 1 };
            //int i = code.MinCostClimbingStairs(cost);
            //Console.WriteLine(i);
            SlidingWindow_Medium code = new SlidingWindow_Medium();
            string s = "pwwkew";
            int i = code.LengthOfLongestSubstring(s);
            Console.WriteLine(i);
        }
    }
}
