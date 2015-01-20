using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Sorting_Algorithms
{
    class MergeSort
    {
        public int[] arrToBbeSorted;
       public MergeSort(int[] arrayToSort)
        {
            arrToBbeSorted = arrayToSort;
            RecMergeSort(arrayToSort, 0, arrayToSort.Count() - 1);
        }

        public void RecMergeSort(int[] tempArray,int lower_bound,int upper_bound)
        {
            if (lower_bound == upper_bound)
                return;

            else
            {
                int mid = (lower_bound + upper_bound) / 2;
                RecMergeSort(tempArray, lower_bound, mid);
                RecMergeSort(tempArray, mid+1, upper_bound);
                MainMerge(tempArray, lower_bound, mid + 1, upper_bound);
            }
        }

         public void MainMerge(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[25];
            int i, eol, num, pos;

            eol = (mid - 1);
            pos = left;
            num = (right - left + 1);

            while ((left <= eol) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[pos++] = numbers[left++];
                else
                    temp[pos++] = numbers[mid++];
            }

            while (left <= eol)
                temp[pos++] = numbers[left++];

            while (mid <= right)
                temp[pos++] = numbers[mid++];

            for (i = 0; i < num; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
            arrToBbeSorted = numbers;
            showArray();
        }
       

        public void showArray()
        {
            for (int i = 0; i < arrToBbeSorted.Count(); i++)
            {
                Console.Write(arrToBbeSorted[i]+" ");
                
            }
            Console.WriteLine();
        }
    }
}
