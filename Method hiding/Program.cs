using System;
public class Employee
{
   public string Firstname;
   public string Lastname;
    public void PrintFullName()
    {
       Console.WriteLine(Firstname + Lastname);
    }
}

public class FullTimeEmployee : Employee
{
    public float salaryyearly; 

}
public class PartTimeEmployee : Employee
{
    public new void PrintFullName()
    {
        //base.PrintFullName();
        // base or console we can use anything
        //Console.WriteLine(Firstname + Lastname + "Contract");
    }
}
public class Program
{ 
    public static void Main()
    {
       FullTimeEmployee FTE = new FullTimeEmployee();
        FTE.Firstname = "Srujana";
        FTE.Lastname = "Nayanala";
       FTE.salaryyearly = 50000;
       FTE.PrintFullName();
       // or this see the change in last line

       //PartTimeEmployee PTE = new PartTimeEmployee();
       //Or
       Employee PTE = new Employee();
       PTE.Firstname = "Pradeep";
        PTE.Lastname = "Kattekola";
        ((Employee)PTE).PrintFullName();
    }
}

