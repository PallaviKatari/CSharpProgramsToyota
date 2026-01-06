using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPrograms
{
    /// <summary>
    /// Datatypes class to demonstrate datatypes in C#
    /// Variables - container to hold data in memory
    /// Datatypes - Value type and Reference type
    /// Type of data the variable can hold
    /// Value Type - int, float, double , bool -> Stack - actual data
    /// Reference Type - class,interface,delegates,array,string  -> Heap - reference(stack) -> actual data(Heap)
    /// Value - Reference - Boxing 
    /// Reference to Value - Unboxing
    /// </summary>
    internal class Datatypes
    {
        int a = 10; // instance variable
        static int b = 20; // static variable
        float f = 10.5f; // instance variable
        double d = 20.99; // instance variable
        bool flag = true; // instance variable
        string name = "Koenig Solutions"; // instance variable

        public Datatypes()
        {
            Console.WriteLine("Constructor Called");
            // Display the value of a using different formatting techniques
            // 1. Using concatenation
            // 2. Using composite formatting
            // 3. Using string interpolation
            // 4. {0} - placeholder
            Console.WriteLine("Value of int a:{0} and int b:{1}", a, b);
            Console.WriteLine("Value of static int b:" + b);
            Console.WriteLine($"Value of float f: {f} and double d:{d}");
            Console.WriteLine($"Value of double d: {d}");
            Console.WriteLine($"Value of bool flag: {flag}");
            Console.WriteLine($"Value of string name: {name}");
            // Escape sequences \t - tab, \n - new line, \\ - backslash, \" - double quote
            Console.WriteLine("\\\\Koenig\\\\CSharp.txt"); // \\Basics\\Program "\\Koenig\\CSharp.txt"
            Console.WriteLine(@"\\Koenig\\CSharp.txt"); // @ verbatim string literal
        }

        static void Main(string[] args)
        {
            Datatypes dt = new Datatypes();

        }
    }
}
