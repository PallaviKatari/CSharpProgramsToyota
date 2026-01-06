using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPrograms
{
    /// <summary>
    /// Errors and Exceptions in C#
    /// Types of Errors:
    /// Syntax Errors - compile time errors
    /// Logical Errors - runtime errors
    /// Runtime Errors - exceptions handled using try-catch-finally
    /// throw new Exception()
    /// </summary>
    internal class Exceptions
    {
        /// <summary>
        /// Exceptions
        /// Pre-defined classes in System namespace
        /// DivideByZeroException
        /// IndexOutOfRangeException
        /// User-defined exceptions
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public static void DivideNumbers(int a, int b)
        {

            try
            {
                int result = a / b;
                Console.WriteLine($"Result: {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Source);
            }
            //catch (Exception ex)
            //{
            //    Console.WriteLine("An unexpected error occurred.");
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Execution of DivideNumbers completed.");
            //}
        }

        public static void CauseIndexOutOfRange()
        {
            try
            {
                int[] numbers = { 1, 2, 3 };//0,1,2
                Console.WriteLine(numbers[5]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Error: Index out of range.");
                Console.WriteLine(ex.Message);
            }
        }

        public static void ThrowCustomException()
        {
            try
            {
                int[] num = { 1, 2, 3 };
                if (num.Length < 5)
                {
                    throw new Exception("This is a custom exception message.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Caught a custom exception.");
                Console.WriteLine(ex.Message);
            }
        }

        public static void MutipleCatchBlocks(int a, int b)
        {
            int[] numbers1 = { 1, 2, 3 };
            int[] numbers2 = { 1, 2, 3 }; //0,1,2
            for (int i = 0; i < numbers2.Length; i++) //3
            {
                try
                {
                    int result = numbers1[i] / numbers2[i];
                    Console.WriteLine($"Result: {result}");

                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine("Error: Index out of range.");
                    Console.WriteLine(ex.Message);
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)//base class for all exceptions
                {
                    Console.WriteLine("An unexpected error occurred.");
                    Console.WriteLine(ex.Message);
                }
            }
        }

        static void Main(string[] args)
        {
            //DivideNumbers(10, 0);
            //CauseIndexOutOfRange();
            //ThrowCustomException(); 
            MutipleCatchBlocks(10, 0);
        }
    }
}
