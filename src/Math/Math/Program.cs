namespace Math
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Console.WriteLine("Welcome to the calculator!");

			Console.WriteLine("\nNumbers for GCD, LCM and swapping");
			Console.WriteLine("----------------------------------");
			int a = Math.ReadInt();
			int b = Math.ReadInt();

			Console.WriteLine("\nYour array for mean, max, min, reverse and sort");
			Console.WriteLine("-----------------------------------------------");
			int[] arr = Math.ReadArr();

			int gcd = Math.GreatestCommonDivider(a, b);
			int lcm = Math.LeastCommonMultiple(a, b);

			int mean = Math.ArithmeticMean(arr);
			int max = Math.Max(arr);
			int min = Math.Min(arr);
			int[] swappedNumbers = Math.Swap(a, b);
			int[] reversedArray = Math.Reverse(arr);
			int[] sortedArray = Math.Sort(arr);

			Console.WriteLine("\nGCD and LCM");
			Console.WriteLine("------------");
			Math.PrintResult("GCD", a, b, gcd);
			Math.PrintResult("LCM", a, b, lcm);
			Console.WriteLine($"Swap: {swappedNumbers[0]}, {swappedNumbers[1]}");

			Console.WriteLine("\nMean, Max, Min, Swap, Reverse and Sort");
			Console.WriteLine("--------------------------------------");
			Console.WriteLine($"Mean: {mean}");
			Console.WriteLine($"Max: {max}");
			Console.WriteLine($"Min: {min}");
			Console.WriteLine($"Reverse: {string.Join(" ", reversedArray)}");
			Console.WriteLine($"Sort: {string.Join(" ", sortedArray)}");

			Console.ReadKey();
		}
	}
}
