//using System;
//public delegate void HelloFunctionDel(string message);
//class program
//{ public static void Main()
//    {
//        HelloFunctionDel Del = new HelloFunctionDel(Hello);
//        Hello("Hello im srujana");
//    }
//    public static void Hello(string message)
//    {
//        Console.WriteLine(message);
//    }
//}
// Another program
using System;
using System.Collections.Generic;

class Program
{
    private static List<Employee> empList = new List<Employee>(); // Initialize empList

    public static void Main()
    {
        // Add employees to the list
        empList.Add(new Employee { ID = 101, Name = "Srujana", Salary = 1000, Experience = 2 });
        empList.Add(new Employee { ID = 102, Name = "Divya", Salary = 2000, Experience = 4 });
        empList.Add(new Employee { ID = 103, Name = "Pradeep", Salary = 5000, Experience = 5 });
        empList.Add(new Employee { ID = 104, Name = "Vicky", Salary = 6000, Experience = 6 });

        // Call PromoteEmployee method with a delegate
        Employee.PromoteEmployee(empList, emp => emp.Experience >= 5);
    }
}

delegate bool IsPromotable(Employee emp);

class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; }
    public int Experience { get; set; }

    public static void PromoteEmployee(List<Employee> empList, IsPromotable IsEligibleToPromote)
    {
        foreach (Employee employee in empList)
        {
            if (IsEligibleToPromote(employee)) // Use the delegate to determine promotion
            {
                Console.WriteLine(employee.Name + " promoted");
            }
        }
    }
}
