using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.DynamicPlanning
{
    public class DynamicPlanning_Medium
    {
        #region DecodeString
        public string str = string.Empty;
        public string count = string.Empty;
        public Stack<int> stack1 = new Stack<int>();
        public Stack<string> stack2 = new Stack<string>();
        public string DecodeString(string s)
        {
            /*
             * https://leetcode-cn.com/problems/decode-string/
             * 给定一个整数数组 nums ，找到一个具有最大和的连续子数组（子数组最少包含一个元素），返回其最大和。
             */
            for (var i = 0; i < s.Length; i++)
            {
                if (s[i] <= '9' && s[i] >= '0')
                {
                    count += s[i];
                }
                if (s[i] <= 'z' && s[i] >= 'a')
                    str += s[i];
                if (s[i] == '[')
                {
                    stack1.Push(int.Parse(count));
                    stack2.Push(str);
                    str = string.Empty;
                    count = string.Empty;
                }
                if (s[i] == ']')
                {
                    int count = stack1.Pop();
                    string str1 = stack2.Pop();
                    str = str1 + GetString(count, str);
                    if (stack2.Count == 0)
                    {
                        stack1.Push(1);
                        stack2.Push(string.Empty);
                    }
                }
            }
            return str;
        }

        public string GetString(int count, string str)
        {
            string result = string.Empty;
            for (var i = 0; i < count; i++)
            {
                result += str;
            }
            return result;
        }
        #endregion
        public int LongestCommonSubsequence(string text1, string text2)
        {
            /*
             * https://leetcode-cn.com/problems/longest-common-subsequence/
             * 给定两个字符串 text1 和 text2，返回这两个字符串的最长公共子序列的长度。
             * 一个字符串的 子序列 是指这样一个新的字符串：它是由原字符串在不改变字符的相对顺序的情况下删除某些字符（也可以不删除任何字符）后组成的新字符串。
             * 例如，"ace" 是 "abcde" 的子序列，但 "aec" 不是 "abcde" 的子序列。两个字符串的「公共子序列」是这两个字符串所共同拥有的子序列。
             * 若这两个字符串没有公共子序列，则返回 0。
             */

        }
    }
}
