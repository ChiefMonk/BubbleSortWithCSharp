# CMPG323 Homework Exercise 1 & 2:  BubbleSort With C#
<img src="https://github.com/ChiefMonk/BubbleSortWithCSharp/blob/main/balloon-bubble-text.png" width="100" /> 

Bubble sort is a simple sorting algorithm. This sorting algorithm is a comparison-based algorithm in which each pair of adjacent elements is compared and the elements are swapped if they are not in order.

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

## Example
Let us see an example with 10 elements in an array and sort it.

```
  using System;

  namespace BubbleSort 
  {
     class MySort 
     {
        static void Main(string[] args) 
        {
           int[] arr = { 78, 55, 45, 98, 13 };
           int temp;

           for (int j = 0; j <= arr.Length - 2; j++) 
           {
              for (int i = 0; i <= arr.Length - 2; i++) 
              {
                 if (arr[i] > arr[i + 1]) 
                 {
                    temp= arr[i + 1];
                    arr[i + 1] = arr[i];
                    arr[i] = temp;
                 }
              }
           }

           Console.WriteLine("Sorted:");
           foreach (int p in arr)
           Console.Write(p + " ");
           Console.Read();
        }
     }
  }
```

## Output
Sorted:
```
13 45 55 78 98
```

## Links
* [Documentation](https://shinylib.net)
* [Bubble Sort program in C#](https://www.tutorialspoint.com/Bubble-Sort-program-in-Chash)
* [Samples](https://samples.shinylib.net)
* [Community Support](https://github.com/shinyorg/shiny/discussions)
* [NuGets](https://www.nuget.org/profiles/ShinyLib)

## Contributors
* [Chipo Hamayobe](https://github.com/ChiefMonk) - Project Lead
