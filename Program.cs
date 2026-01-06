using System;

//Namespace declaration
//namespace - collection of classes,interfaces,structs,enums,delegates
//ctrl+K+c - comment
//ctrl+K+u - uncomment
namespace CSharpPrograms
{
    ///// <summary>
    ///// Basic class to demonstrate constructor,datatypes,methods
    ///// </summary>
    //internal class Basics
    //{
    //    /// <summary>
    //    /// ctor tab - create a constructor
    //    /// Special methods - same name as the class name,no return type, initialised automatically
    //    /// Datatypes - Value type and Reference type
    //    /// Value Type - int, float, double , bool -> Stack - actual data
    //    /// Reference Type - class,interface,delegates,array,string  -> Heap - reference(stack) -> actual data(Heap)
    //    /// </summary>

    //    public Basics()
    //    {
    //        Console.WriteLine("Constructor Called");
    //    }

    //    /// <summary>
    //    /// Instance Method
    //    /// </summary>
    //    public void Display()
    //    {
    //        int a = 10;
    //        float b = 12.36f;// .1234567
    //        double c = 12.36;// .12345678901234
    //        bool d = false;
    //        Console.WriteLine("Value of the int datatype is:" + a); // + concatenation
    //        Console.WriteLine("Value of the float datatype is: {0},Value of the double datatype is: {1}", b, c); // Composite formatting
    //        Console.WriteLine($"Value of the double datatype is: {c}"); // String interpolation
    //        Console.WriteLine("\\\\Koenig\\\\CSharp.txt"); // \\Basics\\Program "\\Koenig\\CSharp.txt"
    //        Console.WriteLine(@"\\Koenig\\CSharp.txt"); // @ verbatim string literal
    //    }
    //    /// <summary>
    //    /// Static Method
    //    /// static and non-static variables
    //    /// </summary>
    //    public static void EmployeeDetails()
    //    {
    //        //Apart from string all are value types which must be converted while getting input from the console
    //        int empId;
    //        string empName;
    //        Console.WriteLine("Enter the employee ID");
    //        //cin>> empId;
    //        empId = Convert.ToInt32(Console.ReadLine()); //100
    //        Console.WriteLine("Enter the employee name");
    //        empName = Console.ReadLine(); //John
    //        Console.WriteLine($"{empName}'s employee ID is {empId}");
    //    }

    //    static void Main(string[] args)
    //    {
    //        Basics basics = new Basics(); // default constructor - Basics()
    //        basics.Display();
    //        EmployeeDetails();
    //        Basics1 basics1 = new Basics1();
    //        basics1.Display1();
    //        Basics1.Display2();
    //        Console.ReadLine();
    //    }
    //}

    //internal class Basics1
    //{
    //    public void Display1()
    //    {
    //        Console.WriteLine("Display1 Instance Method");
    //    }
    //    public static void Display2()
    //    {
    //        Console.WriteLine("Display2 Static Method");
    //    }
    //}

    internal class Program
    {
        /// <summary>
        /// Main method - Entry point of the application
        /// static - called by runtime without creating the object of the class
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Console - predefined class in System namespace
            //WriteLine - static method to print the output on the console
            Console.WriteLine("Hello, World!");
            SampleMethod();
            SampleClass.StaticMethod();
            //State of the object - created using new keyword
            //program is the identifier
            Program program = new Program(); // creating the object of the Program class - program
            //Behavior - calling the instance method using the object
            program.InstanceMethodProgram();
            SampleClass sampleClass= new SampleClass();
            sampleClass.InstanceMethod();
            Program program1 = new Program(10);

        }

        /// <summary>
        /// Default Constructor
        /// Empty constructor
        /// </summary>
        Program()
        {
            Console.WriteLine("Program Class Constructor");
        }
        /// <summary>
        /// Constructor Overloading - multiple constructors with different parameters
        /// Constructor with parameter
        /// </summary>
        /// <param name="a"></param>
        Program(int a)
        {
            Console.WriteLine("Program Class Parameterized Constructor with value: " + a);
        }
        /// <summary>
        /// Types of Methods
        /// Static and Non-Static(Instance)
        /// Static - called by the class name without creating the object
        /// </summary>
        static void SampleMethod()
        {
            Console.WriteLine("Sample Static Method");
        }
        /// <summary>
        /// Instance Method
        /// </summary>
        public void InstanceMethodProgram()
        {
            Console.WriteLine("Sample Instance Method in program class");
        }
    }

    /// <summary>
    /// Access Specifiers - public, private, internal, protected, protected internal, private protected
    /// Classes are internal by default
    /// internal vs public - internal accessible within the same assembly, public accessible from other assemblies
    /// private - accessible within the same class only
    /// protected - accessible within the same class and derived class
    /// protected internal - accessible within the same assembly and derived class in other assemblies
    /// private protected - accessible within the same class and derived
    /// </summary>
    internal class SampleClass
    {
        /// <summary>
        /// Static Method
        /// Methods are private by default
        /// </summary>
        public static void StaticMethod()
        {
            Console.WriteLine("Static Method outside the Main Method Class");
        }
        /// <summary>
        /// Static vs instance method scenario - static method cannot access instance method directly
        /// Instance Method
        /// </summary>
        public void InstanceMethod()
        {
            Console.WriteLine("Instance Method outside the Main Method Class");
        }
    }
}