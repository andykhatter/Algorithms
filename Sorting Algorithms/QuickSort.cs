using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Sorting_Algorithms
{
    class QuickSort
    {
        public void QuickSortAlgo(int[] nums,int left,int right)
        {
            if (left < right)
            {
                int pivot = partition(nums, left, right);
                if (pivot > 1)
                    QuickSortAlgo(nums, left, pivot - 1);

                if (pivot + 1 < right)
                    QuickSortAlgo(nums, pivot + 1, right);

            }
        }

        public int partition(int[] nums,int left, int right)
        {
            int pivot = nums[left]; // can be any number but choosing nums[(right+left)/2] can ncrease the efficieny

            while (true)
            {
                while (nums[left] < pivot)
                    left++;
                while (nums[right] > pivot)
                    right--;

                if (left < right)
                {
                    int temp = nums[left];
                    nums[left] = nums[right];
                    nums[right] = temp;

                }
                else
                    return right;
            }

            //return pivot;
        }
    }
}
