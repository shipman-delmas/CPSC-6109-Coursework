namespace CPSC_6109_Coursework;

/*
 * Author: Delmas Shipman
 * Class: CPSC 6109
 * Description:
 * Last Modified: August 25, 2026
 */
public class Program
{
	public static void Main()
	{
		TestDataGenerator generator = new();
		BenchmarkService benchmark = new();

		string first = benchmark.Benchmark(generator.Generate(10));
		string second = benchmark.Benchmark(generator.Generate(11));
		string third = benchmark.Benchmark(generator.Generate(12));
		
		Console.WriteLine();
	}
}