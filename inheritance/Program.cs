//using System;
//public class Employee
//{
//    public string Firstname;
//    public string Lastname;
//    public void PrintFullName()
//    {
//        Console.WriteLine(Firstname + Lastname);
//    }
//}

//public class FullTimeEmployee : Employee
//{
//    public float salaryyearly; 

//}
//public class PartTimeEmployee : Employee
//{
//    public float salaryhour;
//}
//public class Program
//{ 
//    public static void Main()
//    {
//        FullTimeEmployee FTE = new FullTimeEmployee();
//        FTE.Firstname = "Srujana";
//        FTE.Lastname = "Nayanala";
//        FTE.salaryyearly = 50000;
//        FTE.PrintFullName();


//        PartTimeEmployee PTE = new PartTimeEmployee();
//        PTE.Firstname = "Pradeep";
//        PTE.Lastname = "Kattekola";
//        PTE.salaryhour = 11;
//        PTE.PrintFullName();
//    }
//}


using System;
public class ParentClass
{
    public ParentClass()
    {
        Console.WriteLine("parentclass called");
    }
    public ParentClass(string Message)
    {
        Console.WriteLine(Message);
    }
}
public class Childclass : ParentClass
{   
    public Childclass() : base("Derived class parent class")
    {
        Console.WriteLine("Child class called");

    }
}
public class Program
{
    public static void Main()
    {
        Childclass childclass = new Childclass();
    }
}