using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using static System.Net.Mime.MediaTypeNames;
using System;
using static System.Formats.Asn1.AsnWriter;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Templete_C_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 1 - Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            //Example
            //Input: 5
            //Output: 1, 2, 3, 4, 5


            //Console.WriteLine("Entre Number");
            //int.TryParse(Console.ReadLine() , out int num);
            //for (int i = 1; i <= num; i++)
            //{
            //    Console.Write($"{i}, ");
            //}
            #endregion

            #region Q2  Write a program that allows the user to insert an integer thenprint a multiplication table up to 12.
            //Example
            //Input: 5
            //Outputs: 5 10 15 20 25 30 35 40 45 50 55 60


            //Console.WriteLine("Entre Number");
            //int.TryParse(Console.ReadLine(), out int num);
            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.Write($"{i*num}   ");
            //}



            #endregion


            #region Q3  Write a program that allows to user to insert number then print all even numbers between 1 to this number
            // Example:
            // Input: 15
            //Output: 2 4 6 8 10 12 14



            //Console.WriteLine("Entre Number");
            //int.TryParse(Console.ReadLine(), out int num);
            //for (int i = 1; i <= num; i++)
            //{
            //    if(i % 2 == 0 )
            //    Console.Write($"{i }   ");
            //}



            #endregion


            #region Q4 Write a program that takes two integers then prints the power
            //    Example:
            //    Input: 4 3
            //    Output: 64
            //   Hint: how to calculate 4 ^ 3 = 4 * 4 * 4 = 64


            //int pow = 1;
            //Console.WriteLine("Entre Two Numbers ");
            //int.TryParse(Console.ReadLine(), out int num01);
            //int.TryParse(Console.ReadLine(), out int num02);

            //for (int i = 1; i <= num02; i++)
            //{
            //    pow *= num01;
            //}
            //Console.WriteLine(pow);




            #endregion

            #region Q5  Write a program to enter marks of five subjects and calculate total, average and percentage.
            //        Example
            //        Input: -Enter Marks of five subjects: 95 76 58 90 89
            //          Output: Total marks = 408
            //        Average Marks = 81
            //        Percentage = 81


            //int[] marks = new int[5]  ;
            //int total_Marks = 0;


            //for (int i = 0; i < marks.Length; i++)
            //{
            //    int.TryParse( Console.ReadLine() , out marks[i]);


            //}
            //for (int j = 0; j < marks.Length; j++)
            //{
            //    total_Marks += marks[j];

            //}
            //Console.WriteLine($"total Marks = {total_Marks}");
            //Console.WriteLine($"Avgrage_arks = {total_Marks/5}");
            //double percentage = (total_Marks / 500.0) * 100;
            //Console.WriteLine($" Percentege  = {percentage}");







            #endregion


            #region Q6  Write a program to allow the user to enter a string and print the REVERSE of it.

            //Console.Write("Entre String:  ");
            //string st = Convert.ToString(Console.ReadLine());
            //char[] c = st.ToCharArray();
            //Array.Reverse(c);

            //st = new string(c);
            //Console.WriteLine(st);
            #endregion

            #region Q7 - Write a program to allow the user to enter int and print the REVERSED of it.

            //Console.WriteLine("Entre Number");
            //string st = Convert.ToString(Console.ReadLine());
            //char[] c = st.ToCharArray();
            //Array.Reverse(c);

            //st = new string(c);
            //Console.WriteLine(st);





            #endregion
            #region Q8  Write a program in C# Sharp to find prime numbers within a range of numbers.Test Data :
            //Input starting number of ranges: 1
            //Input ending number of range: 50
            //  Expected Output :
            //  The prime number between 1 and 50 are:
            //   2 3 5 7 11 13 17 19 23 29 31 37 41 43 47


            //Console.Write("Entre the stat of range ");
            //int.TryParse(Console.ReadLine(), out int n1);
            //Console.Write("Entre the end of range ");
            //int.TryParse(Console.ReadLine(), out int n2);

            //if (n1 == 1)
            //    n1++;
            //for (int i = n1; i <= n2; i++)
            //{
            //    bool prime = true;
            //    for (int j = 2; j < i; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            prime = false;
            //            break;

            //        }

            //    }
            //    if (prime)
            //        Console.WriteLine($"{i} ");


            //}


            #endregion


            #region Q9 . Write a program in C# Sharp to convert a decimal number into binary without using an array.
            // Test Data :
            //Enter a number to convert: 25
            //Expected Output :
            //The Binary of 25 is 11001.



            //Console.Write("Enter Decimal Number: ");
            //int.TryParse(Console.ReadLine(), out int number);

            //int num;
            //double frac;
            //StringBuilder bin=new StringBuilder("");

            //while(number !=0)
            //{
            //    num = number / 2;
            //    frac = ((double)number / 2)- num;

            //    if (frac > 0)
            //        bin.Insert(0,"1");
            //    else 
            //        bin.Insert(0, "0");

            //    number /= 2;
            //}

            //Console.WriteLine(bin);


            #endregion

            #region Q10 Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.

            //Console.WriteLine("Entre point 1 (x1, y1)");
            //int.TryParse(Console.ReadLine(), out int x1);
            //int.TryParse(Console.ReadLine(), out int y1);

            //Console.WriteLine("Entre point 2 (x2, y2)");
            //int.TryParse(Console.ReadLine(), out int x2);
            //int.TryParse(Console.ReadLine(), out int y2);

            //Console.WriteLine("Entre point 3 (x3, y3)");
            //int.TryParse(Console.ReadLine(), out int x3);
            //int.TryParse(Console.ReadLine(), out int y3);

            //if (x1 == y1 && x2 == y2 && x3 == y3 )
            //{
            //    Console.WriteLine("The points lie on a straight line.");
            //}
            //else
            //{
            //    Console.WriteLine("The points do not lie on a straight line.");
            //}


            #endregion


            #region Q11 . Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.
            //Console.Write("Entre the n of matrix ");
            //int.TryParse(Console.ReadLine(), out  int n);
            //int[,] matrix = new int[n ,n];
            //for (int i = 0; i < n; i++) 
            //{
            //    Console.WriteLine($"Entre User   {i+1}   ");
            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.Write($"Entre    {j + 1}   ");
            //        int.TryParse(Console.ReadLine(), out matrix[i, j]);
            //    }
            //}

            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine();
            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.Write($"{matrix[i,j] * matrix[i, j]}\t");
            //    }
            //}


            #endregion

            #region Q12 Write a program in C# Sharp to find the sum of all elements of the array.
            //Console.Write("Entre the n of Array ");
            //int.TryParse(Console.ReadLine(), out int n);
            //int[] arr = new int[n];
            //int sum = 0;
            //for (int i = 0; i < arr.Length; i++) 
            //{
            //    int.TryParse (Console.ReadLine(), out arr [i]);
            //    sum += arr [i];
            //}
            //Console.WriteLine($"Sum of Elements in array =  {sum}");


            #endregion

            #region Q13 Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
            //int[] arr1 = new int[] { 5, 1, 4 };
            //int[] arr2 = new int[] { 2, 3, 8 };

            //// Ensure both arrays are sorted
            //Array.Sort(arr1);
            //Array.Sort(arr2);

            //// Resultant array to hold merged values
            //int[] res = new int[arr1.Length + arr2.Length];
            //int x = 0, y = 0, z = 0;

            //// Merge two arrays
            //while (x < arr1.Length && y < arr2.Length)
            //{
            //    if (arr1[x] <= arr2[y])
            //    {
            //        res[z] = arr1[x];
            //        x++; z++;
            //    }
            //    else
            //    {
            //        res[z] = arr2[y];
            //        y++; z++;
            //    }
            //}

            //// Add remaining elements from arr1
            //while (x < arr1.Length)
            //{
            //    res[z] = arr1[x];
            //    x++; z++;
            //}

            //// Add remaining elements from arr2
            //while (y < arr2.Length)
            //{
            //    res[z] = arr2[y];
            //    y++; z++;
            //}

            //// Display the merged and sorted array
            //Console.WriteLine("Merged Array in Ascending Order:");
            //for (int i = 0; i < res.Length; i++)
            //{
            //    Console.Write($"{res[i]} ");
            //}

            #endregion

            #region  14- Write a program in C# Sharp to count the frequency of each element of an array.

            //Console.Write("Entre the n of Array ");
            //int.TryParse(Console.ReadLine(), out int n);
            //int[] ele = new int[n];
            //int[] freq = new int[100];
            //for (int i = 0; i < ele.Length; i++)
            //{
            //    int.TryParse(Console.ReadLine(), out ele[i]);
            //    freq[ele[i]]++;

            //}

            //for (int i = 0; i < ele.Length; i++)
            //{
            //    if (freq[ele[i]] == 0)
            //        continue;
            //    else
            //    {
            //        Console.WriteLine($"Element {ele[i]} Frequency is: {freq[ele[i]]}");
            //        freq[ele[i]] = 0;
            //    }









            #endregion

            #region Q15 Write a program in C# Sharp to find maximum and minimum element in an array

            //int[] arr = { 10, 5, 2, 1, 12, 50 };
            //int max = int.MinValue;
            //int min = int.MaxValue;
            //for (int i = 0; i < arr.Length; i++)
            //{

            //    if (arr[i] > max)
            //    {
            //        max = arr[i];

            //    }
            //    if (arr[i] < min)
            //    {
            //        min = arr[i];
            //    }



            //}
            //Console.WriteLine($"Max Value =  {max}");
            //Console.WriteLine($"Min Value =  {min}");








            #endregion

            #region Q16 - Write a program in C# Sharp to find the second largest element in an array.

            //int[] arr = { 6, 7, 3, 8, 5, 3, 7 };

            //int max = int.MinValue;
            //int max02= int.MinValue;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > max) max = arr[i];
            //}

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > max02 && arr[i] != max) max02 = arr[i];
            //}

            //Console.WriteLine($"Second Largest Element: {max02}");

            #endregion


            #region -.Q17 Consider an Array of Integer values with size N, having values as   in this Example

            //// Take array size from user
            //Console.Write("Enter Array Size: ");
            //int.TryParse(Console.ReadLine(), out int size);

            //int[] arr = new int[size];

            //// Take array elements from user
            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write($"Enter Element {i+1} : ");
            //    int.TryParse(Console.ReadLine(), out arr[i]); 
            //}

            //// check if first and last elements are equals
            //if (arr[0]== arr[size-1])
            //    Console.Write($"Longest Distance is: {size-2}");
            //else 
            //{
            //    int longest = 0;
            //    for (int i = 0; i < size; i++)
            //    {
            //        int maxDis = 0;
            //        for (int j = i+1; j < size; j++)
            //        {
            //            if(arr[i] == arr[j])
            //                maxDis =j-1-i ;
            //        }

            //        if(maxDis > longest)
            //            longest= maxDis;     
            //    }
            //    Console.WriteLine($"Longest Distance is: {longest}");
            //}


            #endregion


            #region Q18-Given a list of space separated words, reverse the order of the words.

            //Console.Write("Enter Your Sentence: ");
            //string st=Console.ReadLine()!;
            //string st02 = "";

            //string[] words = st.Split(' ');

            //for (int i = words.Length-1; i >=0; i--)
            //    st02= st02+words[i]+" ";

            //Console.WriteLine(st02);
            #endregion


            #region Q19-Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array.

            //int[,] arr01 = new int[3, 3];
            //int[,] arr02 = new int[3, 3];

            //for (int i = 0; i <arr01.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr01.GetLength(1); j++)
            //    {
            //        Console.Write($"Enter Element of row {i} column {j} : ");
            //        int.TryParse(Console.ReadLine(), out arr01[i, j]);
            //    }
            //}

            //for (int i = 0; i < arr01.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr01.GetLength(1); j++)
            //    {
            //        arr02[i, j] = arr01[i, j];
            //    }
            //}

            //Console.WriteLine();
            //for (int i = 0; i < arr02.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr02.GetLength(1); j++)
            //    {
            //        Console.Write($"{arr02[i,j]} ");                   
            //    }
            //    Console.WriteLine();
            //}
            #endregion


            #region Q20- Write a Program to Print One Dimensional Array in Reverse Order
            //int[] arr = { 1, 2, 3, 4, 5, 6, 7 };

            //for (int i = arr.Length-1; i >=0; i--)
            //{
            //    Console.Write($"{arr[i]}  ");
            //}
            #endregion

        }
    }
}

