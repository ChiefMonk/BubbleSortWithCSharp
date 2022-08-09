# CMPG 323 Development Homework Exercise 1 & 2: Bubble Sort Algorithm using C#
<img src="https://github.com/ChiefMonk/BubbleSortWithCSharp/blob/main/balloon-bubble-text.png" width="100" /> 

Bubble sort is a simple sorting algorithm. This sorting algorithm is a comparison-based algorithm in which each pair of adjacent elements is compared and the elements are swapped if they are not in order.

## Explanation
Let’s say our int has 5 elements −
```
int[] arr = { 78, 55, 45, 98, 13 };
```

Now, let us perform Bubble Sort.

Start with the first two elements 78 and 55. 55 is smaller than 78, so swap both of them. Now the list is −
```
55, 78,45,98, 13
```

Now 45 is less than 78, so swap it.
```
55, 45, 78, 98, 3
```

Now 98 is greater than 78, so keep as it is.
3 is less than 98, so swap it. Now the list looks like −
```
55, 45, 78, 3, 98
```

This was the first iteration. After performing all the iterations, e will get our sorted array using Bubble Sort −
```
3, 45, 55, 78, 93
```

## Code Example
Let us see an example with X elements in an array and sort it.
```
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
```

## Output
Sorted Array:
```
[ 13 45 55 78 98 ]
```

## Links
* [Bubble Sort documentation on Wikipedia](https://en.wikipedia.org/wiki/Bubble_sort)
* [Bubble Sort Algorithm](https://www.geeksforgeeks.org/bubble-sort/)
* [Bubble Sort program in C#](https://www.tutorialspoint.com/Bubble-Sort-program-in-Chash)

## Contributors
* [Chipo Hamayobe](https://github.com/ChiefMonk) - Project Lead
