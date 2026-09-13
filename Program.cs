using System;

class Program
{
    static void Main()
    {
        #region Question 1

        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if (number % 3 == 0 && number % 4 == 0)
            Console.WriteLine("Yes");
        else
            Console.WriteLine("No");

        #endregion


        #region Question 2

        // Console.Write("Enter an integer: ");
        // int number = int.Parse(Console.ReadLine());

        // if (number < 0)
        //     Console.WriteLine("negative");
        // else
        //     Console.WriteLine("positive");

        #endregion


        #region Question 3

        // Console.Write("Enter three integers: ");
        // string[] input = Console.ReadLine().Split();

        // int num1 = int.Parse(input[0]);
        // int num2 = int.Parse(input[1]);
        // int num3 = int.Parse(input[2]);

        // int max = num1;
        // int min = num1;

        // if (num2 > max)
        //     max = num2;

        // if (num3 > max)
        //     max = num3;

        // if (num2 < min)
        //     min = num2;

        // if (num3 < min)
        //     min = num3;

        // Console.WriteLine($"Max element = {max}");
        // Console.WriteLine($"Min element = {min}");

        #endregion


        #region Question 4

        // Console.Write("Enter an integer: ");
        // int number = int.Parse(Console.ReadLine());

        // if (number % 2 == 0)
        //     Console.WriteLine("Even");
        // else
        //     Console.WriteLine("Odd");

        #endregion


        #region Question 5

        // Console.Write("Enter a character: ");
        // char character = char.Parse(Console.ReadLine());

        // character = char.ToLower(character);

        // if (character == 'a' ||
        //     character == 'e' ||
        //     character == 'i' ||
        //     character == 'o' ||
        //     character == 'u')
        // {
        //     Console.WriteLine("vowel");
        // }
        // else
        // {
        //     Console.WriteLine("consonant");
        // }

        #endregion


        #region Question 6

        // Console.Write("Enter a number: ");
        // int number = int.Parse(Console.ReadLine());

        // for (int i = 1; i <= number; i++)
        // {
        //     Console.Write(i);

        //     if (i < number)
        //         Console.Write(", ");
        // }

        // Console.WriteLine();

        #endregion


        #region Question 7

        // Console.Write("Enter a number: ");
        // int number = int.Parse(Console.ReadLine());

        // for (int i = 1; i <= 12; i++)
        // {
        //     Console.Write(number * i);

        //     if (i < 12)
        //         Console.Write(" ");
        // }

        // Console.WriteLine();

        #endregion


        #region Question 8

        // Console.Write("Enter a number: ");
        // int number = int.Parse(Console.ReadLine());

        // for (int i = 2; i <= number; i += 2)
        // {
        //     Console.Write(i + " ");
        // }

        // Console.WriteLine();

        #endregion


        #region Question 9

        // Console.Write("Enter base: ");
        // int number = int.Parse(Console.ReadLine());

        // Console.Write("Enter exponent: ");
        // int power = int.Parse(Console.ReadLine());

        // int result = 1;

        // for (int i = 1; i <= power; i++)
        // {
        //     result *= number;
        // }

        // Console.WriteLine(result);

        #endregion


        #region Question 10

        // Console.Write("Enter marks of five subjects: ");
        // string[] input = Console.ReadLine().Split();

        // int mark1 = int.Parse(input[0]);
        // int mark2 = int.Parse(input[1]);
        // int mark3 = int.Parse(input[2]);
        // int mark4 = int.Parse(input[3]);
        // int mark5 = int.Parse(input[4]);

        // int total = mark1 + mark2 + mark3 + mark4 + mark5;

        // double average = total / 5.0;

        // double percentage = total / 500.0 * 100;

        // Console.WriteLine($"Total marks = {total}");
        // Console.WriteLine($"Average Marks = {average}");
        // Console.WriteLine($"Percentage = {percentage}%");

        #endregion


        #region Question 11

        // Console.Write("Enter month number: ");
        // int month = int.Parse(Console.ReadLine());

        // int days;

        // switch (month)
        // {
        //     case 1:
        //     case 3:
        //     case 5:
        //     case 7:
        //     case 8:
        //     case 10:
        //     case 12:
        //         days = 31;
        //         break;

        //     case 4:
        //     case 6:
        //     case 9:
        //     case 11:
        //         days = 30;
        //         break;

        //     case 2:
        //         days = 28;
        //         break;

        //     default:
        //         days = 0;
        //         break;
        // }

        // if (days == 0)
        //     Console.WriteLine("Invalid month");
        // else
        //     Console.WriteLine($"Days in Month: {days}");

        #endregion


        #region Question 12

        // Console.Write("Enter first number: ");
        // double number1 = double.Parse(Console.ReadLine());

        // Console.Write("Enter operator (+, -, *, /): ");
        // char operation = char.Parse(Console.ReadLine());

        // Console.Write("Enter second number: ");
        // double number2 = double.Parse(Console.ReadLine());

        // double result = 0;

        // switch (operation)
        // {
        //     case '+':
        //         result = number1 + number2;
        //         break;

        //     case '-':
        //         result = number1 - number2;
        //         break;

        //     case '*':
        //         result = number1 * number2;
        //         break;

        //     case '/':
        //         if (number2 == 0)
        //         {
        //             Console.WriteLine("Cannot divide by zero.");
        //             return;
        //         }

        //         result = number1 / number2;
        //         break;

        //     default:
        //         Console.WriteLine("Invalid operator.");
        //         return;
        // }

        // Console.WriteLine($"Result = {result}");

        #endregion


        #region Question 13

        // Console.Write("Enter a string: ");
        // string text = Console.ReadLine();

        // for (int i = text.Length - 1; i >= 0; i--)
        // {
        //     Console.Write(text[i]);
        // }

        // Console.WriteLine();

        #endregion


        #region Question 14

        // Console.Write("Enter an integer: ");
        // int number = int.Parse(Console.ReadLine());

        // int reversed = 0;

        // while (number != 0)
        // {
        //     int digit = number % 10;
        //     reversed = reversed * 10 + digit;
        //     number /= 10;
        // }

        // Console.WriteLine($"Reversed = {reversed}");

        #endregion


        #region Question 15

        // Console.Write("Input starting number of range: ");
        // int start = int.Parse(Console.ReadLine());

        // Console.Write("Input ending number of range: ");
        // int end = int.Parse(Console.ReadLine());

        // Console.WriteLine($"The prime number between {start} and {end} are:");

        // for (int number = start; number <= end; number++)
        // {
        //     if (number < 2)
        //         continue;

        //     bool isPrime = true;

        //     for (int i = 2; i <= Math.Sqrt(number); i++)
        //     {
        //         if (number % i == 0)
        //         {
        //             isPrime = false;
        //             break;
        //         }
        //     }

        //     if (isPrime)
        //         Console.Write(number + " ");
        // }

        // Console.WriteLine();

        #endregion


        #region Question 16

        // Console.Write("Enter a number to convert: ");
        // int number = int.Parse(Console.ReadLine());

        // int originalNumber = number;

        // long binary = 0;
        // long place = 1;

        // while (number > 0)
        // {
        //     int remainder = number % 2;

        //     binary += remainder * place;

        //     place *= 10;
        //     number /= 2;
        // }

        // Console.WriteLine($"The Binary of {originalNumber} is {binary}.");

        #endregion


        #region Question 17

        // Console.Write("Enter x1: ");
        // double x1 = double.Parse(Console.ReadLine());

        // Console.Write("Enter y1: ");
        // double y1 = double.Parse(Console.ReadLine());

        // Console.Write("Enter x2: ");
        // double x2 = double.Parse(Console.ReadLine());

        // Console.Write("Enter y2: ");
        // double y2 = double.Parse(Console.ReadLine());

        // Console.Write("Enter x3: ");
        // double x3 = double.Parse(Console.ReadLine());

        // Console.Write("Enter y3: ");
        // double y3 = double.Parse(Console.ReadLine());

        // double left = (x2 - x1) * (y3 - y1);
        // double right = (y2 - y1) * (x3 - x1);

        // if (Math.Abs(left - right) < 0.000001)
        //     Console.WriteLine("The points lie on a single straight line.");
        // else
        //     Console.WriteLine("The points do not lie on a single straight line.");

        #endregion


        #region Question 18

        // Console.Write("Enter the time taken by the worker: ");
        // double hours = double.Parse(Console.ReadLine());

        // if (hours >= 2 && hours < 3)
        // {
        //     Console.WriteLine("Highly efficient");
        // }
        // else if (hours >= 3 && hours < 4)
        // {
        //     Console.WriteLine("Increase their speed");
        // }
        // else if (hours >= 4 && hours <= 5)
        // {
        //     Console.WriteLine("Training is required to enhance speed");
        // }
        // else if (hours > 5)
        // {
        //     Console.WriteLine("Required to leave the company");
        // }
        // else
        // {
        //     Console.WriteLine("Invalid time");
        // }

        #endregion


        #region Question 19

        // Console.Write("Enter matrix size: ");
        // int n = int.Parse(Console.ReadLine());

        // for (int i = 0; i < n; i++)
        // {
        //     for (int j = 0; j < n; j++)
        //     {
        //         if (i == j)
        //             Console.Write("1 ");
        //         else
        //             Console.Write("0 ");
        //     }

        //     Console.WriteLine();
        // }

        #endregion


        #region Question 20

        // Console.Write("Enter array size: ");
        // int size = int.Parse(Console.ReadLine());

        // int[] array = new int[size];

        // int sum = 0;

        // for (int i = 0; i < size; i++)
        // {
        //     Console.Write($"Enter element {i}: ");
        //     array[i] = int.Parse(Console.ReadLine());

        //     sum += array[i];
        // }

        // Console.WriteLine($"Sum = {sum}");

        #endregion


        #region Question 21

        // Console.Write("Enter size of arrays: ");
        // int size = int.Parse(Console.ReadLine());

        // int[] array1 = new int[size];
        // int[] array2 = new int[size];
        // int[] merged = new int[size * 2];

        // Console.WriteLine("Enter first sorted array:");

        // for (int i = 0; i < size; i++)
        // {
        //     array1[i] = int.Parse(Console.ReadLine());
        // }

        // Console.WriteLine("Enter second sorted array:");

        // for (int i = 0; i < size; i++)
        // {
        //     array2[i] = int.Parse(Console.ReadLine());
        // }

        // int x = 0;
        // int y = 0;
        // int z = 0;

        // while (x < size && y < size)
        // {
        //     if (array1[x] <= array2[y])
        //     {
        //         merged[z] = array1[x];
        //         x++;
        //     }
        //     else
        //     {
        //         merged[z] = array2[y];
        //         y++;
        //     }

        //     z++;
        // }

        // while (x < size)
        // {
        //     merged[z] = array1[x];
        //     x++;
        //     z++;
        // }

        // while (y < size)
        // {
        //     merged[z] = array2[y];
        //     y++;
        //     z++;
        // }

        // Console.WriteLine("Merged array:");

        // for (int i = 0; i < merged.Length; i++)
        // {
        //     Console.Write(merged[i] + " ");
        // }

        // Console.WriteLine();

        #endregion


        #region Question 22

        // Console.Write("Enter array size: ");
        // int size = int.Parse(Console.ReadLine());

        // int[] array = new int[size];
        // bool[] visited = new bool[size];

        // for (int i = 0; i < size; i++)
        // {
        //     Console.Write($"Enter element {i}: ");
        //     array[i] = int.Parse(Console.ReadLine());
        // }

        // Console.WriteLine("Frequency of each element:");

        // for (int i = 0; i < size; i++)
        // {
        //     if (visited[i])
        //         continue;

        //     int count = 1;

        //     for (int j = i + 1; j < size; j++)
        //     {
        //         if (array[i] == array[j])
        //         {
        //             count++;
        //             visited[j] = true;
        //         }
        //     }

        //     Console.WriteLine($"{array[i]} occurs {count} time(s)");
        // }

        #endregion


        #region Question 23

        // Console.Write("Enter array size: ");
        // int size = int.Parse(Console.ReadLine());

        // int[] array = new int[size];

        // for (int i = 0; i < size; i++)
        // {
        //     Console.Write($"Enter element {i}: ");
        //     array[i] = int.Parse(Console.ReadLine());
        // }

        // int max = array[0];
        // int min = array[0];

        // for (int i = 1; i < size; i++)
        // {
        //     if (array[i] > max)
        //         max = array[i];

        //     if (array[i] < min)
        //         min = array[i];
        // }

        // Console.WriteLine($"Maximum = {max}");
        // Console.WriteLine($"Minimum = {min}");

        #endregion


        #region Question 24

        // Console.Write("Enter array size: ");
        // int size = int.Parse(Console.ReadLine());

        // if (size < 2)
        // {
        //     Console.WriteLine("Array must contain at least two elements.");
        //     return;
        // }

        // int[] array = new int[size];

        // for (int i = 0; i < size; i++)
        // {
        //     Console.Write($"Enter element {i}: ");
        //     array[i] = int.Parse(Console.ReadLine());
        // }

        // int largest = int.MinValue;
        // int secondLargest = int.MinValue;

        // for (int i = 0; i < size; i++)
        // {
        //     if (array[i] > largest)
        //     {
        //         secondLargest = largest;
        //         largest = array[i];
        //     }
        //     else if (array[i] > secondLargest && array[i] != largest)
        //     {
        //         secondLargest = array[i];
        //     }
        // }

        // if (secondLargest == int.MinValue)
        //     Console.WriteLine("There is no second largest distinct element.");
        // else
        //     Console.WriteLine($"Second largest = {secondLargest}");

        #endregion


        #region Question 25

        // Console.Write("Enter array elements separated by spaces: ");
        // string[] input = Console.ReadLine().Split();

        // int[] array = new int[input.Length];

        // for (int i = 0; i < input.Length; i++)
        // {
        //     array[i] = int.Parse(input[i]);
        // }

        // int longestDistance = 0;

        // for (int i = 0; i < array.Length; i++)
        // {
        //     for (int j = i + 1; j < array.Length; j++)
        //     {
        //         if (array[i] == array[j])
        //         {
        //             int distance = j - i - 1;

        //             if (distance > longestDistance)
        //                 longestDistance = distance;
        //         }
        //     }
        // }

        // Console.WriteLine($"Longest distance = {longestDistance}");

        #endregion


        #region Question 26

        // Console.Write("Enter a sentence: ");
        // string input = Console.ReadLine();

        // string[] words = input.Split(' ');

        // for (int i = words.Length - 1; i >= 0; i--)
        // {
        //     Console.Write(words[i]);

        //     if (i > 0)
        //         Console.Write(" ");
        // }

        #endregion


        #region Question 27

        // Console.Write("Enter number of rows: ");
        // int rows = int.Parse(Console.ReadLine());

        // Console.Write("Enter number of columns: ");
        // int columns = int.Parse(Console.ReadLine());

        // int[,] firstArray = new int[rows, columns];
        // int[,] secondArray = new int[rows, columns];

        // Console.WriteLine("Enter elements of first array:");

        // for (int i = 0; i < rows; i++)
        // {
        //     for (int j = 0; j < columns; j++)
        //     {
        //         Console.Write($"Element [{i},{j}]: ");
        //         firstArray[i, j] = int.Parse(Console.ReadLine());
        //     }
        // }

        // for (int i = 0; i < rows; i++)
        // {
        //     for (int j = 0; j < columns; j++)
        //     {
        //         secondArray[i, j] = firstArray[i, j];
        //     }
        // }

        // Console.WriteLine("Second array:");

        // for (int i = 0; i < rows; i++)
        // {
        //     for (int j = 0; j < columns; j++)
        //     {
        //         Console.Write(secondArray[i, j] + " ");
        //     }

        //     Console.WriteLine();
        // }

        #endregion


        #region Question 28

        // Console.Write("Enter array size: ");
        // int size = int.Parse(Console.ReadLine());

        // int[] array = new int[size];

        // for (int i = 0; i < size; i++)
        // {
        //     Console.Write($"Enter element {i}: ");
        //     array[i] = int.Parse(Console.ReadLine());
        // }

        // Console.WriteLine("Array in reverse order:");

        // for (int i = size - 1; i >= 0; i--)
        // {
        //     Console.Write(array[i] + " ");
        // }

        // Console.WriteLine();

        #endregion
    }
}