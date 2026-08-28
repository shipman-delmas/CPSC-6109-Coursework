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

    public static void Sort(int[] arr)
    {
        int maxDepth = FindDepth(arr);
        Sort(arr, 0, arr.Length, maxDepth);
    }

    private static void Sort(int[] arr, int start, int end, int maxDepth)
    {
        int n = end - start;
        Random random = new();
        
        // last level; insertion sort.
        if (n < 16) { InsertionSort(arr, start, end); }
        // second level; heap sort.
        else if (maxDepth == 0)
        {
            int[] subArr = arr[start .. end];
            HeapSort.Sort(subArr);
            Array.Copy(subArr, 0, arr, start, n);
        }
        // first level; quicksort.
        else
        {
            int p = random.Next(0, n);
            int pivot = arr[p];

            (arr[p], arr[end - 1]) = (arr[end - 1], arr[p]);

            int storeIndex = start;

            for (int i = start; i < end - 1; ++i)
            {
                if (arr[i] < pivot)
                {
                    (arr[i], arr[storeIndex]) = (arr[storeIndex], arr[i]);
                    ++storeIndex;
                }
            }

            (arr[storeIndex], arr[end - 1]) = (arr[end - 1], arr[storeIndex]);
            
            Sort(arr, start, storeIndex, maxDepth - 1);
            Sort(arr, storeIndex + 1, end, maxDepth - 1);
        }
    }

    public static void InsertionSort(int[] arr)
    {
        InsertionSort(arr, 0, arr.Length);
    }
    
    // insertion sort simple enough to implement as single method; heap sort not so much...
    private static void InsertionSort(int[] arr, int start, int end)
    {
        for (int i = start + 1; i < end; i++)
        {
            int j = i;
            
            while (j > start && arr[j - 1] > arr[j])
            {
                (arr[j], arr[j - 1]) = (arr[j - 1], arr[j]);
                j--;
            }
        }
    }
}