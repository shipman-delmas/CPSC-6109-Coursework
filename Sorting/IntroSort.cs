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
    private HeapSort heapSorter;
    
    private int maxDepth;
    
    // Max depth is the recursion depth; it prevents the initial quicksort algorithm from
    // degrading to worse case efficiency after a certain number of recursive calls.
    public void FindDepth(double[] arr)
    {
        maxDepth = (int)Math.Floor(Math.Log(arr.Length, 2)) * 2;
        Sort(arr, maxDepth);
    }

    public void Sort(double[] arr, int maxDepth)
    {
        int n = arr.Length;
        Random random = new();
        
        // last level; insertion sort.
        if (n < 16) { InsertionSort(arr); }
        // second level; heap sort.
        else if (maxDepth == 0) { }
        // first level; quicksort.
        else
        {
            int p = random.Next(0, n);

            // indexing for partitions may be incorrect.
            // unsure if reference algorithm means [0] or [1] by the pseudocode "A[1:p-1]."
            // pseudocode meant [p] by [p-1] in terms of c# indexing.
            double[] leftArr = arr[0 .. p];
            double[] rightArr = arr[(p + 1) .. n];
            
            Sort(leftArr, maxDepth - 1);
            Sort(rightArr, maxDepth - 1);
        }
    }
    
    // insertion sort simple enough to implement as single method; heap sort not so much...
    public void InsertionSort(double[] arr)
    {
        int i = 1;
        while (i < arr.Length)
        {
            int j = i;
            while (j > 0 && arr[j - 1] > arr[j])
            {
                // swap using c# deconstruction syntax.
                (arr[j], arr[j - 1]) = (arr[j - 1], arr[j]);
                --j;
            }

            ++i;
        }
    }
}