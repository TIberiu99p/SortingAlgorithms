using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    //Time complexity: O(n^2) in the worst case, O(n log n) on average
    public class QuickSort
    {
        // Partition the array into two halves using a pivot
        public static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                // If the current element is smaller than the pivot
                if (arr[j] < pivot)
                {
                    i++;

                    // Swap arr[i] and arr[j]
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            // Swap arr[i+1] and arr[high] (pivot)
            int temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }

        // Recursive function to sort the array using QuickSort
        public static void Sort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                // Find the pivot such that elements smaller than pivot are on the left
                // and elements greater than pivot are on the right
                int pi = Partition(arr, low, high);

                // Recursively sort the subarrays
                Sort(arr, low, pi - 1);
                Sort(arr, pi + 1, high);
            }
        }

        // QuickSort function that calls Sort
        public static void QuickSortAlgorithm(int[] arr)
        {
            Sort(arr, 0, arr.Length - 1);
        }

    }
}
