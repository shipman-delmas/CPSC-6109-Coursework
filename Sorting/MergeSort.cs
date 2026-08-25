namespace CPSC_6109_Coursework.Sorting;

/*
 * Author: Delmas Shipman
 * Class: CPSC 6109
 * Description: Implements a bottom-up, vector/array-based merge sort algorithm;
 * Sources: Algorithm steps from Wikipedia.
 * Last Modified: August 25, 2026
 */
public class MergeSort
{
    // shouldn't array 'a' be the temp array and 'b' the source array in the copy method?
    public void Copy(double[] tempArr, double[] sourceArr, int n)
    {
        // copies elements from a source array into a temporary array.
        for (int i = 0; i < n; ++i)
        {
            sourceArr[i] = tempArr[i];
        }
    }

    public void Merge(double[] sourceArr, int left, int right, int end, double[] tempArr)
    {
        int i = left;
        int j = right;

        // while there are elements in left or right partitions.
        for (int k = left; k < end; ++k)
        {
            // if left partition exists and is <= right partition. 
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

    public void Sort(double[] sourceArr, double[] tempArr, int n)
    {
        for (int width = 1; width < n; width *= 2)
        {
            for (int i = 0; i < n; i += width * 2)
            {
                Merge(sourceArr, i, Math.Min(i + width, n), Math.Min(1 + 2 * width, n), tempArr);
            }

            Copy(tempArr, sourceArr, n);
        }
    }
}