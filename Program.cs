namespace CPSC_6109_Coursework;

/*
 * Author: Delmas Shipman
 * Class: CPSC 6109
 * Description:
 * Last Modified: August 27, 2026
 */
public class Program
{
	public static void Main()
	{
		TestDataGenerator generator = new();
		BenchmarkService benchmark = new();

		int firstInputSize = 8000;
		int secondInputSize = 16000;
		int thirdInputSize = 24000;
		int fourthInputSize = 32000;
		int fifthInputSize = 40000;

		Console.WriteLine("Benchmarking First Dataset...");
		Console.WriteLine("First Run...");
		string firstDataSet1 = benchmark.Benchmark(generator.Generate(firstInputSize));
		Console.WriteLine("Complete.");
		
		Console.WriteLine("Second Run...");
		string firstDataSet2 = benchmark.Benchmark(generator.Generate(firstInputSize));
		Console.WriteLine("Complete.");
		
		Console.WriteLine("Third Run...");
		string firstDataSet3 = benchmark.Benchmark(generator.Generate(firstInputSize));
		Console.WriteLine("Complete.");
		Console.WriteLine("First Dataset Benchmarked.");
		
		Console.WriteLine("Benchmarking Second Dataset...");
		Console.WriteLine("First Run...");
		string secondDataSet1 = benchmark.Benchmark(generator.Generate(secondInputSize));
		Console.WriteLine("Complete.");
		
		Console.WriteLine("Second Run...");
		string secondDataSet2 = benchmark.Benchmark(generator.Generate(secondInputSize));
		Console.WriteLine("Complete.");
		
		Console.WriteLine("Third Run...");
		string secondDataSet3 = benchmark.Benchmark(generator.Generate(secondInputSize));
		Console.WriteLine("Complete.");
		Console.WriteLine("Second Dataset Benchmarked.");
		
		Console.WriteLine("Benchmarking Third Dataset...");
		Console.WriteLine("First Run...");
		string thirdDataSet1 = benchmark.Benchmark(generator.Generate(thirdInputSize));
		Console.WriteLine("Complete.");
		
		Console.WriteLine("Second Run...");
		string thirdDataSet2 = benchmark.Benchmark(generator.Generate(thirdInputSize));
		Console.WriteLine("Complete.");
		
		Console.WriteLine("Third Run...");
		string thirdDataSet3 = benchmark.Benchmark(generator.Generate(thirdInputSize));
		Console.WriteLine("Complete.");
		Console.WriteLine("Third Dataset Benchmarked.");
		
		Console.WriteLine("Benchmarking Fourth Dataset...");
		Console.WriteLine("First Run...");
		string fourthDataSet1 = benchmark.Benchmark(generator.Generate(firstInputSize));
		Console.WriteLine("Complete.");
		
		Console.WriteLine("Second Run...");
		string fourthDataSet2 = benchmark.Benchmark(generator.Generate(firstInputSize));
		Console.WriteLine("Complete.");
		
		Console.WriteLine("Third Run...");
		string fourthDataSet3 = benchmark.Benchmark(generator.Generate(firstInputSize));
		Console.WriteLine("Complete.");
		Console.WriteLine("Fourth Dataset Benchmarked.");
		
		Console.WriteLine("Benchmarking Fifth Dataset...");
		Console.WriteLine("First Run...");
		string fifthDataSet1 = benchmark.Benchmark(generator.Generate(firstInputSize));
		Console.WriteLine("Complete.");
		
		Console.WriteLine("Second Run...");
		string fifthDataSet2 = benchmark.Benchmark(generator.Generate(firstInputSize));
		Console.WriteLine("Complete.");
		
		Console.WriteLine("Third Run...");
		string fifthDataSet3 = benchmark.Benchmark(generator.Generate(firstInputSize));
		Console.WriteLine("Complete.");
		Console.WriteLine("Fifth Dataset Benchmarked.");
		
		Console.WriteLine("-----------------------------------------");
		
		Console.Write($"Input Size: n = {firstInputSize} \n" +
		                  $"\n Run #1: \n" +
		                  $"{firstDataSet1} \n" +
		                  $"Run #2: \n" +
		                  $"{firstDataSet2} \n" +
		                  $"Run #3: \n" +
		                  $"{firstDataSet3}");
		
		Console.WriteLine("-----------------------------------------");
		
		Console.Write($"Input Size: n = {secondInputSize} \n" +
		              $"\n Run #1: \n" +
		              $"{secondDataSet1} \n" +
		              $"Run #2: \n" +
		              $"{secondDataSet2} \n" +
		              $"Run #3: \n" +
		              $"{secondDataSet3}");
		
		Console.WriteLine("-----------------------------------------");
		
		Console.Write($"Input Size: n = {thirdInputSize} \n" +
		              $"\n Run #1: \n" +
		              $"{thirdDataSet1} \n" +
		              $"Run #2: \n" +
		              $"{thirdDataSet2} \n" +
		              $"Run #3: \n" +
		              $"{thirdDataSet3}");
		
		Console.WriteLine("-----------------------------------------");
		
		Console.Write($"Input Size: n = {fourthInputSize} \n" +
		              $"\n Run #1: \n" +
		              $"{fourthDataSet1} \n" +
		              $"Run #2: \n" +
		              $"{fourthDataSet2} \n" +
		              $"Run #3: \n" +
		              $"{fourthDataSet3}");
		
		Console.WriteLine("-----------------------------------------");
		
		Console.Write($"Input Size: n = {fifthInputSize} \n" +
		              $"\n Run #1: \n" +
		              $"{fifthDataSet1} \n" +
		              $"Run #2: \n" +
		              $"{fifthDataSet2} \n" +
		              $"Run #3: \n" +
		              $"{fifthDataSet3}");
		
		Console.WriteLine("-----------------------------------------");
	}
}