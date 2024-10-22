namespace Math
{
	public class Math
	{
		public static int GreatestCommonDivider(int a, int b)
		{
			if (b == 0)
			{
				return a;
			}
			else
			{
				return GreatestCommonDivider(b, a % b);
			}
		}

		public static int LeastCommonMultiple(int a, int b)
		{
			return a * b / GreatestCommonDivider(a, b);
		}

		public static int ArithmeticMean(int[] arr)
		{
			int sum = 0;

			foreach (int i in arr)
			{
				sum += i;
			}

			return sum / arr.Length;
		}

		public static int Max(int[] arr)
		{
			int max = arr[0];

			foreach (int i in arr)
			{
				if (i > max)
				{
					max = i;
				}
			}

			return max;
		}

		public static int Min(int[] arr)
		{
			int min = arr[0];

			foreach (int i in arr)
			{
				if (i < min)
				{
					min = i;
				}
			}

			return min;
		}

		public static int[] Swap(int a, int b)
		{
			(a, b) = (b, a);
			return [a, b];
		}

		public static int[] Reverse(int[] arr)
		{
			int[] reversedArr = new int[arr.Length];
			for (int i = 0; i < arr.Length; i++)
			{
				reversedArr[i] = arr[arr.Length - 1 - i];
			}

			return reversedArr;
		}

		public static int[] Sort(int[] arr)
		{
			Array.Sort(arr);
			return arr;
		}

		public static int ReadInt()
		{
			Console.Write("Type in a positive integer: ");
			string input = Console.ReadLine();

			if (int.TryParse(input, out int result) && result > 0)
			{
				return result;
			}
			else
			{
				Console.WriteLine("Invalid input. Please try again.");
				return ReadInt();
			}
		}

		public static int ReadInt(string prompt)
		{
			Console.Write(prompt);
			string input = Console.ReadLine();

			if (int.TryParse(input, out int result) && result > 0)
			{
				return result;
			}
			else
			{
				Console.WriteLine("Invalid input. Please try again.");
				return ReadInt(prompt);
			}
		}

		public static int[] ReadArr()
		{
			int numOfNumbers = ReadInt("Length of the array: ");
			int[] arr = new int[numOfNumbers];

			for (int i = 0; i < numOfNumbers; i++)
			{
				arr[i] = ReadInt();
			}

			return arr;
		}

		public static void PrintResult(string type, int a, int b, int result)
		{
			Console.WriteLine($"{type} of {a} and {b} is {result}");
		}
	}
}