using System;
public class Employee
{
    public string Firstname = "FN";
    public string Lastname = "LN";
    public virtual void PrintFullName()
    {
        Console.WriteLine(Firstname + Lastname);
    }
}

public class FullTimeEmployee : Employee
{
    public override void PrintFullName()
    {
        Console.WriteLine(Firstname + Lastname+ "- FullTime");
    }

}
public class PartTimeEmployee : Employee
{
    public  override void PrintFullName()
    {
        Console.WriteLine(Firstname + Lastname+ "- PartTime");
    }

}
public class TemporaryEmployee : Employee
{
    public override void PrintFullName()
    {
        Console.WriteLine(Firstname + Lastname+ "- TemporaryTime");
    }
}
public class Program
{
    public static void Main()
    {
        Employee[] employees = new Employee[4];
        employees[0]=new Employee();
        employees[1]=new PartTimeEmployee();
        employees[2]=new FullTimeEmployee();
        employees[3] = new TemporaryEmployee();

        foreach(Employee e in employees)
        {
            e.PrintFullName();
        }
        
    }
}


