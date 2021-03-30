using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.SlidingWindow
{
    public class SlidingWindow_Medium
    {
        public int LengthOfLongestSubstring(string s)
        {
            /*
             * https://leetcode-cn.com/problems/longest-substring-without-repeating-characters/
             * 给定一个字符串，请你找出其中不含有重复字符的 最长子串 的长度。
             */
            int i = 0;
            int sum = 0;
            Queue<char> queue = new Queue<char>();
            while (i < s.Length)
            {
                if (!queue.Contains(s[i]))
                {
                    queue.Enqueue(s[i]);
                    sum = Math.Max(sum, queue.Count);
                    i++;
                }
                else
                {
                    queue.Dequeue();
                }
            }
            return sum;
        }
    }
}
