using System.Diagnostics;
using CPSC_6109_Coursework.Sorting;

namespace CPSC_6109_Coursework;

public class BenchmarkService
{
    // FIX: refactor algorithms to use int[] instead of double[].
    //      And all methods to static.
    // ALSO: test data is probably mutating with each algorithm.
    public string Benchmark(int[] data)
    {
        int n = data.Length;
        
        CountingSort.Sort(data, data.Max());
        
        // merge sort.
        int[] tempArr = new int[n];
        MergeSort.Copy(tempArr, data, n);
        // MergeSort.Merge(data, )
        
        return $"";
    }
}