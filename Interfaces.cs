using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPrograms
{
    /// <summary>
    /// Pure Abstraction - Interfaces
    /// Interfaces - 100% abstraction - data hiding - secured
    /// Interfaces can have methods,properties,events,indexers
    /// Interface naming convention - IProperty,IEmployee
    /// </summary>
    internal interface IProperty
    {
        void ShowPropertyDetails(); //method signature
        int PropertyID { get; set; }
    }
    internal interface IEmployee
    {
        void ShowEmployeeDetails(); //method signature
        int EmployeeID { get; set; }
    }
    interface ICustomer
    {
        void ShowCustomerDetails(); //method signature
        int CustomerID { get; set; }
    }
    // We can implement multiple interfaces in a class
    // A class can access multiple interfaces using comma separated values
    // We use the term "implements" to refer to interface implementation in a class
    internal class RealEstate : IProperty, IEmployee, ICustomer
    {
        public int PropertyID { get; set; }
        public int EmployeeID { get; set; }
        public int CustomerID { get; set; }
        public void ShowPropertyDetails()
        {
            Console.WriteLine("Property ID: " + PropertyID);
        }
        public void ShowEmployeeDetails()
        {
            Console.WriteLine("Employee ID: " + EmployeeID);
        }
        public void ShowCustomerDetails()
        {
            Console.WriteLine("Customer ID: " + CustomerID);
        }
    }
    internal class RealEstate1 : IProperty, IEmployee, ICustomer
    {
        public int PropertyID { get; set; }
        public int EmployeeID { get; set; }
        public int CustomerID { get; set; }
        public void ShowPropertyDetails()
        {
            Console.WriteLine("RealEstate1 Property ID: " + PropertyID);
        }
        public void ShowEmployeeDetails()
        {
            Console.WriteLine("RealEstate1 Employee ID: " + EmployeeID);
        }
        public void ShowCustomerDetails()
        {
            Console.WriteLine("RealEstate1 Customer ID: " + CustomerID);
        }
    }
    internal class Interfaces
    {
        static void Main(string[] args)
        {
            RealEstate realEstate = new RealEstate();
            realEstate.PropertyID = 101;
            realEstate.EmployeeID = 201;
            realEstate.CustomerID = 301;
            realEstate.ShowPropertyDetails();
            realEstate.ShowEmployeeDetails();
            realEstate.ShowCustomerDetails();
            RealEstate1 realEstate1 = new RealEstate1();
            realEstate1.PropertyID = 2101;
            realEstate1.EmployeeID = 2201;
            realEstate1.CustomerID = 2301;
            realEstate1.ShowPropertyDetails();
            realEstate1.ShowEmployeeDetails();
            realEstate1.ShowCustomerDetails();
        }
    }
}
