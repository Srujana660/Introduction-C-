//using System;
//public abstract class Customer
//{
//    public abstract void Print();
    
//}
//public class Program : Customer
//{
//    public override void Print()
//    {
//        Console.WriteLine("Print Method");
//    }
//    public static void Main()
//    {
//        Customer c1 = new Program();
//        c1.Print();
    }
}
// Another code
using System;
public abstract class Customer
{
    public void Print()
    {
        Console.WriteLine("Print Method");
    }

}
public class Program : Customer
{
    public static void Main()
    {

    }
}
