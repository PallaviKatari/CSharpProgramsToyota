using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPrograms
{
    /// <summary>
    /// Looping statements in C#
    /// Repetitive execution of a block of code
    /// Types of loops:
    /// entry controlled loops: for, while, foreach
    /// exit controlled loops: do-while
    /// </summary>
    internal class Looping
    {
        /// <summary>
        /// for loop
        /// synatax:
        /// initialization;condition;increment/decrement
        /// </summary>
        public static void ForLoop()
        {
            // for loop - entry controlled loop
            // initialization - condition - increment/decrement
            // post increment/pre increment
            // i++ -> i = i + 1 - assign and then increment
            // ++i -> i = i + 1 - increment and then assign
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Value of i: {i}");
            }
        }
        /// <summary>
        /// initialization first
        /// check the condition
        /// inside the loop body you increment/decrement
        /// </summary>
        public static void WhileLoop()
        {
            // while loop - entry controlled loop
            int i = 1; // initialization
            while (i <= 10) // condition
            {
                Console.WriteLine($"Value of i: {i}");
                i++; // increment/decrement
            }
        }
        /// <summary>
        /// initialization first
        /// enter the loop body and increment/decrement
        /// check the condition after executing the loop body
        /// </summary>
        public static void DoWhileLoop()
        {
            // do-while loop - exit controlled loop
            int i = 12; // initialization
            do
            {
                Console.WriteLine($"Value of i: {i}");
                i++; // increment/decrement
            } while (i <= 10); // condition
        }
        /// <summary>
        /// Foreach loop - used to iterate over a collection/array
        /// </summary>
        public static void ForEachLoop()
        {
            // foreach loop - entry controlled loop
            // used to iterate over a collection/array
            // arrays - group of values of same datatype
            // syntax - int[] arr = {1,2,3,4,5};
            string[] names = { "John", "Jane", "Jack", "Jill" };
            foreach (string name in names)
            {
                Console.WriteLine($"Name: {name}");
            }
        }

        public static void BreakContinue()
        {
            // break and continue statements
            for (int i = 1; i <= 10; i++)
            {
                if (i == 5)
                {
                    break; // exit the loop
                    //continue; // skip the current iteration
                }
                Console.WriteLine($"Value of i: {i}");
            }
        }

        static void Main(string[] args)
        {
            //ForLoop();
            //WhileLoop();
            //DoWhileLoop();
            //ForEachLoop();
            BreakContinue();

        }
    }
}
