using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPrograms
{
    /// <summary>
    /// Arrays class to demonstrate arrays in C#
    /// Arrays - collection of similar data types
    /// Types of arrays:
    /// Single Dimensional Array
    /// Two Dimensional Array
    /// Multidimensional Array
    /// Jagged Array - array of arrays
    /// </summary>
    internal class Arrays
    {
        public static void SingleDimArray()
        {
            // Single Dimensional Array
            int[] numbers = new int[5]; // Declaration and instantiation
            // Initialization
            // Elements are accessed using index starting from 0
            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;
            numbers[3] = 40;
            numbers[4] = 50;
            // Accessing elements
            Console.WriteLine("Elements in the array:");
            for (int i = 0; i < numbers.Length; i++) // Length property to get the size of the array
            {
                Console.WriteLine(numbers[i]);
            }

            int[] scores = { 90, 85, 80, 70, 70 }; // Declaration, instantiation and initialization
            Console.WriteLine("Elements in the scores array:");
            foreach (int score in scores)
            {
                Console.WriteLine(score);
            }
            Console.WriteLine(scores.Length);
            Console.WriteLine(scores.Max());
            Console.WriteLine(scores.Min());
            Console.WriteLine(scores.Average());
            Console.WriteLine(scores.Sum());
            Console.WriteLine(Array.IndexOf(scores, 80));
            Console.WriteLine(Array.LastIndexOf(scores, 70));
            Console.WriteLine(Array.Exists(scores, s => s == 85));
            Console.WriteLine(scores.Count());
        }

        public static void TwoDimArray()
        {
            // Two Dimensional Array
            int[,] matrix = new int[3, 3]; // Declaration and instantiation
            // Initialization
            matrix[0, 0] = 1;
            matrix[0, 1] = 2;
            matrix[0, 2] = 3;
            matrix[1, 0] = 4;
            matrix[1, 1] = 5;
            matrix[1, 2] = 6;
            matrix[2, 0] = 7;
            matrix[2, 1] = 8;
            matrix[2, 2] = 9;
            // Accessing elements
            Console.WriteLine("Elements in the 2D array:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static void JaggedArray()
        {
            // Jagged Array - array of arrays
            int[][] jaggedArray = new int[3][];
            // Initialization
            jaggedArray[0] = new int[] { 1, 2, 3 };
            jaggedArray[1] = new int[] { 4, 5 };
            jaggedArray[2] = new int[] { 6, 7, 8, 9 };
            // Accessing elements
            Console.WriteLine("Elements in the jagged array:");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
        public static void Jagged2DArray()
        {
            // Declare jagged array (array of 2D arrays)
            int[][,] matrix = new int[2][,];

            // Initialize each 2D array
            matrix[0] = new int[2, 3];
            matrix[1] = new int[2, 3];

            // Assign values to first 2D array
            matrix[0][0, 0] = 1;
            matrix[0][0, 1] = 2;
            matrix[0][0, 2] = 3;
            matrix[0][1, 0] = 4;
            matrix[0][1, 1] = 5;
            matrix[0][1, 2] = 6;

            // Assign values to second 2D array
            matrix[1][0, 0] = 7;
            matrix[1][0, 1] = 8;
            matrix[1][0, 2] = 9;
            matrix[1][1, 0] = 10;
            matrix[1][1, 1] = 11;
            matrix[1][1, 2] = 12;

            // Print values
            for (int i = 0; i < matrix.Length; i++)
            {
                Console.WriteLine($"Matrix {i}:");

                for (int j = 0; j < matrix[i].GetLength(0); j++)
                {
                    for (int k = 0; k < matrix[i].GetLength(1); k++)
                    {
                        Console.Write(matrix[i][j, k] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            //SingleDimArray();
            //TwoDimArray();
            //JaggedArray();
            Jagged2DArray();
        }
    }
}
