using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    //Time complexity: O(n log^2 n) in the worst case
    public class ShellSort
    {
        // Function to perform shell sort on an array
        public static void ShellSortAlgorithm(int[] arr)
        {
            int n = arr.Length;

            // Start with a large gap, then reduce the gap
            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                // Do a gapped insertion sort for this gap size.
                // The first gap elements a[0..gap-1] are already in gapped order
                // Keep adding one more element until the entire array is gap sorted
                for (int i = gap; i < n; i += 1)
                {
                    // Add a[i] to the elements that have been gap sorted
                    // Save a[i] in temp and make a hole at position i
                    int temp = arr[i];

                    // Shift earlier gap-sorted elements up until the correct location for a[i] is found
                    int j;
                    for (j = i; j >= gap && arr[j - gap] > temp; j -= gap)
                    {
                        arr[j] = arr[j - gap];
                    }

                    // Put temp (the original a[i]) in its correct location
                    arr[j] = temp;
                }
            }
        }
    }
}
