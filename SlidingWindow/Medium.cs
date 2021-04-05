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
        public int MaxArea(int[] height)
        {
            /*
             * https://leetcode-cn.com/problems/container-with-most-water/
             * 给你 n 个非负整数 a1，a2，...，an，每个数代表坐标中的一个点 (i, ai) 。在坐标内画 n 条垂直线，垂直线 i 的两个端点分别为 (i, ai) 和 (i, 0) 。找出其中的两条线，使得它们与 x 轴共同构成的容器可以容纳最多的水。
             */
            int l = 0, r = height.Length - 1;
            int ans = 0;
            while (l < r)
            {
                int area = Math.Min(height[l], height[r]) * (r - l);
                ans = Math.Max(ans, area);
                if (height[l] <= height[r])
                {
                    ++l;
                }
                else
                {
                    --r;
                }
            }
            return ans;
        }
    }
}
