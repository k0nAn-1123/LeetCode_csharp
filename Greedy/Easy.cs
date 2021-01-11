using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Greedy
{
    public class Greedy_Easy
    {
        public bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            /*
             * https://leetcode-cn.com/problems/can-place-flowers/
             * 假设有一个很长的花坛，一部分地块种植了花，另一部分却没有。
             * 可是，花不能种植在相邻的地块上，它们会争夺水源，两者都会死去。
             * 给你一个整数数组 flowerbed 表示花坛，由若干 0 和 1 组成，其中 0 表示没种植花，1 表示种植了花。
             * 另有一个数n。能否在不打破种植规则的情况下种入 n 朵花？能则返回 true ，不能则返回 false。
             */
            if (n == 0)
                return true;
            for (int i = 0; i < flowerbed.Length; i+=2)
            {
                if (flowerbed[i] == 0)
                {
                    if (i == flowerbed.Length - 1 || flowerbed[i + 1] == 0)
                    {
                        n--;
                        if (n == 0)
                            return true;
                    }
                    else
                    {
                        i++;
                    }
                }
            }
            return false;
        }
        public IList<int> MinSubsequence(int[] nums)
        {
            /*
             * https://leetcode-cn.com/problems/minimum-subsequence-in-non-increasing-order/
             * 给你一个数组 nums，请你从中抽取一个子序列，满足该子序列的元素之和 严格 大于未包含在该子序列中的各元素之和。
             * 如果存在多个解决方案，只需返回 长度最小 的子序列。如果仍然有多个解决方案，则返回 元素之和最大 的子序列。
             * 与子数组不同的地方在于，「数组的子序列」不强调元素在原数组中的连续性，也就是说，它可以通过从数组中分离一些（也可能不分离）元素得到。
             * 注意，题目数据保证满足所有约束条件的解决方案是 唯一 的。同时，返回的答案应当按 非递增顺序 排列。
             */
        }
    }
}
