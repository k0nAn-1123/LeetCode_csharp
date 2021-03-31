using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Sort
{
    public class SortService
    {
        #region 冒泡排序
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
        #endregion
        #region 选择排序
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
        #endregion
        #region 插入排序
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
        #endregion
        #region 归并排序
        public void MergeSort(int[] arr)
        {
            int[] temp = new int[arr.Length];
            InternalMergeSort(arr, temp, 0, arr.Length - 1);
        }
        private void InternalMergeSort(int[] arr, int[] tmp, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;
                InternalMergeSort(arr, tmp, left, middle);
                InternalMergeSort(arr, tmp, middle + 1, right);
                MergeSortedArray(arr, tmp, left, middle, right);
            }
        }
        private static void MergeSortedArray(int[] arr, int[] temp, int left, int middle, int right)
        {
            int i = left;
            int j = middle + 1;
            int k = 0;
            while (i <= middle && j <= right)
            {
                temp[k++] = arr[i] <= arr[j] ? arr[i++] : arr[j++];
            }
            while (i <= middle)
            {
                temp[k++] = arr[i++];
            }
            while (j <= right)
            {
                temp[k++] = arr[j++];
            }
            //把数据复制回原数组
            for (i = 0; i < k; ++i)
            {
                arr[left + i] = temp[i];
            }
        }
        #endregion
        #region 快速排序
        public void QuickSort(int[] arr)
        {
            QSort(arr, 0, arr.Length - 1);
        }
        public int Separate(int[] arr, int low, int high)
        {
            int sign = arr[low];
            while (low < high)
            {
                while (low < high && arr[high] >= sign) --high;
                arr[low] = arr[high];
                while (low < high && arr[low] <= sign) ++low;
                arr[high] = arr[low];
            }
            return sign;
        }
        public void QSort(int[] arr, int low, int high)
        {
            if (low >= high)
                return;
            int pivot = Separate(arr, low, high);
            QSort(arr, low, pivot - 1);
            QSort(arr, pivot + 1, high);
        }
        #endregion
        #region 
        #endregion
    }
}
