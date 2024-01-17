using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class MergeSort
    {
        //sorting algorithm of O(n log n) time complexity 
        public static void Merge(int[] arr, int startIndex, int midIndex, int endIndex)
        {
            //sizes of temporary arrays
            int leftSubArraySize = midIndex - startIndex + 1;
            int rightSubArraySize = endIndex - midIndex;

            //Create temp arrays 
            int[] leftArray = new int[leftSubArraySize];
            int[] rightArray = new int[rightSubArraySize];

            //Copy Data to temp arrays L[] and R[]
            Array.Copy(arr, startIndex, leftArray, 0, leftSubArraySize);
            Array.Copy(arr, midIndex + 1, rightArray, 0, rightSubArraySize);

            int i = 0, j = 0;
            int k = startIndex;

            //merge the temp arrays back into arr[startIndex..endIndex]
            while(i <leftSubArraySize && j < rightSubArraySize)
            {
                if (leftArray[i] <= rightArray[j]) 
                {
                    arr[k] = leftArray[i];
                    i++;
                }
                else
                {
                    arr[k] = rightArray[j];
                    j++;
                }
                k++;
            }
            //copy remaining elements of leftArray[] if any
            while(i < leftSubArraySize)
            {
                arr[k] = leftArray[i];
                i++;
                k++;
            }

            //copy remaining elemetns of rightArray[] if any
            while(j < rightSubArraySize)
            {
                arr[k] = rightArray[j]; 
                j++; 
                k++;
            }
        }

        //Main function that sorts arr[left..right] using Merge()
        public static void Sort(int[] arr, int left, int right)
        {
            if(left < right)
            {
                //find middle point
                int mid = (left + right) / 2;

                //sort first and second halves
                Sort(arr, left, mid);
                Sort(arr, mid + 1, right);

                //Merge the sorted halves
                Merge(arr, left, mid, right);
            }
        }

        public static void MergeSortAlgorithm(int[] arr)
        {
            Sort(arr, 0, arr.Length - 1);
        }
    }
}
