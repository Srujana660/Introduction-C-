//using System;
//interface Customer1
//{
//    void Print1();
//}
//interface Customer2 : Customer1
//{
//    void Print2();
//}
//public class ICustomer : Customer2
//{
//    public void Print1()
//    {
//        Console.WriteLine("Srujana");
//    }
//    public void Print2()
//    {
//        Console.WriteLine("Nayanala");
//    }
//}
//public class program
//{
//    public static void Main()
//    {
//        Customer1 c1 = new ICustomer();
//        c1.Print1();
//        c1.Print2();
//    }
//}

//Note: you are only getting the c1.print and not c1.print1 so remove it so, if you want to c1.print2 as well we need 
//to do explicit implementation. so for that the implementation is difference see in next code


using System;
interface Customer1
{
    void Print1();
}
interface Customer2 : Customer1
{
    void Print2();
}
public class ICustomer : Customer2
{
    public void Print1()
    {
        Console.WriteLine("Srujana");
    }
    void Customer2.Print2()
    {
        Console.WriteLine("Nayanala");
    }
}
public class program
{
    public static void Main()
    {
        Customer1 c1 = new ICustomer();
        c1.Print1();
        ((Customer2)c1).Print2 ();
    }
}
Note: In this you can see print1() is default and print2() is explicit. we removed public and assigned Customer2.Print2() and also last line ((Customer2)c1).Print2() 
    for explixit implementation.