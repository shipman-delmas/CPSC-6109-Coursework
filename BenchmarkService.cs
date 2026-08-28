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

        int[] original = data;

        int[] testData = (int[])original.Clone();
        Stopwatch timer = Stopwatch.StartNew();
        CountingSort.Sort(testData, testData.Max());
        timer.Stop();

        result += $"Counting Sort: {timer.Elapsed.TotalMilliseconds} ms \n";

        testData = (int[])original.Clone();
        timer.Restart();
        int[] tempArr = new int[n];
        MergeSort.Sort(testData, tempArr, n);
        timer.Stop();
        
        result += $"Merge Sort: {timer.Elapsed.TotalMilliseconds} ms \n";
        
        testData = (int[])original.Clone();
        timer.Restart();
        RadixSort.Sort(testData, n);
        timer.Stop();
        
        result += $"Radix Sort: {timer.Elapsed.TotalMilliseconds} ms \n";

        testData = (int[])original.Clone();
        timer.Restart();
        IntroSort.Sort(testData);
        timer.Stop();
        
        result += $"Intro Sort: {timer.Elapsed.TotalMilliseconds} ms \n";
        
        return result;
    }
}