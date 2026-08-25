namespace CPSC_6109_Coursework.Sorting;

/*
 * Author: Delmas Shipman
 * Class: CPSC 6109
 * Description: Implements a counting sort algorithm; counts frequency of values in unsorted array and creates
 *              histogram in auxiliary array. Finds index ranges for sorted array in which aspecific value should
 *              be placed. 
 * Sources: Algorithm steps from Wikipedia.
 * Last Modified: August 25, 2026
 */
public class CountingSort
{
    // k = n max.
    // counting sort cannot compute floating point or non-whole numbers.
    // only effective for unsorted arrays of repeating values.
    public int[] Sort(int[] arr, int k)
    {
        int n = arr.Length;
        
        // count auxiliary array stores count of items with same key.
        int[] count = new int[k + 1];
        int[] sortedArr = new int[n];

        // histogram of value frequencies in unsorted array.
        for (int i = 0; i < n - 1; ++i)
        {
            // increment index in auxiliary array equal to value in unsorted array.
            int j = arr[i];
            ++count[j];
        }

        // prefix sum for range in which specific value should be placed. 
        for (int i = 1; i < k; ++i)
        {
            // iterate each index of auxiliary array and add value of previous index.
            count[i] += count[i - 1];
        }

        // reverse iteration over unsorted array and moves each value to sorted position in sorted array.
        for (int i = n - 1; i > 0; --i)
        {
            // j = value at index i unsorted array.
            int j = arr[i];
            // decrement count for that index in auxiliary array.
            --count[j];
            // place value of index i unsorted array at index == count in of value in auxiliary array index.
            sortedArr[count[j]] = arr[i];
        }

        return sortedArr;
    }
}