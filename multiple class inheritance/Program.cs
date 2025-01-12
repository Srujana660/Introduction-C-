//mutiple class interface - A class can inherit from multiple interfaces at the same time but not multiple classes.
//This is an example of multiple interface inherit in a class
//using System;
//interface IA
//{
//    void AMethod();
//}
//class A:IA
//{
//    public void AMethod()
//    {
//        System.Console.WriteLine("A");
//    }
//}
//interface IB
//{
//    void BMethod();
//}
//class B : IB
//{
//    public void BMethod()
//    {
//        System.Console.WriteLine("B");
//    }
//}
//class AB : IA,IB
//{
//    A a = new A();
//    B b = new B();
//    public void AMethod()
//    {
//        System.Console.WriteLine("A");
//    }
//    public void BMethod()
//    {
//        System.Console.WriteLine("B");
//    }
//}
//class program
//{
//    public static void Main()
//    {
//        AB aB = new AB();
//        aB.AMethod();
//        aB.BMethod();  
//    }
//}

//This is an example of using classes that inherit multiple classes. it won't execute as a class cannot
//inherit from the multiple classes
using System;
class A
{
    public virtual void Print()
    {
        Console.WriteLine("A");
    }
}
class B : A
{
    public override void Print()
    {
        Console.WriteLine("B");
    }
}
class C : A
{
    public override void Print()
    {
        Console.WriteLine("C");
    }
}
class D:B,C
{

}
class program
{
    public static void Manin()
    {
        D d = new D();
        d.Print();
    }
}