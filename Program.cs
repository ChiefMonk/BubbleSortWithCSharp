using System;

namespace CMPG323._37016776.BubbleSort
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("CMPG 323 Homework Exercise 1 & 2: Bubble Sort Algorithm using C");
			Console.WriteLine();


			int arraySize = 0;

			while (arraySize < 2)
			{
				try
				{
					Console.Write("How many integers go you want to sort:  ");
					arraySize = int.Parse(Console.ReadLine() ?? string.Empty);
				}
				catch
				{
					Console.WriteLine("Please enter a valid integer greater than 2");
					Console.WriteLine();
				}
			}

			Console.WriteLine();
			Console.WriteLine($"Please enter the {arraySize} integers to be sorted, one at a time");
			int[] inputArray = new int[arraySize];
			int counter = 0;

			while (counter < arraySize)
			{
				try
				{
					Console.Write($"Enter integer {counter + 1}: ");
					inputArray[counter] = int.Parse(Console.ReadLine() ?? string.Empty);
					counter++;
				}
				catch
				{
					Console.WriteLine("Please enter a valid integer");
					Console.WriteLine();
				}
			}

			BubbleSortArray(inputArray);
			Console.WriteLine();
			Console.Write("Sorted Array: [ ");
			foreach (var p in inputArray)
				Console.Write(p + " ");
			Console.Write("]");
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("Press ENTER to Exit the program");
			Console.Read();
		}

		private static void BubbleSortArray(int[] inputArray)
		{
			for (int j = 0; j <= inputArray.Length - 2; j++)
			{
				for (int i = 0; i <= inputArray.Length - 2; i++)
				{
					if (inputArray[i] > inputArray[i + 1])
					{
						var temp = inputArray[i + 1];
						inputArray[i + 1] = inputArray[i];
						inputArray[i] = temp;
					}
				}
			}
		}
	}
}





