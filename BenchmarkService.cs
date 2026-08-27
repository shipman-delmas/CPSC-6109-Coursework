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
        string result = "";

        int[] countingData = data;
        int[] mergeData = data;
        int[] radixData = data;
        int[] introData = data;

        Stopwatch timer = Stopwatch.StartNew();
        CountingSort.Sort(countingData, countingData.Max());
        timer.Stop();

        result += $"Counting Sort: {timer.Elapsed.TotalMilliseconds} ms \n";

        timer.Restart();
        int[] tempArr = new int[n];
        MergeSort.Sort(mergeData, tempArr, n);
        timer.Stop();
        
        result += $"Merge Sort: {timer.Elapsed.TotalMilliseconds} ms \n";
        
        timer.Restart();
        RadixSort.Sort(radixData, n);
        timer.Stop();
        
        result += $"Radix Sort: {timer.Elapsed.TotalMilliseconds} ms \n";

        timer.Restart();
        IntroSort.Sort(introData);
        timer.Stop();
        
        result += $"Intro Sort: {timer.Elapsed.TotalMilliseconds} ms \n";
        
        return result;
    }
}