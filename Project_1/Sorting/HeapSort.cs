namespace CPSC_6109_Coursework.Sorting;

/*
 * Author: Delmas Shipman
 * Class: CPSC 6109
 * Description:
 * Sources: Code taken from GeeksForGeeks.com
 * Last Modified: August 27, 2026
 */
public class HeapSort
{
    // To heapify a subtree rooted with node i
    static void Heapify(int[] arr, int n, int i) {

        // Initialize largest as root
        int largest = i;

        // left index = 2*i + 1
        int l = 2 * i + 1;

        // right index = 2*i + 2
        int r = 2 * i + 2;

        // If left child is larger than root
        if (l < n && arr[l] > arr[largest])
            largest = l;

        // If right child is larger than largest so far
        if (r < n && arr[r] > arr[largest])
            largest = r;

        // If largest is not root
        if (largest != i) {
            (arr[i], arr[largest]) = (arr[largest], arr[i]);

            // Recursively heapify the affected sub-tree
            Heapify(arr, n, largest);
        }
    }

    // Main function to do heap sort
    public static void Sort(int[] arr) {
        int n = arr.Length;

        // Build heap (rearrange vector)
        for (int i = n / 2 - 1; i >= 0; i--)
            Heapify(arr, n, i);

        // One by one extract an element from heap
        for (int i = n - 1; i > 0; i--) {

            // Move current root to end
            (arr[0], arr[i]) = (arr[i], arr[0]);

            // Call max heapify on the reduced heap
            Heapify(arr, i, 0);
        }
    }
}