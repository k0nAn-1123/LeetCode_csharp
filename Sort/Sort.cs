using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Sort
{
    public class SortService
    {
        public void BubbleSort(int[] arr)
        {
            for (int i = arr.Length - 1; i > 0; i--)
            {
                bool swap = false;
                for (int j = 0; j < i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swap = true;
                    }
                }
                if (!swap)
                    break;
            }
        }
        public void SelectionSort(int[] arr)
        {
            for (var i = 0; i < arr.Length; i++)
            {
                int min = int.MaxValue;
                int temp = int.MaxValue;
                for (var j = i; j < arr.Length; j++)
                {
                    if (arr[j] < temp)
                    {
                        temp = arr[j];
                        min = j;
                    }
                }
                if (min != i)
                {
                    int tmp = arr[i];
                    arr[i] = arr[min];
                    arr[min] = tmp;
                }
            }
        }
        public void InsertSort(int[] arr)
        {
            for (var i = 1; i < arr.Length; i++)
            {
                for (var j = i; j > 0; j--)
                {
                    if (arr[j] < arr[j - 1])
                    {
                        int tmp = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = tmp;
                    }
                    else
                        break;
                }
            }
        }
        public void MergeSort(int[] arr)
        {

        }
    }
}
