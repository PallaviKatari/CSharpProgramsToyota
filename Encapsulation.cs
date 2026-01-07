using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPrograms
{
    /// <summary>
    /// public,private,internal,[protected, internal protected]-inheritance(child class)
    /// OOPS - Class,Object,Abstraction,Encapsulation,Inheritance,Polymorphism
    /// </summary>
    public class AccessSpecifiers
    {
        private int _count = 100;
        /// <summary>
        /// prop - double tab
        /// Properties - to provide access to the private members of a class
        /// get; set; - methods
        /// get - to read the value
        /// set - to assign the value
        /// </summary>
        public int Count
        {
            get//read
            {
                return _count;//10000
            }
            set//write,assign
            {
                _count = value;//10000
            }

        }
        // Constructor
        public AccessSpecifiers()
        {
            Console.WriteLine(_count);//100
        }
        public void Display()
        {
            Console.WriteLine("Access Specifiers Example" + _count);
        }

    }
    internal class Encapsulation
    {
        static void Main(string[] args)
        {
            AccessSpecifiers accessSpecifiers = new AccessSpecifiers();
            //accessSpecifiers._count = 10000; // not accessible due to private access modifier
            accessSpecifiers.Count = 10000;
            accessSpecifiers.Display(); //10000
            Console.WriteLine(accessSpecifiers.Count);
            Console.ReadLine();

        }
    }
}
