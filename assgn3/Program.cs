// //1.Read n integers from the user and print them.
// Console.Write("Enter number of elements: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[] numbers = new int[n];

// for (int i = 0; i < n; i++)
// {
//     Console.Write($"Enter number {i + 1}: ");
//     numbers[i] = Convert.ToInt32(Console.ReadLine());
// }

// Console.WriteLine("Array elements:");

// for (int i = 0; i < n; i++)
// {
//     Console.WriteLine(numbers[i]);
// }

// //2.Calculate the sum and average of elements in an integer array.
// int[] numbers = { 10, 20, 30, 40, 50 };

// int sum = 0;

// for (int i = 0; i < numbers.Length; i++)
// {
//     sum = sum + numbers[i];
// }

// double average = (double)sum / numbers.Length;

// Console.WriteLine("Sum: " + sum);
// Console.WriteLine("Average: " + average);

// //3. Find the largest and smallest number in an array.
// int[] numbers = { 35, 10, 5, 25, 30 };

// int largest = numbers[0];
// int smallest = numbers[0];

// foreach (int number in numbers)
// {
//     if (number > largest)
//     {
//         largest = number;
//     }

//     if (number < smallest)
//     {
//         smallest = number;
//     }
// }

// Console.WriteLine("Largest: " + largest);
// Console.WriteLine("Smallest: " + smallest);

// //4. Count how many even and odd numbers are present.
// int[] numbers = { 10, 13, 20, 75, 40 };

// int evenCount = 0;
// int oddCount = 0;

// foreach (int number in numbers)
// {
//     if (number % 2 == 0)
//     {
//         evenCount++;
//     }
//     else
//     {
//         oddCount++;
//     }
// }

// Console.WriteLine("Even numbers: " + evenCount);
// Console.WriteLine("Odd numbers: " + oddCount);

// //5. Reverse the array without using built-in reverse methods.
// int[] numbers = { 33, 34, 64, 32, 57 };

// for (int i = numbers.Length - 1; i >= 0; i--)
// {
//     Console.Write(numbers[i] + " ");
// }

// //6. Find the second largest number in an array.
// int[] numbers = {2, 43, 4, 75, 23, 67 };

// int largest = int.MinValue;
// int secondLargest = int.MinValue;

// foreach (int number in numbers)
// {
//     if (number > largest)
//     {
//         secondLargest = largest;
//         largest = number;
//     }
//     else if (number > secondLargest && number != largest)
//     {
//         secondLargest = number;
//     }
// }

// Console.WriteLine("Second largest: " + secondLargest);

// //7. Remove duplicate values from an array.
// int[] numbers = { 3, 4, 6, 3, 6 };

// int index = 0;

// foreach (int number in numbers)
// {
//     bool duplicate = false;

//     for (int i = 0; i < index; i++)
//     {
//         if (numbers[i] == number)
//         {
//             duplicate = true;
//             break;
//         }
//     }

//     if (!duplicate)
//     {
//         Console.Write(number + " ");
//     }

//     index++;
// }

// //8. Sort the array in ascending order (without using Array.Sort()).
// int[] numbers = { 6,2,6,1,3,75,34 };

// for (int i = 0; i < numbers.Length - 1; i++)
// {
//     for (int j = 0; j < numbers.Length - 1 - i; j++)
//     {
//         if (numbers[j] > numbers[j + 1])
//         {
//             int temp = numbers[j];
//             numbers[j] = numbers[j + 1];
//             numbers[j + 1] = temp;
//         }
//     }
// }

// foreach (int number in numbers)
// {
//     Console.Write(number + " ");
// }

// //9. Find the missing number in a range 1 to n.
// int[] numbers = { 2,3,4,5};

// int n = 5;

// int expectedSum = n * (n + 1) / 2;

// int actualSum = 0;

// foreach (int number in numbers)
// {
//     actualSum = actualSum + number;
// }

// int missingNumber = expectedSum - actualSum;

// Console.WriteLine("Missing number: " + missingNumber);

// //10.Find common elements between two arrays.
// int[] array1 = { 5, 7, 2, 6};
// int[] array2 = { 2, 4, 5, 2, 6};

// Console.WriteLine("Common elements:");

// foreach (int number1 in array1)
// {
//     foreach (int number2 in array2)
//     {
//         if (number1 == number2)
//         {
//             Console.WriteLine(number1);
//             break;
//         }
//     }
// }

//ArrayList Assignments:
//1.Add integers to an ArrayList and display them.
using System.Collections;

ArrayList numbers = new ArrayList();

numbers.Add(10);
numbers.Add(20);
numbers.Add(30);
numbers.Add(40);

foreach (int number in numbers)
{
    Console.WriteLine(number);
}
//2. Add elements using Add() and Insert().
using System.Collections;

ArrayList numbers = new ArrayList();

numbers.Add(10);
numbers.Add(24);
numbers.Add(30);

numbers.Insert(3, 15);

foreach (int number in numbers)
{
    Console.WriteLine(number);
}

//3. Display the total number of elements.
using System.Collections;

ArrayList numbers = new ArrayList();

numbers.Add(10);
numbers.Add(20);
numbers.Add(30);
numbers.Add(24);

Console.WriteLine("Total elements: " + numbers.Count);

//4. Sort an ArrayList in ascending order.
using System.Collections;

ArrayList numbers = new ArrayList();

numbers.Add(24);
numbers.Add(64);
numbers.Add(20);
numbers.Add(14);

numbers.Sort();

foreach (int number in numbers)
{
    Console.WriteLine(number);
}

//5. Remove duplicate elements from an ArrayList.
using System.Collections;

ArrayList numbers = new ArrayList();
numbers.Add(5);
numbers.Add(53);
numbers.Add(75);
numbers.Add(24);
numbers.Add(75);
numbers.Add(64);
numbers.Add(75);
numbers.Add(5);

ArrayList uniqueNumbers = new ArrayList();

foreach (int number in numbers)
{
    if (!uniqueNumbers.Contains(number))
    {
        uniqueNumbers.Add(number);
    }
}

foreach (int number in uniqueNumbers)
{
    Console.WriteLine(number);
}

//6.Find the maximum and minimum elements in an ArrayList.
using System.Collections;

ArrayList numbers = new ArrayList();

numbers.Add(25);
numbers.Add(10);
numbers.Add(45);
numbers.Add(5);
numbers.Add(30);

int max = (int)numbers[0];
int min = (int)numbers[0];

foreach (int number in numbers)
{
    if (number > max)
    {
        max = number;
    }

    if (number < min)
    {
        min = number;
    }
}

Console.WriteLine("Maximum: " + max);
Console.WriteLine("Minimum: " + min);

//7. Find common elements between two ArrayList objects.
using System.Collections;

ArrayList list1 = new ArrayList();

list1.Add(53);
list1.Add(24);
list1.Add(54);
list1.Add(25);

ArrayList list2 = new ArrayList();

list2.Add(24);
list2.Add(65);
list2.Add(14);
list2.Add(45);

Console.WriteLine("Common elements:");

foreach (int number in list1)
{
    if (list2.Contains(number))
    {
        Console.WriteLine(number);
    }
}