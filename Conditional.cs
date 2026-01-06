using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPrograms
{
    internal class Conditional
    {
        public int number1;
        public int number2;
        public int number3;
        public int age;
        /// <summary>
        /// ctor tab - create a constructor
        /// Types of Conditional Statements:
        /// if statement
        /// if...else statement
        /// else if ladder
        /// nested if statement
        /// </summary>
        public Conditional()
        {
            number1 = 10000;
            number2 = 2000;
            number3 = 300;
        }
        /// <summary>
        /// Constructor with one parameter
        /// Switch case statement
        /// check multiple conditions for a single variable
        /// case - value to be checked
        /// default - optional - else
        /// case - break;
        /// </summary>
        /// <param name="age"></param>
        public Conditional(int age) //21
        {           
            switch(age)
            {
                case 18:
                    Console.WriteLine("You are eligible to vote");
                    break;
                case 21:
                    Console.WriteLine("You are eligible for driving");
                    break;
                case 24:
                    Console.WriteLine("You are eligible for marriage");
                    break;
                default:
                    Console.WriteLine("No special eligibility");
                    break;
            }

        }
        /// <summary>
        /// Greater Number among three numbers
        /// all if conditions are checked
        /// </summary>
        public void GreaterNumber()
        {
            //if-else
            //else if ladder
            //nested if
            if (number1 > number2) // 100>20
            {
                if (number1 > number3) //100>300
                {
                    Console.WriteLine($"{number1} is the greatest number");
                }
                else
                {
                    Console.WriteLine($"{number3} is the greatest number");
                }
            }
            else if(number2 > number3) //20>300
            {
                Console.WriteLine($"{number2} is the greatest number");
            }
            else
            {
                Console.WriteLine($"{number3} is the greatest number");
            }

        }

        public void EmployeeDetails()
        {
            int empId;
            string empName;
            float salary;
            bool IsPermanent;
            Console.WriteLine("Enter the employee ID");
            empId=Convert.ToInt32(Console.ReadLine()); //100
            Console.WriteLine("Enter the employee name");
            empName=Console.ReadLine(); //John
            Console.WriteLine("Enter the employee salary");
            salary=Convert.ToSingle(Console.ReadLine()); //10000.56f
            Console.WriteLine("Is the employee permanent? True/False");
            IsPermanent=Convert.ToBoolean(Console.ReadLine()); //true
            Console.WriteLine($"Employee Details:\nID:{empId}\nName:{empName}\nSalary:{salary}\nPermanent Employee:{IsPermanent}");

        }


        static void Main(string[] args)
        {
            Conditional cond = new Conditional();  
            Conditional cond1= new Conditional(21);
            cond.GreaterNumber();
            cond.EmployeeDetails();
        }
    }
}
