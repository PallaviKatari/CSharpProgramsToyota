using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPrograms
{
    internal class Collections
    {
        /// <summary>
        /// Arrays - collection of similar data types
        /// Dynamic memory allocation - Collections in C# - Data Structures
        /// Collections - ArrayList,Hashtable,Stack,Queue,SortedList,LinkedList,Dictionary
        /// Generic Collections - List<T>,Dictionary<TKey,TValue>,SortedList<TKey,TValue>,SortedSet<T>,Queue<T>,Stack<T>,LinkedList<T>
        /// <T> - Type Parameter - Generic - Type Specific
        /// <int> - It can hold only integers
        /// <string> - It can hold only strings
        /// <class> - It can hold only objects of that class
        /// Generic Collections are type safe and perform better than non-generic collections
        /// </summary>
        public static void ArrayList()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(10);
            arrayList.Add("Hello");
            arrayList.Add(20.5);
            Console.WriteLine("ArrayList Elements:");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

        }
        public static void ListDemo()
        {
            List<int> numbers = new List<int>();
            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);
            //numbers.Add("Hello"); // Compile-time error
            Console.WriteLine("List Elements:");
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
            numbers.Remove(20);
            numbers.Insert(1, 25);
            Console.WriteLine("After Modification:");
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
        // Stack - LIFO - Last In First Out
        // push() - to add an element
        // pop() - to remove an element
        // peek() - to view the top element without removing it
        public static void StackDemo()
        {
            Stack<string> stack = new Stack<string>();
            stack.Push("First");
            stack.Push("Second");
            stack.Push("Third");
            Console.WriteLine("Stack Elements:");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            //Console.WriteLine("Popped Element: " + stack.Pop());
            Console.WriteLine("Top Element: " + stack.Peek());
        }
        // Queue - FIFO - First In First Out
        // enqueue() - to add an element
        // dequeue() - to remove an element
        // peek() - to view the front element without removing it
        public static void QueueDemo()
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("First");
            queue.Enqueue("Second");
            queue.Enqueue("Third");
            Console.WriteLine("Queue Elements:");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            //Console.WriteLine("Dequeued Element: " + queue.Dequeue());
            Console.WriteLine("Front Element: " + queue.Peek());
        }

        static void Main(string[] args)
        {
            ArrayList();
            Console.WriteLine("****************");
            ListDemo();
            Console.WriteLine("****************");
            StackDemo();
            Console.WriteLine("****************");
            QueueDemo();
        }
    }
}
