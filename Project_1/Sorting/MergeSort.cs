namespace CPSC_6109_Coursework.Sorting;

/*
 * Author: Delmas Shipman
 * Class: CPSC 6109
 * Description: Implements a bottom-up, vector/array-based merge sort algorithm; begin by merging (not splitting
 *              like in top-down) sub-arrays of length n = 1. 
 * Sources: Algorithm steps from Wikipedia.
 * Last Modified: August 25, 2026
 */
public class MergeSort
{
    public static void Copy(int[] tempArr, int[] sourceArr, int n)
    {
        // Moves merged sub-arrays from temporary array back to source array.
        for (int i = 0; i < n; ++i)
        {
            sourceArr[i] = tempArr[i];
        }
    }

    public static void Merge(int[] sourceArr, int left, int right, int end, int[] tempArr)
    {
        // Pointers to current elements in sorted sub-arrays.
        int i = left;
        int j = right;

        // Write elements from sorted sub-arrays to temporary array.
        for (int k = left; k < end; ++k)
        {
            // Write left value if less than right value or if right sub-array is exhausted.
            if ((i < right) && (j >= end || sourceArr[i] <= sourceArr[j]))
            {
                tempArr[k] = sourceArr[i];
                ++i;
            }
            else
            {
                tempArr[k] = sourceArr[j];
                ++j;
            }
        }
    }

    
    public static void Sort(int[] sourceArr, int[] tempArr, int n)
    {
        // Outer loop controls size of sorted sub-arrays being merged.
        for (int width = 1; width < n; width *= 2)
        {
            // Inner loop selects which adjacent sub-arrays merge.
            for (int i = 0; i < n; i += width * 2)
            {
                Merge(sourceArr, i, Math.Min(i + width, n), Math.Min(1 + 2 * width, n), tempArr);
            }

            Copy(tempArr, sourceArr, n);
        }
    }
}