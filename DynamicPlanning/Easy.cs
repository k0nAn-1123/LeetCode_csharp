using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.DynamicPlanning
{
    public class DynamicPlanning_Easy
    {

        public int MaxSubArray(int[] nums)
        {
            /*
             * https://leetcode-cn.com/problems/maximum-subarray/
             * 给定一个整数数组 nums ，找到一个具有最大和的连续子数组（子数组最少包含一个元素），返回其最大和。
             */
            int pre = 0, max = nums[0];
            foreach (int x in nums)
            {
                pre = Math.Max(pre + x, x);
                max = Math.Max(max, pre);
            }
            return max;
        }
        public int Massage(int[] nums)
        {
            /*
             * https://leetcode-cn.com/problems/the-masseuse-lcci/
             * 一个有名的按摩师会收到源源不断的预约请求，每个预约都可以选择接或不接。
             * 在每次预约服务之间要有休息时间，因此她不能接受相邻的预约。给定一个预约请求序列，
             * 替按摩师找到最优的预约集合（总预约时间最长），返回总的分钟数。
             */
            int n = nums.Length;
            if (n == 0)
                return 0;
            int dp0 = 0, dp1 = nums[0];

            for (int i = 1; i < n; ++i)
            {
                int tmp = Math.Max(dp0, dp1);
                dp1 = dp0 + nums[i];
                dp0 = tmp;
            }
            return Math.Max(dp0, dp1);
        }
        public bool DivisorGame(int N)
        {
            /*
             * https://leetcode-cn.com/problems/divisor-game/
             * 爱丽丝和鲍勃一起玩游戏，他们轮流行动。爱丽丝先手开局。
             * 最初，黑板上有一个数字 N 。在每个玩家的回合，玩家需要执行以下操作：
             * 选出任一 x，满足 0 < x < N 且 N % x == 0 。
             * 用 N - x 替换黑板上的数字 N 。
             * 如果玩家无法执行这些操作，就会输掉游戏。
             * 只有在爱丽丝在游戏中取得胜利时才返回 True，否则返回 False。假设两个玩家都以最佳状态参与游戏。
             */
            return N % 2 == 0;
        }
        public int MaxProfit(int[] prices)
        {
            /*
             * https://leetcode-cn.com/problems/best-time-to-buy-and-sell-stock/
             * 给定一个数组，它的第 i 个元素是一支给定股票第 i 天的价格。
             * 如果你最多只允许完成一笔交易（即买入和卖出一支股票一次），设计一个算法来计算你所能获取的最大利润。
             * 注意：你不能在买入股票前卖出股票。
             */
            int min = int.MaxValue;
            int max = int.MinValue;
            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < min)
                {
                    min = prices[i];
                }
                else if (prices[i] - min > max)
                {
                    max = prices[i] - min;
                }
            }
            return max;
        }
        public int Rob(int[] nums)
        {
            /*
             * https://leetcode-cn.com/problems/house-robber/
             * 你是一个专业的小偷，计划偷窃沿街的房屋。
             * 每间房内都藏有一定的现金，影响你偷窃的唯一制约因素就是相邻的房屋装有相互连通的防盗系统，如果两间相邻的房屋在同一晚上被小偷闯入，系统会自动报警。
             * 给定一个代表每个房屋存放金额的非负整数数组，计算你不触动警报装置的情况下，一夜之内能够偷窃到的最高金额。
             */
            int n = nums.Length;
            if (n == 0)
                return 0;
            int dp0 = 0, dp1 = nums[0];

            for (int i = 1; i < n; ++i)
            {
                int tmp = Math.Max(dp0, dp1);
                dp1 = dp0 + nums[i];
                dp0 = tmp;
            }
            return Math.Max(dp0, dp1);
        }
        public int MinCostClimbingStairs(int[] cost)
        {
            /*
             * https://leetcode-cn.com/problems/min-cost-climbing-stairs/
             * 数组的每个下标作为一个阶梯，第 i 个阶梯对应着一个非负数的体力花费值 cost[i]（下标从 0 开始）。
             * 每当你爬上一个阶梯你都要花费对应的体力值，一旦支付了相应的体力值，你就可以选择向上爬一个阶梯或者爬两个阶梯。
             * 请你找出达到楼层顶部的最低花费。在开始时，你可以选择从下标为 0 或 1 的元素作为初始阶梯。
             */
            int dp0 = cost[0], dp1 = cost[1];
            int min = 0;

            for(int i = 2; i < cost.Length; i++)
            {
                min = Math.Min(dp0 + cost[i], dp1 + cost[i]);
                if (i == cost.Length - 1)
                    continue;
                dp0 = dp1;
                dp1 = min;
            }
            return Math.Min(min, dp1);
        }
    }
}
