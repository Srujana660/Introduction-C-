//About Private and Public Access Modifiers
//using System;
//public class Customer
//{
//    private int _id=1;
//    public string Name = "Srujana";
//}
//    public class customers
//    {

//    public static void Main() 
//    { 
//        Customer c = new Customer();
//        //Here name prints because Name is public and id wont because its in private so it cant be accessed
//        Console.WriteLine(c.Name);
//        Console.WriteLine(c._id);
//    }
//}

// Protected Access MOdifier

using System;
using System.Runtime.CompilerServices;
public class Customer
{
    private int _id = 1;
    public string Name = "Srujana";
    protected int Age = 20;
}
public class customers:Customer
{

    public static void Main()
    {
        customers c = new customers();
        Console.WriteLine(c.Age);
     
    }
}