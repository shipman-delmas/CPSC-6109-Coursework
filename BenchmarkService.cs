using System.Diagnostics;
using CPSC_6109_Coursework.Sorting;

namespace CPSC_6109_Coursework;

/*
 * Author: Delmas Shipman
 * Class: CPSC 6109
 * Description: Coordinates all sorting algorithm classes and stores execution times as a string.
 * Last Modified: August 28, 2026
 */
public class BenchmarkService
{
    public string Benchmark(int[] data)
    {
        int n = data.Length;
        string result = "";

        // Clone data and start stopwatch. Execute specific algorithm with cloned data.
        int[] testData = (int[])data.Clone();
        Stopwatch timer = Stopwatch.StartNew();
        CountingSort.Sort(testData, testData.Max());
        timer.Stop();

        // Concatenate execution time to results string for return. 
        result += $"Counting Sort: {timer.Elapsed.TotalMilliseconds} ms \n";

        // Reuse test data array to prevent running out of memory.
        testData = (int[])data.Clone();
        int[] tempArr = new int[n];
        timer.Restart();
        MergeSort.Sort(testData, tempArr, n);
        timer.Stop();
        
        result += $"Merge Sort: {timer.Elapsed.TotalMilliseconds} ms \n";
        
        testData = (int[])data.Clone();
        timer.Restart();
        RadixSort.Sort(testData, n);
        timer.Stop();
        
        result += $"Radix Sort: {timer.Elapsed.TotalMilliseconds} ms \n";

        testData = (int[])data.Clone();
        timer.Restart();
        IntroSort.Sort(testData);
        timer.Stop();
        
        result += $"Intro Sort: {timer.Elapsed.TotalMilliseconds} ms \n";
        
        return result;
    }
}