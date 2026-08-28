namespace CPSC_6109_Coursework.Sorting;

/*
 * Author: Delmas Shipman
 * Class: CPSC 6109
 * Description: Implements an introspective sort algorithm; initially sorts by quicksort,
 *              but switches to heapsort after a certain number of recursive calls to avoid
 *              worse case time complexity O(n^2).
 * Sources: Algorithm steps from Wikipedia.
 *          Theoretical concepts from GeeksForGeeks.
 * Last Modified: August 24, 2026
 */
public class IntroSort
{
    private int maxDepth;
    
    // Max depth is the recursion depth; it prevents the initial quicksort algorithm from
    // degrading to worse case efficiency after a certain number of recursive calls.
    public static int FindDepth(int[] arr)
    {
        return (int)Math.Floor(Math.Log(arr.Length, 2)) * 2;
    }

    // Wrapper method finds max depth of given unsorted array and calls private method.
    public static void Sort(int[] arr)
    {
        int maxDepth = FindDepth(arr);
        Sort(arr, 0, arr.Length, maxDepth);
    }

    // Primary intro sort algorithm. Coordinates switching between sorting algorithms. 
    private static void Sort(int[] arr, int start, int end, int maxDepth)
    {
        int n = end - start;
        Random random = new();
        
        // Switch to insertion sort once array length is small enough.
        if (n < 16) { InsertionSort(arr, start, end); }
        // Switch to heap sort if recursive depth has been reached.
        else if (maxDepth == 0)
        {
            int[] subArr = arr[start .. end];
            HeapSort.Sort(subArr);
            Array.Copy(subArr, 0, arr, start, n);
        }
        // Begin with quicksort.
        else
        {
            // Set random index as pivot.
            int p = random.Next(0, n);
            int pivot = arr[p];

            // Swap pivot value with last index value.
            (arr[p], arr[end - 1]) = (arr[end - 1], arr[p]);

            // Track sorted partition start index. 
            int storeIndex = start;

            // Iterate indices and move values less than pivot to sorted partition.
            for (int i = start; i < end - 1; ++i)
            {
                if (arr[i] < pivot)
                {
                    (arr[i], arr[storeIndex]) = (arr[storeIndex], arr[i]);
                    ++storeIndex;
                }
            }

            // Swap pivot value with start index of sorted partition.
            (arr[storeIndex], arr[end - 1]) = (arr[end - 1], arr[storeIndex]);
            
            // Recursive calls to sort both sides. 
            Sort(arr, start, storeIndex, maxDepth - 1);
            Sort(arr, storeIndex + 1, end, maxDepth - 1);
        }
    }

    public static void InsertionSort(int[] arr)
    {
        InsertionSort(arr, 0, arr.Length);
    }
    
    // Insertion sort within intro sort begins once unsorted portion of input is reduced to small enough size.
    private static void InsertionSort(int[] arr, int start, int end)
    {
        // Consider first index sorted and begin at second index. 
        for (int i = start + 1; i < end; i++)
        {
            int j = i;
            
            // Compares value at current index to value of previous index and swaps them if less than previous value.
            while (j > start && arr[j - 1] > arr[j])
            {
                (arr[j], arr[j - 1]) = (arr[j - 1], arr[j]);
                j--;
            }
        }
    }
}