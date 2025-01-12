using System;
interface Customer1
{
    void Print1();
}
interface Customer2:Customer1
{
    void Print2();
}
public class ICustomer: Customer2
{
    public void Print1()
    {
        Console.WriteLine("Srujana");
    }
    public void Print2()
    {
        Console.WriteLine("Nayanala");
    }
}
public class program
{
    public static void  Main()
    {
        Customer1 c1 = new ICustomer();
        c1.Print1();

    }
}