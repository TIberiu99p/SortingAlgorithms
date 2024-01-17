using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class InsertionSort
    {
        //Time complexity: O(n^2)
        // Function to perform insertion sort on an array
        public static void InsertionSortAlgorithm(int[] arr)
        {
            int n = arr.Length;

            // Start from the second element (index 1) as the first element is already considered sorted
            for (int i = 1; i < n; ++i)
            {
                // Choose the key to be inserted
                int key = arr[i];

                // Move elements of arr[0..i-1] that are greater than key to one position ahead of their current position
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }

                // Insert the key into its correct position
                arr[j + 1] = key;
            }
        }
    }
}
